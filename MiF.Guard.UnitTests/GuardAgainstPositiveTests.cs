namespace MiF.Guard.UnitTests;

public class GuardAgainstPositiveTests
{
    [Fact]
    public void WithNegativeValue_ShouldNot_ThrowException()
    {
        int intData = Guard.Against.Positive(-42);
        double doubleData = Guard.Against.Positive(-42.0);
        float floatData = Guard.Against.Positive(-42.0f);
        decimal decimalData = Guard.Against.Positive(-42.0M);
        long longData = Guard.Against.Positive(-42L);

        Assert.Equal(-42, intData);
        Assert.Equal(-42, doubleData);
        Assert.Equal(-42, floatData);
        Assert.Equal(-42, decimalData);
        Assert.Equal(-42, longData);
    }

    [Fact]
    public void WithZeroValue_ShouldNot_ThrowException()
    {
        int intData = Guard.Against.Positive(0);
        double doubleData = Guard.Against.Positive(0.0);
        float floatData = Guard.Against.Positive(0.0f);
        decimal decimalData = Guard.Against.Positive(0.0M);
        long longData = Guard.Against.Positive(0L);

        Assert.Equal(0, intData);
        Assert.Equal(0, doubleData);
        Assert.Equal(0, floatData);
        Assert.Equal(0, decimalData);
        Assert.Equal(0, longData);
    }

    [Fact]
    public void WithPositiveValue_Should_ThrowException()
    {
        Assert.Throws<ArgumentException>(() => Guard.Against.Positive(1));
        Assert.Throws<ArgumentException>(() => Guard.Against.Positive(1.0));
        Assert.Throws<ArgumentException>(() => Guard.Against.Positive(1.0f));
        Assert.Throws<ArgumentException>(() => Guard.Against.Positive(1.0M));
        Assert.Throws<ArgumentException>(() => Guard.Against.Positive(1L));
    }
}
