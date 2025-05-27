namespace Projexor.Domain.ExceptionExtension;

public class DomainException : Exception
{
    public DomainException(string message) : base(message) { }

    public static void ThrowIfError(bool condition, string message)
    {
        if (condition)
        {
            throw new DomainException(message);
        }
    }
}