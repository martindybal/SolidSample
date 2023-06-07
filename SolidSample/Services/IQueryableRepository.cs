namespace SolidSample.Services;

public interface IQueryableRepository<T>
{
    T[] GetByQuery(IQuery<T> query);
}