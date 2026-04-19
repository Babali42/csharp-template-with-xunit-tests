using Production;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void ShouldSayHello()
    {
        Assert.Equal("Hello", new MyClass().SayHello());
    }
}