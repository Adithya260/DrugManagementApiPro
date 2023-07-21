namespace DrugManagementApiPro
{
    public class DrugMiddleware
    {
        private readonly RequestDelegate _next;
        public DrugMiddleware (RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path == "/api/User" && context.Request.Method.ToUpper() == "POST")
            {
                // Skip this middleware and continue to the next one in the pipeline
                await _next.Invoke(context);


            }
            else

            {
                //Set the status code to 200
                context.Response.StatusCode = 200;
                await _next.Invoke(context);

            }
           
        }
    }
}
