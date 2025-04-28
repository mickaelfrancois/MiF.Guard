using MiF.Guard.Interfaces;
using System.Runtime.CompilerServices;

namespace MiF.Guard;

public static partial class GuardClauseExtensions
{
    public static int NegativeOrZero(this IGuardClause guardClause, int input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return NegativeOrZero<int>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static long NegativeOrZero(this IGuardClause guardClause, long input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return NegativeOrZero<long>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static double NegativeOrZero(this IGuardClause guardClause, double input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return NegativeOrZero<double>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static decimal NegativeOrZero(this IGuardClause guardClause, decimal input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return NegativeOrZero<decimal>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static float NegativeOrZero(this IGuardClause guardClause, float input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return NegativeOrZero<float>(guardClause, input, message, exceptionCreator, parameterName);
    }

    private static T NegativeOrZero<T>(this IGuardClause guardClause, T input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null) where T : struct, IComparable
    {
        if (input.CompareTo(default(T)) <= 0)
        {
            Exception? exception = exceptionCreator?.Invoke();
            throw exception ?? new ArgumentException(message ?? $"Required input {parameterName} cannot be negative or zero.", parameterName!);
        }

        return input;
    }
}