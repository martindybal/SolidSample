using Microsoft.AspNetCore.Mvc.Filters;

namespace SolidSample.Services;

public class LoggingFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger>();
        logger.LogException(context.Exception);
        base.OnException(context);
    }
}