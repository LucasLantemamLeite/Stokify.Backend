namespace Stokify.Domain.Validations.Exceptions.Common;

public sealed class NullOrEmptyException(string message) : Exception(message)
{
    public static void ThrowIfIsNullOrEmpty(string value, string message)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new NullOrEmptyException(message);
    }
}