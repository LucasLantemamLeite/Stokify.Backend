namespace Stokify.Domain.Validations.Exceptions.Common;

public sealed class IsNumberException(string message) : Exception(message)
{
    public static void ThrowIfNotIsNumber(string value, string type, string message)
    {
        switch (type.ToLower())
        {
            case "int":
                TryConvertToInt(value, message);
                break;

            case "decimal":
                TryConvertToDecimal(value, message);
                break;

            default:
                TryConvertToInt(value, message);
                break;
        }
    }

    private static void TryConvertToInt(string value, string message)
    {
        if (!int.TryParse(value, out var _))
            throw new IsNumberException(message);
    }

    private static void TryConvertToDecimal(string value, string message)
    {
        if (!decimal.TryParse(value, out var _))
            throw new IsNumberException(message);
    }
}