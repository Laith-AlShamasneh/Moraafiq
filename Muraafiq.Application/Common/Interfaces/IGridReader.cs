namespace Muraafiq.Application.Common.Interfaces;

public interface IGridReader : IDisposable
{
    Task<IEnumerable<T>> ReadAsync<T>();
    Task<T> ReadFirstAsync<T>();
}
