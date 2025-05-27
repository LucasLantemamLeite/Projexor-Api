using Projexor.Domain.ExceptionExtension;

namespace Projexor.Domain.ValueObjects;

public class BirthDate : ValueObject
{
    private DateTime Value { get; }

    public BirthDate(DateTime date)
    {
        BirthDateException.ThrowIfError(date, "BirthDate não pode ser uma data futura.");
        Value = date;
    }
}