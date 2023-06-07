using SolidSample.Model;

namespace SolidSample.Services;

public class AudioBooksRepository : RepositoryBase<AudioBook>
{
    public override void Save(AudioBook item)
    {
        //You can do anything before
        
        base.Save(item); //You should always call base method

        //You can do anything after
    }
}