using SolidSample.Model;

namespace SolidSample.Services;

public class AudioBooksRepository
{
    public AudioBook[] GetAll()
    {
        using var dbContext = new AppDbContext();
        return dbContext.AudioBooks.ToArray();
    }

    public void Save(AudioBook audioBook)
    {
        using var dbContext = new AppDbContext();
        dbContext.AudioBooks.Add(audioBook);
        dbContext.SaveChanges();
    }
}