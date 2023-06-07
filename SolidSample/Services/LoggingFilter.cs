using Microsoft.AspNetCore.Mvc.Filters;

namespace SolidSample.Services;

public class LoggingFilter : ExceptionFilterAttribute
{
    private readonly FileLogger fileLogger = new ();

    public override void OnException(ExceptionContext context)
    {
        fileLogger.LogException(context.Exception);
        base.OnException(context);
    }
}