using Microsoft.AspNetCore.Identity.Data;

namespace DecoratorPattern.API.Application.Common.Results;

public class Result
{
    public string[] ErrorMessages { get; set; } = [];
    public bool IsSuccess => ErrorMessages == Array.Empty<string>();
    public bool IsFailure => !IsSuccess;

    internal Result()
    {
    }

    private Result(string[] errorMessages)
    {
        ErrorMessages = errorMessages;
    }

    public static Result Success() => new();
    public static Result<T> Success<T>(T data) => new(data);
    public static Result Failure(string[] errorMessages) => new(errorMessages);
}

public class Result<T> : Result
{
    public T? Data { get; }

    internal Result(T data)
    {
        Data = data;
    }

    private Result(string[] errorMessages)
    {
        ErrorMessages = errorMessages;
    }

    public static Result<T> Success(T data) => new(data);
    public new static Result<T> Failure(string[] errorMessages) => new(errorMessages);
}
