using Projexor.Domain.Entity;

namespace Projexor.Data.Repository.Result;

public class ResultPattern<T> where T : Entity
{
    public bool Success { get; private set; }
    public string Message { get; private set; }
    public T? Data { get; private set; }

    private ResultPattern(bool success, T? data, string message = "")
    {
        Success = success;
        Message = message;
        Data = data;
    }

    public static ResultPattern<T> Ok(T data, string message = "")
        => new(true, data, message);

    public static ResultPattern<T> Fail(string message = "")
        => new(false, default, message);

}