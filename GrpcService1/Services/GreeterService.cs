using Grpc.Core;
using GrpcService1;

namespace GrpcService1.Services
{
	public class GreeterService : Greeter.GreeterBase
	{
		private readonly ILogger<GreeterService> _logger;
		public GreeterService(ILogger<GreeterService> logger)
		{
			_logger = logger;
		}

		public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
		{
			WebApi.WeatherForecast weatherForecast = new WebApi.WeatherForecast();
			
			return Task.FromResult(new HelloReply
			{
				Message = weatherForecast.DateNow() + request.Name 
			});
		}
	}
}