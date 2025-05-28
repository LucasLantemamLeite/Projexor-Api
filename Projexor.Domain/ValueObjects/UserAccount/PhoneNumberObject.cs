using System.Text.RegularExpressions;
using Projexor.Domain.ExceptionExtension;

namespace Projexor.Domain.ValueObjects;

public class PhoneNumber : ValueObject
{
    private string Value { get; } = null!;

    public PhoneNumber(string phone_number)
    {
        var phoneNumberFormat = PhoneNumberException.ThrowIfNotMatch(phone_number, "`Phone Number Inválido.");
        Value = phoneNumberFormat;
    }
}