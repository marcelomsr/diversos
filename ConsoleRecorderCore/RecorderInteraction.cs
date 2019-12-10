using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleRecorderCore
{
    public class RecorderInteraction
    {
        public enum Command
        {
            COMANDO_INICIAR_GRAVACAO_CHAMADA = 1,
            COMANDO_PARAR_GRAVACAO_CHAMADA = 2,
            COMANDO_OBTER_CAMINHO_GRAVACAO_LIGACAO = 3,
            COMANDO_OBTER_INFORMACOES_GRAVADOR = 4,
            COMANDO_OBTER_INFORMACOES_CANAL_GRAVACAO = 5,
            COMANDO_OBTER_CAMINHO_GRAVACAO = 6,
            COMANDO_INFORMAR_DADOS_GRAVACAO_COMPLETA = 7,
            COMANDO_OBTER_INFORMACOES_QUOTA = 9,
            COMANDO_OBTER_GRAVACAO = 10,
            COMANDO_OBTER_VERSAO = 11
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
        public event AoComandoEnviadoHandler AoComandoEnviado;

        private bool _gravador_definido = false;

        public RecorderInteraction(Recorder recorder)
        {
            definir_endereco_gravador(recorder.Host, recorder.Port);
        }

        public void definir_endereco_gravador(string dsc_endereco_ip, int nmr_porta)
        {
            _dsc_endereco_ip = dsc_endereco_ip;
            _nmr_porta = nmr_porta;

            _gravador_definido = true;
        }

        public void conectar()
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

                so.mensagem.Append(Encoding.Default.GetString(so.buffer, 0, qtd_bytes_lidos));

                if (so.mensagem[so.mensagem.Length - 1] != '$')
                {
                    _socket.BeginReceive(so.buffer, 0, StateObject.BUFFER_SIZE, SocketFlags.None,
                        new AsyncCallback(tratar_iniciar_escuta), so);

                    return;
                }

                iniciar_escuta();

                string mensagem_nao_tratada = so.mensagem.ToString();

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

            Protocolo.decodificar(mensagem, ref comandoID, ref parametros);

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

        private string[] enviar_comando(string comando)
        {
            try
            {
                if (!_conectado)
                {
                    conectar();
                }

                byte[] mensagem_envio = Encoding.Default.GetBytes(comando);

                _socket.Send(mensagem_envio, SocketFlags.None);

                _evento_retorno.WaitOne(RETORNO_COMANDO_TIMEOUT);

                string[] retorno = null;

                copiar_parametros_retorno(ref retorno);

                AoComandoEnviado(comando);

                return retorno;
            }
            catch (SocketException e)
            {
                if (e.SocketErrorCode == SocketError.ConnectionReset)
                {
                    _conectado = false;

                    return enviar_comando(comando);
                }

                throw;
            }
        }

        public string obter_retorno()
        {
            return String.Join("&", _parametros_retorno);
        }

        public string obter_gravacao(int sqc_gravacao)
        {
            string[] parametros_retorno = enviar_comando($"{(int)Command.COMANDO_OBTER_GRAVACAO}@{sqc_gravacao}$");

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

        public string gravar(int chamadaID, string dispositivo, int quota = 1)
        {
            long cdg_agente = 1;
            long sqc_ligacao_atendida = 2;
            string dados_extra = "Q";

            _requisicao_ID++;

            string command = $"{(int)Command.COMANDO_INICIAR_GRAVACAO_CHAMADA}@{_requisicao_ID}&{chamadaID}&{dispositivo}&{cdg_agente}&{sqc_ligacao_atendida}&{dados_extra}&{quota}$";
            
            string[] parametros_retorno = enviar_comando(command);

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

        public string parar_gravar(int gravacaoID)
        {
            string motivo = "";
            string dta_permanencia = "";

            _requisicao_ID++;

            string[] parametros_retorno = enviar_comando(String.Format("{0:000}@{1}&{2}&{3}&{4}$",
                Command.COMANDO_PARAR_GRAVACAO_CHAMADA, _requisicao_ID, gravacaoID, motivo, dta_permanencia));

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

        public string obter_versao()
        {
            string[] parametros_retorno = enviar_comando($"{(int)Command.COMANDO_OBTER_VERSAO}@$");

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
