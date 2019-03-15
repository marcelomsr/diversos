using System.Text;

namespace ConsoleRecorder
{
    public class StateObject
    {
        public const int BUFFER_SIZE = 1024; // 1 KB
        public byte[] buffer = new byte[BUFFER_SIZE];
        public StringBuilder mensagem = new StringBuilder();
    }
}
