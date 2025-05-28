using Projexor.Domain.ExceptionExtension;

namespace Projexor.Domain.ValueObjects;

public class Name : ValueObject
{
    public string Value { get; } = null!;

    public Name() { }

    public Name(string name)
    {
        DomainException.ThrowIfError(string.IsNullOrEmpty(name), "Name não pode ser Vazio.");
        Value = name;
    }
}