namespace Projexor.Domain.ValueObjects;

public class Name : ValueObjects
{
    private string Value { get; }

    public Name(string name)
    {
        Value = name;
    }

    protected bool IsValidName(string name) => !string.IsNullOrWhiteSpace(name);
}