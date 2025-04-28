namespace MiF.Guard.UnitTests;

public class GuardAgainstNullTests
{
    [Theory]
    [InlineData("")]
    [InlineData(1)]
    [InlineData(true)]
    public void WithNonNullValue_ShouldNot_ThrowException(object data)
    {
        object returnData = Guard.Against.Null(data);

        Assert.Equal(data, returnData);
    }

    [Fact]
    public void WithNullValue_Should_ThrowException()
    {
        object data = null!;
        Assert.Throws<ArgumentNullException>(() => Guard.Against.Null(data));
    }

    [Fact]
    public void WithNotEmptyValue_Should_ReturnInputValue()
    {
        string data = "notEmpty";
        string returnData = Guard.Against.NullOrEmpty(data);

        Assert.Equal(data, returnData);
    }

    [Fact]
    public void WithEmptyValue_Should_ThrowException()
    {
        Assert.Throws<ArgumentException>(() => Guard.Against.NullOrEmpty(""));
    }

    [Fact]
    public void WithNotWhitespaceValue_Should_ReturnInputValue()
    {
        string data = "notEmpty";
        string returnData = Guard.Against.NullOrWhitespace(data);

        Assert.Equal(data, returnData);
    }

    [Fact]
    public void WithWhitespaceValue_Should_ThrowException()
    {
        Assert.Throws<ArgumentException>(() => Guard.Against.NullOrWhitespace("  "));
    }
}
