namespace SolidSample.Services;

public interface IRepository<T>
{
    T[] GetByQuery(IQuery<T> query);
    void Save(T customer);
}