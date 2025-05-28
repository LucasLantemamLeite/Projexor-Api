using Projexor.Domain.ExceptionExtension;

namespace Projexor.Domain.ValueObjects;

public class Email : ValueObject
{
    public string Value { get; } = null!;

    public Email() { }

    public Email(string email)
    {
        EmailRegexException.ThrowIfNotMatch(email, "E-mail Inválido.");
        Value = email;
    }
}