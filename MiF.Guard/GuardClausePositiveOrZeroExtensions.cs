using MiF.Guard.Interfaces;
using System.Runtime.CompilerServices;

namespace MiF.Guard;

public static partial class GuardClauseExtensions
{
    public static int PositiveOrZero(this IGuardClause guardClause, int input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return PositiveOrZero<int>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static long PositiveOrZero(this IGuardClause guardClause, long input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return PositiveOrZero<long>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static double PositiveOrZero(this IGuardClause guardClause, double input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return PositiveOrZero<double>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static decimal PositiveOrZero(this IGuardClause guardClause, decimal input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return PositiveOrZero<decimal>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static float PositiveOrZero(this IGuardClause guardClause, float input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return PositiveOrZero<float>(guardClause, input, message, exceptionCreator, parameterName);
    }

    private static T PositiveOrZero<T>(this IGuardClause guardClause, T input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null) where T : struct, IComparable
    {
        if (input.CompareTo(default(T)) >= 0)
        {
            Exception? exception = exceptionCreator?.Invoke();
            throw exception ?? new ArgumentException(message ?? $"Required input {parameterName} cannot be positive or zero.", parameterName!);
        }

        return input;
    }
}