using System.Text.RegularExpressions;

namespace Stokify.Domain.Validations.Exceptions.User;

public partial class PhoneException(string message) : Exception(message)
{
    [GeneratedRegex(@"^\+(?=\d{10,15}$)\d{1,3}\d+$")]
    private static partial Regex PhoneRegex();

    public static void ThrowIfInvalid(string value, string message)
    {
        if (!PhoneRegex().IsMatch(value))
            throw new PhoneException(message);
    }
}