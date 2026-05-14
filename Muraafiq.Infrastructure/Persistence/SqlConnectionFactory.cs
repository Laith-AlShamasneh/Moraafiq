using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Muraafiq.Infrastructure.Persistence;

internal interface ISqlConnectionFactory
{
    IDbConnection CreateConnection();
}

internal class SqlConnectionFactory(IConfiguration configuration) : ISqlConnectionFactory
{
    private readonly string _connectionString = configuration.GetConnectionString("SqlConnection")
        ?? throw new InvalidOperationException("Connection string 'SqlConnection' not found in configuration.");

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }
}
