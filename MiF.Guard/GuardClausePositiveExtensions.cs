using MiF.Guard.Interfaces;
using System.Runtime.CompilerServices;

namespace MiF.Guard;

public static partial class GuardClauseExtensions
{
    public static int Positive(this IGuardClause guardClause, int input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return Positive<int>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static long Positive(this IGuardClause guardClause, long input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return Positive<long>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static double Positive(this IGuardClause guardClause, double input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return Positive<double>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static decimal Positive(this IGuardClause guardClause, decimal input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return Positive<decimal>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static float Positive(this IGuardClause guardClause, float input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return Positive<float>(guardClause, input, message, exceptionCreator, parameterName);
    }

    private static T Positive<T>(this IGuardClause guardClause, T input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null) where T : struct, IComparable
    {
        if (input.CompareTo(default(T)) > 0)
        {
            Exception? exception = exceptionCreator?.Invoke();
            throw exception ?? new ArgumentException(message ?? $"Required input {parameterName} cannot be positive.", parameterName!);
        }

        return input;
    }
}