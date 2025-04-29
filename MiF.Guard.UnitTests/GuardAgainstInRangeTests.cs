namespace MiF.Guard.UnitTests;

public class GuardAgainstInRangeTests
{
    [Fact]
    public void WithOutOfRangeValue_ShouldNot_ThrowException()
    {
        int intData = Guard.Against.InRange(42, 50, 64);
        double doubleData = Guard.Against.InRange(42.0, 50, 64);
        float floatData = Guard.Against.InRange(42.0f, 50, 64);
        decimal decimalData = Guard.Against.InRange(42.0M, 50, 64);
        long longData = Guard.Against.InRange(42L, 50, 64);
        DateTime dateTimeData = Guard.Against.InRange(new DateTime(1975, 10, 25), new DateTime(1980, 1, 1), new DateTime(1990, 1, 1));

        Assert.Equal(42, intData);
        Assert.Equal(42, doubleData);
        Assert.Equal(42, floatData);
        Assert.Equal(42, decimalData);
        Assert.Equal(42, longData);
        Assert.Equal(new DateTime(1975, 10, 25), dateTimeData);
    }

    [Fact]
    public void WithInRangeValue_Should_ThrowException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.InRange(42, 0, 20));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.InRange(42.0, 0, 20));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.InRange(42.0f, 0, 20));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.InRange(42.0M, 0, 20));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.InRange(42L, 0, 20));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.InRange(new DateTime(1975, 10, 25), new DateTime(1970, 1, 1), new DateTime(1971, 1, 1)));
    }
}
