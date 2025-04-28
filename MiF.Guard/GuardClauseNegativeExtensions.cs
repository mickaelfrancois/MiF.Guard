using MiF.Guard.Interfaces;
using System.Runtime.CompilerServices;

namespace MiF.Guard;

public static partial class GuardClauseExtensions
{
    public static int Negative(this IGuardClause guardClause, int input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return Negative<int>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static long Negative(this IGuardClause guardClause, long input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return Negative<long>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static double Negative(this IGuardClause guardClause, double input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return Negative<double>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static decimal Negative(this IGuardClause guardClause, decimal input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return Negative<decimal>(guardClause, input, message, exceptionCreator, parameterName);
    }

    public static float Negative(this IGuardClause guardClause, float input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        return Negative<float>(guardClause, input, message, exceptionCreator, parameterName);
    }

    private static T Negative<T>(this IGuardClause guardClause, T input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null) where T : struct, IComparable
    {
        if (input.CompareTo(default(T)) < 0)
        {
            Exception? exception = exceptionCreator?.Invoke();
            throw exception ?? new ArgumentException(message ?? $"Required input {parameterName} cannot be negative.", parameterName!);
        }

        return input;
    }
}