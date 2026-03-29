public class HelloEndpointTests
{
    [Fact]
    public void Message_ShouldNotBeEmpty()
    {
        var result = new { message = "Hello, World!", timestamp = DateTime.UtcNow };
        Assert.False(string.IsNullOrEmpty(result.message));
    }

    [Fact]
    public void Timestamp_ShouldBeRecentUtc()
    {
        var result = new { message = "Hello, World!", timestamp = DateTime.UtcNow };
        Assert.True(result.timestamp > DateTime.UtcNow.AddMinutes(-1));
    }

[Fact]
public void Message_ShouldNotBeEmptyFail()
{
    var result = new { message = "Hello, World!", timestamp = DateTime.UtcNow };
    Assert.Equal("This will never match", result.message);
}

}