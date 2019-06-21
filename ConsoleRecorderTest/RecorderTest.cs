using ConsoleRecorderCore;
using Xunit;

namespace ConsoleRecorderTest
{
    public class RecorderTest
    {
        [Theory]
        [InlineData("Recorder developer", "devmarcelo.lbvdc.lbv.org.br", 8888)]
        public void WhenInstantiatedGetInstance(string name, string host, int port)
        {
            Recorder recorder = new Recorder(name, host, port);

            Assert.NotNull(recorder);
            Assert.Equal(name, recorder.Name);
            Assert.Equal(host, recorder.Host);
            Assert.Equal(port, recorder.Port);
        }
    }
}
