namespace Stokify.Application.Results;

public sealed class Result<TResult>(string message, bool success = true, TResult? result = default)
{
    public string Message { get; init; } = message;
    public bool IsSuccess { get; init; } = success;
    public TResult? Data { get; init; } = result;

    public static Result<TResult> Ok(string message, TResult? data = default) => new(message, true, data);
    public static Result<TResult> Fail(string message) => new(message, false);
}