namespace ConsoleRecorderCore
{
    public class Recorder
    {
        public string Name { protected set; get; }
        public string Ip { protected set; get; }
        public int Port { protected set; get; }

        public Recorder(string name, string ip, int port)
        {
            Name = name;
            Ip = ip;
            Port = port;
        }
    }
}
