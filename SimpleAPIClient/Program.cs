using System;
using Grpc.Core;
using Grpc.Core.Utils;
using Grpc.Core.Interceptors;
using Grpc.Net.Client;
using Grpc.Net.ClientFactory;
using SimpleAPI;

namespace SimpleAPIClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var greeter = new Greeter.GreeterClient(channel);

            var response = greeter.SayBishBashBosh(new HelloRequest(), new CallOptions());
            Console.WriteLine("Greeters says " + response.Message + " with count " + response.Value);
            Console.WriteLine("Goodbye!");
        }
    }
}
