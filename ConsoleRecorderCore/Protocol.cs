using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;

namespace ConsoleRecorderCore
{
    public class Protocol
    {
        private const int TAMANHO_MENSAGEM_RETORNO = 256;

        public static string enviar_comando(string comando, Socket socket)
        {
            try
            {
                byte[] mensagem_envio = Encoding.UTF8.GetBytes(comando);

                socket.Send(mensagem_envio, SocketFlags.None);

                byte[] mensagem_retorno = new byte[TAMANHO_MENSAGEM_RETORNO];

                socket.Receive(mensagem_retorno, mensagem_retorno.Length, SocketFlags.None);

                return new string(Encoding.UTF8.GetChars(mensagem_retorno));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string enviar_comando(string comando, SslStream ssl_stream)
        {
            try
            {
                byte[] mensagem_envio = Encoding.UTF8.GetBytes(comando);

                ssl_stream.Write(mensagem_envio, 0, mensagem_envio.Length);

                byte[] mensagem_retorno = new byte[TAMANHO_MENSAGEM_RETORNO];

                ssl_stream.Read(mensagem_retorno, 0, mensagem_retorno.Length);

                return new string(Encoding.UTF8.GetChars(mensagem_retorno));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool decodificar(string mensagem, ref int comando, ref string[] parametros)
        {
            //
            int posicao_comando = mensagem.IndexOf("@", 0);

            // FIXME: Verificação temporária para evitar decodificar a mensagem 
            // de um gravador PCS.
            if (posicao_comando == -1)
            {
                return false;
            }

            comando = Convert.ToInt32(mensagem.Substring(0, posicao_comando));

            return decodificar(comando, mensagem, ref parametros);
        }

        public static bool decodificar(int comando_experado, string mensagem, ref string[] parametros)
        {
            int posicao_comando = mensagem.IndexOf("@", 0);

            // FIXME: Verificação temporária para evitar decodificar a mensagem 
            // de um gravador PCS.
            if (posicao_comando == -1)
            {
                return false;
            }

            int posicao_final_comando = mensagem.IndexOf("$", 0);

            if (Convert.ToInt32(mensagem.Substring(0, posicao_comando)) == comando_experado)
            {
                parametros = mensagem.Substring(posicao_comando + 1, posicao_final_comando - posicao_comando - 1).Split('&');
            }

            return true;
        }
    }
}
