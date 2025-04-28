namespace MiF.Guard.UnitTests;

public class GuardAgainstNegativeOrZeroTests
{
    [Fact]
    public void WithPositiveValue_ShouldNot_ThrowException()
    {
        int intData = Guard.Against.NegativeOrZero(42);
        double doubleData = Guard.Against.NegativeOrZero(42.0);
        float floatData = Guard.Against.NegativeOrZero(42.0f);
        decimal decimalData = Guard.Against.NegativeOrZero(42.0M);
        long longData = Guard.Against.NegativeOrZero(42L);

        Assert.Equal(42, intData);
        Assert.Equal(42, doubleData);
        Assert.Equal(42, floatData);
        Assert.Equal(42, decimalData);
        Assert.Equal(42, longData);
    }

    [Fact]
    public void WithZeroValue_Should_ThrowException()
    {
        Assert.Throws<ArgumentException>(() => Guard.Against.NegativeOrZero(0));
        Assert.Throws<ArgumentException>(() => Guard.Against.NegativeOrZero(0.0));
        Assert.Throws<ArgumentException>(() => Guard.Against.NegativeOrZero(0.0f));
        Assert.Throws<ArgumentException>(() => Guard.Against.NegativeOrZero(0.0M));
        Assert.Throws<ArgumentException>(() => Guard.Against.NegativeOrZero(0L));
    }

    [Fact]
    public void WithNegativeValue_Should_ThrowException()
    {
        Assert.Throws<ArgumentException>(() => Guard.Against.NegativeOrZero(-1));
        Assert.Throws<ArgumentException>(() => Guard.Against.NegativeOrZero(-1.0));
        Assert.Throws<ArgumentException>(() => Guard.Against.NegativeOrZero(-1.0f));
        Assert.Throws<ArgumentException>(() => Guard.Against.NegativeOrZero(-1.0M));
        Assert.Throws<ArgumentException>(() => Guard.Against.NegativeOrZero(-1L));
    }
}
