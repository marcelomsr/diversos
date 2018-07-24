
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Console
{
    public class InstanciaItem
    {
        public int id { get; private set; }
        public string nome { get; private set; }
        public string ip { get; private set; }
        public int porta { get; private set; }
        public bool exigir_autenticacao { get; private set; }

        public InstanciaItem(int id, string nome, string ip, int porta, bool exigir_autenticacao)
        {
            this.id = id;
            this.nome = nome;
            this.ip = ip;
            this.porta = porta;

            this.exigir_autenticacao = exigir_autenticacao;

            verificar_ping();
        }

        public static InstanciaItem CriarPersonalizada(string ip, int porta, bool exigir_autenticacao)
        {
            return new InstanciaItem(-1, string.Format("<{0}:{1}>", ip, porta), ip, porta, exigir_autenticacao);
        }

        private void verificar_ping()
        {
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(ip, 100);

            if (reply.Status != IPStatus.Success)
                nome += " (OFF)";
        }
    }
}
