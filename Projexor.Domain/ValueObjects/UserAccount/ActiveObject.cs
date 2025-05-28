namespace Projexor.Domain.ValueObjects;

public class Active : ValueObject
{
    public bool Value { get; } = true;

    public Active(bool active)
    {
        Value = active;
    }
}