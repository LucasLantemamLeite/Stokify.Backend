using System.Text.RegularExpressions;

namespace Stokify.Domain.Validations.Exceptions.User;

public partial class EmailException(string message) : Exception(message)
{
    [GeneratedRegex(@"^(?=.{1,254})(?!\.|\-|\$|\*|\+|\.|!|#|=|%|&|'|\/|=|\^|_|{|}|~|-)(?!.*(\.\.|\-\-))(?!.*(\.|\-|\$|\*|\+|\.|!|#|=|%|&|'|\/|=|\^|_|{|}|~|-)\@)[A-Za-z0-9!#$%&'*+/=?^_{|}~.-]{1,64}@(?!\-)[A-Za-z0-9\-]{1,63}\.[A-Za-z]{1,63}(\.[A-Za-z]{1,63})?$")]
    private static partial Regex EmailRegex();

    public static void ThrowIfInvalid(string value, string message)
    {
        if (!EmailRegex().IsMatch(value))
            throw new EmailException(message);
    }
}