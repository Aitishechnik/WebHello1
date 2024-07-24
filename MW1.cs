namespace WebHello
{
    public class MW1
    {
        private RequestDelegate _next;

        public MW1(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if(context.Request.Path == "/time")
                await context.Response.WriteAsync($"{DateTime.Now.ToShortTimeString()}");
            await _next(context);
        }
    }
}
