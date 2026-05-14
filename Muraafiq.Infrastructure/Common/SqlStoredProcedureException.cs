namespace Muraafiq.Infrastructure.Common;

public class SqlStoredProcedureException(int errorNumber, string message, Exception? innerException = null) : Exception(message, innerException)
{
    public int ErrorNumber { get; } = errorNumber;
}
