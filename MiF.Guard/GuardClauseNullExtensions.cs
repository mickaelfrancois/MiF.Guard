using MiF.Guard.Interfaces;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace MiF.Guard;

public static partial class GuardClauseExtensions
{
    public static T Null<T>(this IGuardClause guardClause, [NotNull][ValidatedNotNull] T? input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        if (input is null)
        {
            Exception? exception = exceptionCreator?.Invoke();

            if (string.IsNullOrEmpty(message))
                throw exception ?? new ArgumentNullException(parameterName);

            throw exception ?? new ArgumentNullException(parameterName, message);
        }

        return input;
    }

    public static T Null<T>(this IGuardClause guardClause, [NotNull][ValidatedNotNull] T? input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null) where T : struct
    {
        if (input is null)
        {
            Exception? exception = exceptionCreator?.Invoke();

            if (string.IsNullOrEmpty(message))
                throw exception ?? new ArgumentNullException(parameterName);

            throw exception ?? new ArgumentNullException(parameterName, message);
        }

        return input.Value;
    }


    public static string NullOrEmpty(this IGuardClause guardClause, [NotNull][ValidatedNotNull] string? input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        Guard.Against.Null(input, message, exceptionCreator, parameterName);

        if (input == string.Empty)
            throw exceptionCreator?.Invoke() ?? new ArgumentException(message ?? $"Required input {parameterName} was empty.", parameterName);

        return input;
    }


    public static string NullOrWhitespace(this IGuardClause guardClause, [NotNull][ValidatedNotNull] string? input, string? message = null, Func<Exception>? exceptionCreator = null, [CallerArgumentExpression(nameof(input))] string? parameterName = null)
    {
        Guard.Against.Null(input, message, exceptionCreator, parameterName);

        if (string.IsNullOrWhiteSpace(input))
            throw exceptionCreator?.Invoke() ?? new ArgumentException(message ?? $"Required input {parameterName} was empty.", parameterName);

        return input;
    }
}