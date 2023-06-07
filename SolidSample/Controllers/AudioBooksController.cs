using Microsoft.AspNetCore.Mvc;
using SolidSample.Model;
using SolidSample.Services;

namespace SolidSample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AudioBooksController : ControllerBase
{
    private readonly IRepository<AudioBook> audioBooksRepository = new AudioBooksRepository();

    [HttpGet]
    [LoggingFilter]
    public AudioBook[] GetAudioBooks()
    {
        return audioBooksRepository.GetByQuery(new AllAudioBooksQuery());
    }

    [HttpPost]
    [LoggingFilter]
    public void SaveAudioBook(AudioBook audioBook)
    {
        audioBooksRepository.Save(audioBook);
    }
}