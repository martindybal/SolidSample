namespace SolidSample.Services;

public interface IQuery<T>
{
    IQueryable<T> ApplyTo(IQueryable<T> source);
}