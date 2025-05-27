using System.Text.RegularExpressions;
using Projexor.Domain.ExceptionExtension;

namespace Projexor.Domain.ValueObjects;

public class PhoneNumber : ValueObject
{
    private string Value { get; }

    public PhoneNumber(string phone_number)
    {
        DomainException.ThrowIfError(!Regex.IsMatch(@"^\+\d{8,15}$", phone_number), "Phone Number não é válido.");
        Value = phone_number;
    }
}