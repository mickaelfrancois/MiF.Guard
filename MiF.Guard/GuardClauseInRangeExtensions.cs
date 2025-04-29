using MiF.Guard.Interfaces;
using System.Runtime.CompilerServices;

namespace MiF.Guard;

public static partial class GuardClauseInRangeExtensions
{
    public static int InRange(this IGuardClause guardClause, int input, int minValue, int maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return InRange<int>(guardClause, input, minValue, maxValue, message, exceptionCreator, parameterName);
    }

    public static double InRange(this IGuardClause guardClause, double input, double minValue, double maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return InRange<double>(guardClause, input, minValue, maxValue, message, exceptionCreator, parameterName);
    }

    public static decimal InRange(this IGuardClause guardClause, decimal input, decimal minValue, decimal maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return InRange<decimal>(guardClause, input, minValue, maxValue, message, exceptionCreator, parameterName);
    }

    public static float InRange(this IGuardClause guardClause, float input, float minValue, float maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return InRange<float>(guardClause, input, minValue, maxValue, message, exceptionCreator, parameterName);
    }

    public static long InRange(this IGuardClause guardClause, long input, long minValue, long maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return InRange<long>(guardClause, input, minValue, maxValue, message, exceptionCreator, parameterName);
    }

    public static DateTime InRange(this IGuardClause guardClause, DateTime input, DateTime minValue, DateTime maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return InRange<DateTime>(guardClause, input, minValue, maxValue, message, exceptionCreator, parameterName);
    }


    private static T InRange<T>(this IGuardClause guardClause, T input, T minValue, T maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null) where T : struct, IComparable
    {
        Guard.Against.Null(input, message, exceptionCreator, parameterName);

        if (input.CompareTo(minValue) <= 0 && input.CompareTo(maxValue) <= 0)
        {
            Exception? exception = exceptionCreator?.Invoke();
            throw exception ?? new ArgumentOutOfRangeException(message ?? $"Required input {parameterName} must be between {minValue} and {maxValue}.", parameterName!);
        }

        return input;
    }
}
