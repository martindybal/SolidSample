using Microsoft.EntityFrameworkCore;
using SolidSample.Model;

namespace SolidSample.Services;

public abstract class RepositoryBase<T> : IRepository<T>
    where T : class
{
    private readonly AppDbContext dbContext;

    protected RepositoryBase(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public virtual void Save(T item)
    {
        dbContext.Set<T>().Add(item);
        dbContext.SaveChanges();
    }

    public virtual T[] GetByQuery(IQuery<T> query)
    {
        return query.ApplyTo(dbContext.Set<T>())
            .AsNoTracking()
            .ToArray();
    }
}