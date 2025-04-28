namespace MiF.Guard.UnitTests;

public class GuardAgainstNegativeTests
{
    [Fact]
    public void WithPositiveValue_ShouldNot_ThrowException()
    {
        int intData = Guard.Against.Negative(42);
        double doubleData = Guard.Against.Negative(42.0);
        float floatData = Guard.Against.Negative(42.0f);
        decimal decimalData = Guard.Against.Negative(42.0M);
        long longData = Guard.Against.Negative(42L);

        Assert.Equal(42, intData);
        Assert.Equal(42, doubleData);
        Assert.Equal(42, floatData);
        Assert.Equal(42, decimalData);
        Assert.Equal(42, longData);
    }

    [Fact]
    public void WithZeroValue_ShouldNot_ThrowException()
    {
        int intData = Guard.Against.Negative(0);
        double doubleData = Guard.Against.Negative(0.0);
        float floatData = Guard.Against.Negative(0.0f);
        decimal decimalData = Guard.Against.Negative(0.0M);
        long longData = Guard.Against.Negative(0L);

        Assert.Equal(0, intData);
        Assert.Equal(0, doubleData);
        Assert.Equal(0, floatData);
        Assert.Equal(0, decimalData);
        Assert.Equal(0, longData);
    }

    [Fact]
    public void WithNegativeValue_Should_ThrowException()
    {
        Assert.Throws<ArgumentException>(() => Guard.Against.Negative(-1));
        Assert.Throws<ArgumentException>(() => Guard.Against.Negative(-1.0));
        Assert.Throws<ArgumentException>(() => Guard.Against.Negative(-1.0f));
        Assert.Throws<ArgumentException>(() => Guard.Against.Negative(-1.0M));
        Assert.Throws<ArgumentException>(() => Guard.Against.Negative(-1L));
    }
}
