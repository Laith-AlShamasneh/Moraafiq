using Microsoft.Data.SqlClient;
using Muraafiq.Infrastructure.Common;

namespace Muraafiq.Infrastructure.Persistence;

public static class SqlExceptionTranslator
{
    public static void ThrowIfStoredProcedureError(SqlException ex)
    {
        throw new SqlStoredProcedureException(
            ex.Number,
            ex.Message,
            ex);
    }
}
