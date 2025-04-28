using MiF.Guard.Interfaces;

namespace MiF.Guard;

public class Guard : IGuardClause
{
    public static IGuardClause Against { get; } = new Guard();
}
