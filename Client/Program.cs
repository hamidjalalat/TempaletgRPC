// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcService1Client;
using Google.Protobuf;
using Grpc.Core;


Console.WriteLine("Hello, World!");
var channel = GrpcChannel.ForAddress("https://localhost:7102");

var client = new Greeter.GreeterClient(channel);
var result = await client.SayHelloAsync(new HelloRequest { Name = "hamid jalalat" });
Console.WriteLine(result.Message);
