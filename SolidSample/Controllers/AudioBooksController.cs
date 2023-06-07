using Microsoft.AspNetCore.Mvc;
using SolidSample.Model;

namespace SolidSample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AudioBooksController : ControllerBase
{
    [HttpGet]
    public AudioBook[] GetAudioBooks()
    {
        using var dbContext = new AppDbContext();
        return dbContext.AudioBooks.ToArray();
    }

    [HttpPost]
    public void SaveAudioBook(AudioBook audioBook)
    {
        using var dbContext = new AppDbContext();
        try
        {
            dbContext.AudioBooks.Add(audioBook);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            System.IO.File.AppendAllText($"logs\\{DateTime.Now:yyyy-MM-dd}.log", $"{DateTime.Now}: {ex}{Environment.NewLine}");
        }
    }
}