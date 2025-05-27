namespace Projexor.Domain.ExceptionExtension;

public class BirthDateException : Exception
{
    public BirthDateException(string message) : base(message) { }

    public static void ThrowIfError(DateTime date, string message)
    {
        if (date > DateTime.Today)
            throw new BirthDateException(message);
    }
}