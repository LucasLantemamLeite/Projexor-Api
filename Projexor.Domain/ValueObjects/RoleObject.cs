using Projexor.Domain.Enums;

namespace Projexor.Domain.ValueObject;

public class Role : ValueObject
{
    public ERole Value { get; set; }

    public Role(ERole role = ERole.User)
    {
        Value = role;
    }
}