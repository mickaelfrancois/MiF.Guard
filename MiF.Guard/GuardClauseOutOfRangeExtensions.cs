using MiF.Guard.Interfaces;
using System.Runtime.CompilerServices;

namespace MiF.Guard;

public static partial class GuardClauseOutOfRangeExtensions
{
    public static int OutOfRange(this IGuardClause guardClause, int input, int minValue, int maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return OutOfRange<int>(guardClause, input, minValue, maxValue, message, exceptionCreator, parameterName);
    }

    public static double OutOfRange(this IGuardClause guardClause, double input, double minValue, double maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return OutOfRange<double>(guardClause, input, minValue, maxValue, message, exceptionCreator, parameterName);
    }

    public static decimal OutOfRange(this IGuardClause guardClause, decimal input, decimal minValue, decimal maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return OutOfRange<decimal>(guardClause, input, minValue, maxValue, message, exceptionCreator, parameterName);
    }

    public static float OutOfRange(this IGuardClause guardClause, float input, float minValue, float maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return OutOfRange<float>(guardClause, input, minValue, maxValue, message, exceptionCreator, parameterName);
    }

    public static long OutOfRange(this IGuardClause guardClause, long input, long minValue, long maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return OutOfRange<long>(guardClause, input, minValue, maxValue, message, exceptionCreator, parameterName);
    }

    public static DateTime OutOfRange(this IGuardClause guardClause, DateTime input, DateTime minValue, DateTime maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return OutOfRange<DateTime>(guardClause, input, minValue, maxValue, message, exceptionCreator, parameterName);
    }


    private static T OutOfRange<T>(this IGuardClause guardClause, T input, T minValue, T maxValue, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null) where T : struct, IComparable
    {
        Guard.Against.Null(input, message, exceptionCreator, parameterName);

        if (input.CompareTo(minValue) < 0 || input.CompareTo(maxValue) > 0)
        {
            Exception? exception = exceptionCreator?.Invoke();
            throw exception ?? new ArgumentOutOfRangeException(message ?? $"Required input {parameterName} must be between {minValue} and {maxValue}.", parameterName!);
        }

        return input;
    }
}
