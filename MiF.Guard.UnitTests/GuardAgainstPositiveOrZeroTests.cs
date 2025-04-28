namespace MiF.Guard.UnitTests;

public class GuardAgainstPositiveOrZeroTests
{
    [Fact]
    public void WithNegativeValue_ShouldNot_ThrowException()
    {
        int intData = Guard.Against.PositiveOrZero(-42);
        double doubleData = Guard.Against.PositiveOrZero(-42.0);
        float floatData = Guard.Against.PositiveOrZero(-42.0f);
        decimal decimalData = Guard.Against.PositiveOrZero(-42.0M);
        long longData = Guard.Against.PositiveOrZero(-42L);

        Assert.Equal(-42, intData);
        Assert.Equal(-42, doubleData);
        Assert.Equal(-42, floatData);
        Assert.Equal(-42, decimalData);
        Assert.Equal(-42, longData);
    }

    [Fact]
    public void WithZeroValue_Should_ThrowException()
    {
        Assert.Throws<ArgumentException>(() => Guard.Against.PositiveOrZero(0));
        Assert.Throws<ArgumentException>(() => Guard.Against.PositiveOrZero(0.0));
        Assert.Throws<ArgumentException>(() => Guard.Against.PositiveOrZero(0.0f));
        Assert.Throws<ArgumentException>(() => Guard.Against.PositiveOrZero(0.0M));
        Assert.Throws<ArgumentException>(() => Guard.Against.PositiveOrZero(0L));
    }

    [Fact]
    public void WithPositiveValue_Should_ThrowException()
    {
        Assert.Throws<ArgumentException>(() => Guard.Against.PositiveOrZero(1));
        Assert.Throws<ArgumentException>(() => Guard.Against.PositiveOrZero(1.0));
        Assert.Throws<ArgumentException>(() => Guard.Against.PositiveOrZero(1.0f));
        Assert.Throws<ArgumentException>(() => Guard.Against.PositiveOrZero(1.0M));
        Assert.Throws<ArgumentException>(() => Guard.Against.PositiveOrZero(1L));
    }
}
