using SolidSample.Model;

namespace SolidSample.Services;

public class AudioBooksRepository : IRepository<AudioBook>
{
    ///// <summary>
    ///// Get all audio books
    ///// </summary>
    //public AudioBook[] GetAll()
    //{
    //    using var dbContext = new AppDbContext();
    //    return dbContext.AudioBooks.ToArray();
    //}

    ///// <summary>
    ///// Get audio book where name contains <paramref name="name"/>
    ///// </summary>
    ///// <param name="name"></param>
    //public AudioBook[] GetByName(string name)
    //{
    //    using var dbContext = new AppDbContext();
    //    return dbContext.AudioBooks
    //                    .Where(c => c.Name.Contains(name))
    //                    .ToArray();
    //}

    ///// <summary>
    ///// Get all audio books in category <paramref name="categoryId"/>
    ///// </summary>
    ///// <param name="categoryId"></param>
    //public AudioBook[] GetByCategory(Guid categoryId)
    //{
    //    using var dbContext = new AppDbContext();
    //    return dbContext.AudioBooks
    //                    .Where(c => c.CategoryId == categoryId)
    //                    .ToArray();
    //}

    ///// <summary>
    ///// Get all audio books by author <paramref name="authorId"/>
    ///// </summary>
    ///// <param name="authorId"></param>
    //public AudioBook[] GetByAuthor(Guid authorId)
    //{
    //    using var dbContext = new AppDbContext();
    //    return dbContext.AudioBooks
    //                    .Where(c => c.AuthorId == authorId)
    //                    .ToArray();
    //}


    ///// <summary>
    ///// Get all audio books by publisher <paramref name="publisherId"/>
    ///// </summary>
    ///// <param name="publisherId"></param>
    ///// <returns></returns>
    //public AudioBook[] GetByPublisher(Guid publisherId)
    //{
    //    using var dbContext = new AppDbContext();
    //    return dbContext.AudioBooks
    //                    .Where(c => c.PublisherId == publisherId)
    //                    .ToArray();
    //}

    public AudioBook[] GetByQuery(IQuery<AudioBook> query)
    {
        using var dbContext = new AppDbContext();
        return query.ApplyTo(dbContext.AudioBooks)
                    //.AsNoTracking() // What if you need to add this in the previous example? :)
                    .ToArray();
    }

    public void Save(AudioBook audioBook)
    {
        using var dbContext = new AppDbContext();
        dbContext.AudioBooks.Add(audioBook);
        dbContext.SaveChanges();
    }
}