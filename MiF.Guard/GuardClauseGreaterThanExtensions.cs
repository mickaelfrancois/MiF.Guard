using MiF.Guard.Interfaces;
using System.Runtime.CompilerServices;

namespace MiF.Guard;

public static partial class GuardClauseExtensions
{
    public static int GreaterThan(this IGuardClause guardClause, int input, int greaterThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return GreaterThan<int>(guardClause, input, greaterThanValue, message, exceptionCreator, parameterName);
    }

    public static long GreaterThan(this IGuardClause guardClause, long input, long greaterThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return GreaterThan<long>(guardClause, input, greaterThanValue, message, exceptionCreator, parameterName);
    }

    public static double GreaterThan(this IGuardClause guardClause, double input, double greaterThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return GreaterThan<double>(guardClause, input, greaterThanValue, message, exceptionCreator, parameterName);
    }

    public static decimal GreaterThan(this IGuardClause guardClause, decimal input, decimal greaterThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return GreaterThan<decimal>(guardClause, input, greaterThanValue, message, exceptionCreator, parameterName);
    }

    public static float GreaterThan(this IGuardClause guardClause, float input, float greaterThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return GreaterThan<float>(guardClause, input, greaterThanValue, message, exceptionCreator, parameterName);
    }

    public static DateTime GreaterThan(this IGuardClause guardClause, DateTime input, DateTime greaterThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return GreaterThan<DateTime>(guardClause, input, greaterThanValue, message, exceptionCreator, parameterName);
    }

    private static T GreaterThan<T>(this IGuardClause guardClause, T input, T greaterThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null) where T : struct, IComparable
    {
        Guard.Against.Null(input, message, exceptionCreator, parameterName);

        if (input.CompareTo(greaterThanValue) > 0)
        {
            Exception? exception = exceptionCreator?.Invoke();
            throw exception ?? new ArgumentException(message ?? $"Required input {parameterName} cannot be greater than {greaterThanValue}.", parameterName!);
        }

        return input;
    }
}