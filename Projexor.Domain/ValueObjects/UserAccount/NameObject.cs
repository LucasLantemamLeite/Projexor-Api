using Projexor.Domain.ExceptionExtension;

namespace Projexor.Domain.ValueObjects;

public class Name : ValueObject
{
    private string Value { get; }

    public Name(string name)
    {
        DomainException.ThrowIfError(string.IsNullOrEmpty(name), "Name não pode ser Vazio ou Nulo.");
        Value = name;
    }
}