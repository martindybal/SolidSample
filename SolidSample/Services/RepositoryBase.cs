using Microsoft.EntityFrameworkCore;
using SolidSample.Model;

namespace SolidSample.Services;

public abstract class RepositoryBase<T> : IRepository<T>
    where T : class
{
    public virtual void Save(T item)
    {
        using var dbContext = new AppDbContext();
        dbContext.Set<T>().Add(item);
        dbContext.SaveChanges();
    }

    public virtual T[] GetByQuery(IQuery<T> query)
    {
        using var dbContext = new AppDbContext();
        return query.ApplyTo(dbContext.Set<T>())
            .AsNoTracking()
            .ToArray();
    }
}