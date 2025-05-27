using System.Text.RegularExpressions;

namespace Projexor.Domain.ExceptionExtension;

public partial class EmailRegexException : Exception
{
    [GeneratedRegex(@"^[a-z0-9._%+-]+@[a-z0-9-]+(\.[a-zA-Z]{2,})+$", RegexOptions.IgnoreCase)]
    private static partial Regex EmailRegex();
    public EmailRegexException(string message) : base(message) { }

    public static void ThrowIfNotMatch(string email, string message)
    {
        if (!EmailRegex().IsMatch(email))
            throw new EmailRegexException(message);
    }
}