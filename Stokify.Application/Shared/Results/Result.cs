namespace Stokify.Application.Shared.Results;

public sealed class Result<TResult>(string message, bool success, TResult? data)
{
    public string Message { get; init; } = message;
    public bool IsSuccess { get; init; } = success;
    public TResult? Data { get; init; } = data;

    public static Result<TResult> Success(string message, TResult? data = default) => new(message, true, data);
    public static Result<TResult> Fail(string message, TResult? data = default) => new(message, false, data);
}