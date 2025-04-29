namespace MiF.Guard.UnitTests;

public class GuardAgainstOutOfRangeTests
{
    [Fact]
    public void WithInRageValue_ShouldNot_ThrowException()
    {
        int intData = Guard.Against.OutOfRange(42, 0, 64);
        double doubleData = Guard.Against.OutOfRange(42.0, 0, 64);
        float floatData = Guard.Against.OutOfRange(42.0f, 0, 64);
        decimal decimalData = Guard.Against.OutOfRange(42.0M, 0, 64);
        long longData = Guard.Against.OutOfRange(42L, 0, 64);
        DateTime dateTimeData = Guard.Against.OutOfRange(new DateTime(1975, 10, 25), new DateTime(1970, 1, 1), new DateTime(1980, 1, 1));

        Assert.Equal(42, intData);
        Assert.Equal(42, doubleData);
        Assert.Equal(42, floatData);
        Assert.Equal(42, decimalData);
        Assert.Equal(42, longData);
        Assert.Equal(new DateTime(1975, 10, 25), dateTimeData);
    }

    [Fact]
    public void WithOutOfRangeValue_Should_ThrowException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange(42, 0, 20));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange(42.0, 0, 20));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange(42.0f, 0, 20));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange(42.0M, 0, 20));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange(42L, 0, 20));
        Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Against.OutOfRange(new DateTime(1975, 10, 25), new DateTime(1970, 1, 1), new DateTime(1971, 1, 1)));
    }
}
