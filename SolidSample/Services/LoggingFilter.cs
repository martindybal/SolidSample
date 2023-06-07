using Microsoft.AspNetCore.Mvc.Filters;

namespace SolidSample.Services;

public class LoggingFilter : ExceptionFilterAttribute
{
    private readonly ILogger logger = new FileLogger();

    public override void OnException(ExceptionContext context)
    {
        logger.LogException(context.Exception);
        base.OnException(context);
    }
}