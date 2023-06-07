namespace SolidSample.Services;

public interface IRepository<T> : IQueryableRepository<T>, IUpdatableRepository<T>
{

}