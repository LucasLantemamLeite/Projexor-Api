namespace Projexor.Domain.ValueObject;

public class Password : ValueObject
{
    public string Value { get; }

    public Password(string password)
    {
        Value = password;
    }
}