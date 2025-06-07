namespace Projexor.Domain.ValueObject;

public class Email : ValueObject
{
    public string Value { get; }

    public Email(string email)
    {
        Value = email;
    }
}