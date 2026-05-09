using System.Diagnostics;

namespace COMP003B.SP26.FinalProject.GonzalezA.Middleware
{
	public class RequestTimingMiddleware
	{
		private readonly RequestDelegate _next;

		public RequestTimingMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task Invoke(HttpContext context)
		{
			var stopwatch = Stopwatch.StartNew();

			await _next(context);

			stopwatch.Stop();

			Console.WriteLine($"Request: {context.Request.Method} Path: {context.Request.Path} Time: {stopwatch.ElapsedMilliseconds} ms");
		}
	}
}
