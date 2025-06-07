namespace Projexor.Domain.ValueObject;

public class Login : ValueObject
{
    public string Value { get; }

    public Login(string login)
    {
        Value = login;
    }
}