namespace ConsoleRecorderCore
{
    public class Recorder
    {
        public string Name { protected set; get; }
        public string Host { protected set; get; }
        public int Port { protected set; get; }

        public Recorder(string name, string host, int port)
        {
            Name = name;
            Host = host;
            Port = port;            
        }
    }
}
