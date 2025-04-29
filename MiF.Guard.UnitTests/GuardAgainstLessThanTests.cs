namespace MiF.Guard.UnitTests;

public class GuardAgainstLessThanTests
{
    [Fact]
    public void WithGreaterValue_ShouldNot_ThrowException()
    {
        int intData = Guard.Against.LessThan(42, 20);
        double doubleData = Guard.Against.LessThan(42.0, 20);
        float floatData = Guard.Against.LessThan(42.0f, 20);
        decimal decimalData = Guard.Against.LessThan(42.0M, 20);
        long longData = Guard.Against.LessThan(42L, 20);
        DateTime dateTimeData = Guard.Against.LessThan(new DateTime(2025, 1, 1), new DateTime(1975, 10, 25));

        Assert.Equal(42, intData);
        Assert.Equal(42, doubleData);
        Assert.Equal(42, floatData);
        Assert.Equal(42, decimalData);
        Assert.Equal(42, longData);
        Assert.Equal(new DateTime(2025, 1, 1), dateTimeData);
    }

    [Fact]
    public void WithLessValue_Should_ThrowException()
    {
        Assert.Throws<ArgumentException>(() => Guard.Against.LessThan(20, 42));
        Assert.Throws<ArgumentException>(() => Guard.Against.LessThan(20.0, 42));
        Assert.Throws<ArgumentException>(() => Guard.Against.LessThan(20.0f, 42));
        Assert.Throws<ArgumentException>(() => Guard.Against.LessThan(20.0M, 42));
        Assert.Throws<ArgumentException>(() => Guard.Against.LessThan(20L, 42));
        Assert.Throws<ArgumentException>(() => Guard.Against.LessThan(new DateTime(1970, 1, 1), new DateTime(1975, 10, 25)));
    }
}
