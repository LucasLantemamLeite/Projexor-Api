namespace Projexor.Domain.ValueObjects;

public class Active : ValueObject
{
    private bool Value { get; } = true;

    public Active(bool active)
    {
        Value = active;
    }
}