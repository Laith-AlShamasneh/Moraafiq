using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Muraafiq.Application.Common.Interfaces;
using System.Data;

namespace Muraafiq.Infrastructure.Persistence;

internal class UnitOfWork(ISqlConnectionFactory connectionFactory) : IUnitOfWork
{
    private IDbConnection? _connection;
    private IDbTransaction? _transaction;
    private IGlobalExecuters? _globalActions;

    public IDbConnection Connection
    {
        get
        {
            _connection ??= connectionFactory.CreateConnection();
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
            return _connection;
        }
    }

    public IDbTransaction? Transaction => _transaction;

    // We pass 'this' (the UnitOfWork itself) so GlobalExecuters dynamically resolves 
    // the current connection and transaction, rather than caching stale references.
    public IGlobalExecuters GlobalActions => _globalActions ??= new GlobalExecuters(this);

    public void BeginTransaction()
    {
        if (_transaction is not null)
        {
            throw new InvalidOperationException("A transaction is already in progress. Parallel transactions are not allowed.");
        }

        _transaction = Connection.BeginTransaction();
    }

    public void Commit()
    {
        try
        {
            _transaction?.Commit();
        }
        catch
        {
            _transaction?.Rollback();
            throw;
        }
        finally
        {
            DisposeTransaction();
        }
    }

    public void Rollback()
    {
        try
        {
            _transaction?.Rollback();
        }
        finally
        {
            DisposeTransaction();
        }
    }

    private void DisposeTransaction()
    {
        _transaction?.Dispose();
        _transaction = null;
    }

    public async ValueTask DisposeAsync()
    {
        DisposeTransaction();

        if (_connection is IAsyncDisposable asyncConnection)
        {
            await asyncConnection.DisposeAsync();
        }
        else
        {
            _connection?.Dispose();
        }

        _connection = null;
    }
}
