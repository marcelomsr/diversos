namespace ConsoleRecorder
{
    public class Gravador
    {
        public string _nome { protected set; get; }
        public string _ip { protected set; get; }
        public int _porta { protected set; get; }

        public Gravador(string nome, string ip, int porta)
        {
            _nome = nome;
            _ip = ip;
            _porta = porta;            
        }
    }
}
