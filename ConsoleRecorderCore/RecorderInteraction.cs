using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ConsoleRecorderCore
{
    public class RecorderInteraction
    {
        public enum Command
        {
            ENVIAR_MENSAGEM_ESPECIFICA = 0,
            INICIAR_GRAVACAO_CHAMADA = 1,
            PARAR_GRAVACAO_CHAMADA = 2,
            OBTER_CAMINHO_GRAVACAO_LIGACAO = 3,
            OBTER_INFORMACOES_GRAVADOR = 4,
            OBTER_INFORMACOES_CANAL_GRAVACAO = 5,
            OBTER_CAMINHO_GRAVACAO = 6,
            INFORMAR_DADOS_GRAVACAO_COMPLETA = 7,
            OBTER_INFORMACOES_QUOTA = 9,
            OBTER_GRAVACAO = 10,
            OBTER_VERSAO = 11
        }

        private const int RETORNO_COMANDO_TIMEOUT = 20000000; // milissegundos

        public delegate void SocketErroHandler(string nova_situacao);
        public event SocketErroHandler AoReceberErroSocket;

        private Socket _socket;
        private AutoResetEvent _evento_retorno;
        private string[] _parametros_retorno;
        private int _requisicao_ID = 0;

        public string _dsc_endereco_ip { protected set; get; }
        public int _nmr_porta { protected set; get; }

        protected bool _conectado;

        public delegate void AoComandoEnviadoHandler(string comando);
        public event AoComandoEnviadoHandler CommandSended;

        public RecorderInteraction(Recorder recorder)
        {
            _dsc_endereco_ip = recorder.Host;
            _nmr_porta = recorder.Port;
        }

        public void Connect()
        {
            try
            {
                _evento_retorno = new AutoResetEvent(false);

                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _socket.Connect(Dns.GetHostAddresses(_dsc_endereco_ip)[0], _nmr_porta);

                iniciar_escuta();
            }
            catch (SocketException e)
            {
                if (e.SocketErrorCode == SocketError.ConnectionRefused)
                {
                    throw new Exception("Infelizmente não foi possível acessar o servidor.");
                }

                throw;
            }
            catch (Exception)
            {
                throw;
            }

            _conectado = true;
        }

        public void desconectar()
        {
            _conectado = false;

            if (_socket.Connected)
            {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
            }
        }

        private void iniciar_escuta()
        {
            StateObject so = new StateObject();

            _socket.BeginReceive(so.buffer, 0, StateObject.BUFFER_SIZE, SocketFlags.None,
                new AsyncCallback(tratar_iniciar_escuta), so);
        }

        private void tratar_iniciar_escuta(IAsyncResult result)
        {
            try
            {
                StateObject so = (StateObject)result.AsyncState;

                int qtd_bytes_lidos = _socket.EndReceive(result);

                so.message.Append(Encoding.Default.GetString(so.buffer, 0, qtd_bytes_lidos));

                if (so.message[so.message.Length - 1] != '$')
                {
                    _socket.BeginReceive(so.buffer, 0, StateObject.BUFFER_SIZE, SocketFlags.None,
                        new AsyncCallback(tratar_iniciar_escuta), so);

                    return;
                }

                iniciar_escuta();

                string mensagem_nao_tratada = so.message.ToString();

                string[] mensagens = mensagem_nao_tratada.Split('$');

                foreach (string mensagem in mensagens)
                {
                    if (mensagem.Length > 0)
                    {
                        executar_comando(mensagem + '$');
                    }
                }
            }
            catch (SocketException soEx)
            {
                if (AoReceberErroSocket != null)
                    AoReceberErroSocket(soEx.Message);
            }
        }

        private void executar_comando(string mensagem)
        {
            int comandoID = 0;
            string[] parametros = new string[] { };

            Protocol.decodificar(mensagem, ref comandoID, ref parametros);

            switch (comandoID)
            {
                default:

                    lock (this)
                    {
                        _parametros_retorno = parametros;
                        _evento_retorno.Set();
                    }

                    break;
            }
        }

        private void copiar_parametros_retorno(ref string[] parametros)
        {
            lock (this)
            {
                parametros = (string[])_parametros_retorno.Clone();
            }
        }

        private string[] SendCommand(string comando)
        {
            try
            {
                if (!_conectado)
                {
                    Connect();
                }

                byte[] mensagem_envio = Encoding.Default.GetBytes(comando);

                _socket.Send(mensagem_envio, SocketFlags.None);

                _evento_retorno.WaitOne(RETORNO_COMANDO_TIMEOUT);

                string[] retorno = null;

                copiar_parametros_retorno(ref retorno);

                if(CommandSended != null)
                    CommandSended(comando);

                return retorno;
            }
            catch (SocketException e)
            {
                if (e.SocketErrorCode == SocketError.ConnectionReset)
                {
                    _conectado = false;

                    return SendCommand(comando);
                }

                throw;
            }
        }

        public string GetResponse()
        {
            return String.Join("&", _parametros_retorno);
        }

        public string GetPathRecording(int sqc_gravacao)
        {
            string[] parametros_retorno = SendCommand($"{(int)Command.OBTER_CAMINHO_GRAVACAO}@{sqc_gravacao}$");

            int retorno = Convert.ToInt32(parametros_retorno[parametros_retorno.Length - 1]);

            string gravacao = "";

            switch (retorno)
            {
                case 0:
                    gravacao = parametros_retorno[0];
                    break;

                case 1:
                    gravacao = "Não foi possível obter a gravação.";
                    break;
            }

            return gravacao;
        }

        public string GetRecording(int sqc_gravacao)
        {
            string[] parametros_retorno = SendCommand($"{(int)Command.OBTER_GRAVACAO}@{sqc_gravacao}$");

            int retorno = Convert.ToInt32(parametros_retorno[parametros_retorno.Length - 1]);

            string gravacao = "";

            switch (retorno)
            {
                case 0:
                    gravacao = parametros_retorno[0];
                    break;

                case 1:
                    gravacao = "Não foi possível obter a gravação.";
                    break;
            }

            return gravacao;
        }

        public string Record(int chamadaID, string dispositivo, int quota = 1)
        {
            long cdg_agente = 1;
            long sqc_ligacao_atendida = 2;
            string dados_extra = "Q";

            _requisicao_ID++;

            string command = $"{(int)Command.INICIAR_GRAVACAO_CHAMADA}@{_requisicao_ID}&{chamadaID}&{dispositivo}&{cdg_agente}&{sqc_ligacao_atendida}&{dados_extra}&{quota}$";
            
            string[] parametros_retorno = SendCommand(command);

            int retorno = Convert.ToInt32(parametros_retorno[parametros_retorno.Length - 1]);

            string retorno_servidor = "";

            switch (retorno)
            {
                case 0:
                    retorno_servidor = String.Format("Sucesso: RequisicaoID {0} GravacaoID {1}", parametros_retorno[0], parametros_retorno[1]);
                    break;

                case 1:
                    retorno_servidor = "Insucesso (Erro genérico).";
                    break;

                case 2:
                    retorno_servidor = "Nenhum canal livre.";
                    break;

                case 3:
                    retorno_servidor = "Dispositivo Atendimento Tardio.";
                    break;

                case 4:
                    retorno_servidor = "Ligação não encontrada";
                    break;

                case 5:
                    retorno_servidor = "Dispositivo ocupado.";
                    break;

                case 6:
                    retorno_servidor = "Dispositivo inválido.";
                    break;

                case 7:
                    retorno_servidor = "Chamada Limite Conferência.";
                    break;

                case 8:
                    retorno_servidor = "Funcionalidade não suportada.";
                    break;

                case 9:
                    retorno_servidor = "Violação Acesso.";
                    break;

                case 10:
                    retorno_servidor = "Gravador desabilitado.";
                    break;

                default:
                    break;
            }

            return retorno_servidor;
        }

        public string StopRecord(int gravacaoID)
        {
            string motivo = "";
            string dta_permanencia = "";

            _requisicao_ID++;

            string[] parametros_retorno = SendCommand($"{(int)Command.PARAR_GRAVACAO_CHAMADA}@{_requisicao_ID}&{gravacaoID}&{motivo}&{dta_permanencia}$");

            int retorno = Convert.ToInt32(parametros_retorno[parametros_retorno.Length - 1]);

            string retorno_servidor = "";

            switch (retorno)
            {
                case 0:
                    retorno_servidor = $"Sucesso: RequisicaoID {parametros_retorno[0]}";
                    break;

                case 1:
                    retorno_servidor = "Insucesso (Erro genérico).";
                    break;

                case 2:
                    retorno_servidor = "Gravação ignorada.";
                    break;

                case 4:
                    retorno_servidor = "Gravação inexistente.";
                    break;

                default:
                    break;
            }

            return retorno_servidor;
        }

        public string GetVersion()
        {
            string[] parametros_retorno = SendCommand($"{(int)Command.OBTER_VERSAO}@$");

            int retorno = Convert.ToInt32(parametros_retorno[parametros_retorno.Length - 1]);
            
            string retorno_servidor = "";

            switch (retorno)
            {
                case 0:
                    retorno_servidor = String.Format("{0}", parametros_retorno[0]);
                    break;
            }

            return retorno_servidor;
        }

        public string SendEspecificMessage(String message)
        {
            string[] parametros_retorno = SendCommand($"{message}");

            int retorno = Convert.ToInt32(parametros_retorno[parametros_retorno.Length - 1]);

            string retorno_servidor = "";

            switch (retorno)
            {
                case 0:
                    retorno_servidor = String.Format("{0}", parametros_retorno[0]);
                    break;
            }

            return retorno_servidor;
        }
    }
}
