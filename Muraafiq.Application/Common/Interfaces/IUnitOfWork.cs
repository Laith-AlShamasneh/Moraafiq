using System.Data;

namespace Muraafiq.Application.Common.Interfaces;

public interface IUnitOfWork : IAsyncDisposable
{
    void BeginTransaction();
    void Commit();
    void Rollback();

    IDbConnection Connection { get; }
    IDbTransaction? Transaction { get; }
    IGlobalExecuters GlobalActions { get; }
}
