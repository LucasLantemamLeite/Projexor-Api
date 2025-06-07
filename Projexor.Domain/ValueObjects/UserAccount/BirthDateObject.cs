namespace Projexor.Domain.ValueObject;

public class BirthDate : ValueObject
{
    public DateTime Value { get; }

    public BirthDate(DateTime date)
    {
        Value = date;
    }
}