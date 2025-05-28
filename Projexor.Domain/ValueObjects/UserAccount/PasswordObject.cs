using Projexor.Domain.ExceptionExtension;

namespace Projexor.Domain.ValueObjects;

public class Password : ValueObject
{
    public string Value { get; set; } = null!;

    public Password(string password)
    {
        DomainException.ThrowIfError(string.IsNullOrWhiteSpace(password), "Password não pode ser Vazio.");
        Value = password;
    }
}