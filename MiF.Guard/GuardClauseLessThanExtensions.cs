using MiF.Guard.Interfaces;
using System.Runtime.CompilerServices;

namespace MiF.Guard;

public static partial class GuardClauseExtensions
{
    public static int LessThan(this IGuardClause guardClause, int input, int lessThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return LessThan<int>(guardClause, input, lessThanValue, message, exceptionCreator, parameterName);
    }

    public static long LessThan(this IGuardClause guardClause, long input, long lessThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return LessThan<long>(guardClause, input, lessThanValue, message, exceptionCreator, parameterName);
    }

    public static double LessThan(this IGuardClause guardClause, double input, double lessThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return LessThan<double>(guardClause, input, lessThanValue, message, exceptionCreator, parameterName);
    }

    public static decimal LessThan(this IGuardClause guardClause, decimal input, decimal lessThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return LessThan<decimal>(guardClause, input, lessThanValue, message, exceptionCreator, parameterName);
    }

    public static float LessThan(this IGuardClause guardClause, float input, float lessThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return LessThan<float>(guardClause, input, lessThanValue, message, exceptionCreator, parameterName);
    }

    public static DateTime LessThan(this IGuardClause guardClause, DateTime input, DateTime lessThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return LessThan<DateTime>(guardClause, input, lessThanValue, message, exceptionCreator, parameterName);
    }

    private static T LessThan<T>(this IGuardClause guardClause, T input, T lessThanValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null) where T : struct, IComparable
    {
        Guard.Against.Null(input, message, exceptionCreator, parameterName);

        if (input.CompareTo(lessThanValue) < 0)
        {
            Exception? exception = exceptionCreator?.Invoke();
            throw exception ?? new ArgumentException(message ?? $"Required input {parameterName} cannot be less than {lessThanValue}.", parameterName!);
        }

        return input;
    }
}