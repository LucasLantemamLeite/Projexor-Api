namespace Projexor.Domain.ValueObject;

public class PhoneNumber : ValueObject
{
    public string Value { get; }

    public PhoneNumber(string phone_number)
    {
        Value = phone_number;
    }
}