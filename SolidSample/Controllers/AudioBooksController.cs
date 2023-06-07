using Microsoft.AspNetCore.Mvc;
using SolidSample.Model;
using SolidSample.Services;

namespace SolidSample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AudioBooksController : ControllerBase
{
    private readonly AudioBooksRepository audioBooksRepository = new ();

    [HttpGet]
    [LoggingFilter]
    public AudioBook[] GetAudioBooks()
    {
        return audioBooksRepository.GetAll();
    }

    [HttpPost]
    [LoggingFilter]
    public void SaveAudioBook(AudioBook audioBook)
    {
            audioBooksRepository.Save(audioBook);
    }
}