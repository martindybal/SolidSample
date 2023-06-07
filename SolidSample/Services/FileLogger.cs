namespace SolidSample.Services;

public class FileLogger : ILogger
{
    public void LogException(Exception ex)
    {
        File.AppendAllText(GetLogFilePath(), FormatErrorMessage(ex));
    }

    private string FormatErrorMessage(Exception ex)
    {
        return $"{DateTime.Now}: {ex}{Environment.NewLine}";
    }

    private string GetLogFilePath()
    {
        return $"logs\\{DateTime.Now:yyyy-MM-dd}.log";
    }
}