using SolidSample.Model;

namespace SolidSample.Services;

public class AllAudioBooksQuery : IQuery<AudioBook>
{
    public IQueryable<AudioBook> ApplyTo(IQueryable<AudioBook> source)
    {
        return source;
    }
}