using Projexor.Domain.ValueObjects;

namespace Projexor.Domain.Entity;

public class UserAccount : Entity
{
    public int Id { get; private set; }
    public Name Name { get; private set; }

    public UserAccount(string name)
    {
        Name = new Name(name);
    }
}