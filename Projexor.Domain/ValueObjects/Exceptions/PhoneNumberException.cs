using System.Text.RegularExpressions;

namespace Projexor.Domain.ExceptionExtension;

public partial class PhoneNumberException : Exception
{
    [GeneratedRegex(@"^\+[\d().-]{8,20}$")]
    private static partial Regex PhoneNumberRegex();

    public PhoneNumberException(string message) : base(message) { }

    public static string ThrowIfNotMatch(string phone_number, string message)
    {
        var phoneNumberFormat = FormatPhoneNumber(phone_number);

        if (!PhoneNumberRegex().IsMatch(phoneNumberFormat))
            throw new PhoneNumberException(message);

        return phoneNumberFormat;
    }

    protected static string FormatPhoneNumber(string phone_number)
    {
        var formatNumber = phone_number.Replace("(", "").Replace(")", "").Replace(".", "").Replace("-", "");
        return formatNumber;
    }
}