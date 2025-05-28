using Projexor.Domain.ExceptionExtension;

namespace Projexor.Domain.ValueObjects;

public class Login : ValueObject
{
    public string Value { get; } = null!;

    public Login() { }

    public Login(string login)
    {
        DomainException.ThrowIfError(string.IsNullOrWhiteSpace(login), "Login não pode ser Vazio.");
        Value = login;
    }
}