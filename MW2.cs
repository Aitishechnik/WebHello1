namespace WebHello
{
    public class MW2
    {
        private RequestDelegate _next;

        public MW2(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path == "/date")
                await context.Response.WriteAsync($"{DateTime.Today.ToShortDateString()}");
            await _next(context);
        }
    }
}
