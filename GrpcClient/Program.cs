using Grpc.Net.Client;
using GrpcService;
using System;
using System.Threading.Tasks;

namespace GrpcGreeterClient
{
	class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var client = new Greeter.GreeterClient(channel);
            
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "GreeterClient" });

            var reply2 = await client.ObterProfissionalAsync(
                  new HelloRequest { Name = "GreeterClient" });

            Console.WriteLine("Greeting: " + reply2.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}