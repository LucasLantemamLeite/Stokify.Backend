namespace Stokify.Domain.Validations.Exceptions.Common;

public sealed class MaxLenghtException(string message) : Exception(message)
{
    public static void ThrowIfGreaterThan(string? value, int maxLen, string message)
    {
        if (!string.IsNullOrEmpty(value) && value.Length > maxLen)
            throw new MaxLenghtException(message);
    }
}