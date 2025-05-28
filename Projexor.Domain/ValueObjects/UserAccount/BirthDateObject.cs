using Projexor.Domain.ExceptionExtension;

namespace Projexor.Domain.ValueObjects;

public class BirthDate : ValueObject
{
    public DateTime Value { get; }

    public BirthDate(DateTime date)
    {
        BirthDateException.ThrowIfError(date, "Birth Date não pode ser uma data futura.");
        Value = date;
    }
}