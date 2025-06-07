namespace Projexor.Domain.ValueObject;

public class CreateAt : ValueObject
{
    public DateTime Value { get; }

    public CreateAt()
    {
        Value = DateTime.UtcNow;
    }
}