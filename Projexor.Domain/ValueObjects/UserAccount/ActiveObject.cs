namespace Projexor.Domain.ValueObject;

public class Active : ValueObject
{
    public bool Value { get; }

    public Active(bool active = true)
    {
        Value = active;
    }
}