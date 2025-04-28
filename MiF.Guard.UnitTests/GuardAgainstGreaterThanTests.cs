namespace MiF.Guard.UnitTests;

public class GuardAgainstGreaterThanTests
{
    [Fact]
    public void WithLessValue_ShouldNot_ThrowException()
    {
        int intData = Guard.Against.GreaterThan(42, 64);
        double doubleData = Guard.Against.GreaterThan(42.0, 64);
        float floatData = Guard.Against.GreaterThan(42.0f, 64);
        decimal decimalData = Guard.Against.GreaterThan(42.0M, 64);
        long longData = Guard.Against.GreaterThan(42L, 64);
        DateTime dateTimeData = Guard.Against.GreaterThan(new DateTime(1975,10,25), new DateTime(2025,1,1));

        Assert.Equal(42, intData);
        Assert.Equal(42, doubleData);
        Assert.Equal(42, floatData);
        Assert.Equal(42, decimalData);
        Assert.Equal(42, longData);
        Assert.Equal(new DateTime(1975, 10, 25), dateTimeData);
    }
    
    [Fact]
    public void WithGreaterValue_Should_ThrowException()
    {
        Assert.Throws<ArgumentException>(() => Guard.Against.GreaterThan(42, 20));
        Assert.Throws<ArgumentException>(() => Guard.Against.GreaterThan(42.0, 20));
        Assert.Throws<ArgumentException>(() => Guard.Against.GreaterThan(42.0f, 20));
        Assert.Throws<ArgumentException>(() => Guard.Against.GreaterThan(42.0M, 20));
        Assert.Throws<ArgumentException>(() => Guard.Against.GreaterThan(42L, 20));
        Assert.Throws<ArgumentException>(() => Guard.Against.GreaterThan(new DateTime(1975, 10, 25), new DateTime(1970, 1, 1)));
    }
}
