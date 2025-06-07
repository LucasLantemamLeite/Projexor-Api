namespace Projexor.Domain.Entity;

public class Entity
{
    public Guid Id { get; }

    protected Entity()
    {
        Id = Guid.NewGuid();
    }

    protected Entity(Guid id)
    {
        Id = id;
    }
}