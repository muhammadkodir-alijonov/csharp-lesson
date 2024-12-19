namespace CarShop.Api.Middlewares
{
    public class RequestRegisterMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _env;

        public RequestRegisterMiddleware(RequestDelegate requestDelegate,
            IWebHostEnvironment webHostEnvironment)
        {
            this._next = requestDelegate;
            this._env = webHostEnvironment;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            string path = Path.Combine(_env.WebRootPath, "requests", "Requests.txt");
            string content = httpContext.Request.Method + "--> " +
                             httpContext.Request.Path + "--> " +
                             DateTime.Now + "--> " +
                             httpContext.Connection.RemoteIpAddress + "--> " +
                             httpContext.Request.Headers["User-Agent"] + "\n";
            await File.AppendAllTextAsync(path, content);
            httpContext.Response.Headers.Add("Kotta", "Abdullaziz");
            await _next(httpContext);
        }
    }
}
