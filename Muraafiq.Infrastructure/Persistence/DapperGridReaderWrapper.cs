using Muraafiq.Application.Common.Interfaces;
using static Dapper.SqlMapper;

namespace Muraafiq.Infrastructure.Persistence;

internal class DapperGridReaderWrapper(GridReader reader) : IGridReader
{
    public async Task<IEnumerable<T>> ReadAsync<T>() => await reader.ReadAsync<T>();
    public async Task<T> ReadFirstAsync<T>() => await reader.ReadFirstAsync<T>();
    public void Dispose() { }
}
