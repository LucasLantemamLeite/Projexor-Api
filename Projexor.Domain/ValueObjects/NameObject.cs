namespace Projexor.Domain.ValueObject;

public class Name : ValueObject
{
    public string Value { get; }

    public Name(string name)
    {
        Value = name;
    }
}