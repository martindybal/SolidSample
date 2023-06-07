namespace SolidSample.Model;

public class AudioBook
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public AudioBook(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}