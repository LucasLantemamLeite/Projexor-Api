using Projexor.Domain.ExceptionExtension;

namespace Projexor.Domain.ValueObjects;

public class Email : ValueObject
{
    private string Value { get; }

    public Email(string email)
    {
        EmailRegexException.ThrowIfNotMatch(email, "E-mail Inválido.");
        Value = email;
    }
}