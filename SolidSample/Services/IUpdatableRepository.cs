namespace SolidSample.Services;

public interface IUpdatableRepository<in T>
{
    void Save(T item);
}