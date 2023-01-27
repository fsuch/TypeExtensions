namespace TypeExtensions.Tests;

public class TypeExtensionsTests
{
    [Fact]
    public void Implements_ReturnsTrue_WhenTypeImplementsInterface()
    {
        var type = typeof(SampleClassOne);
        Assert.True(type.Implements(typeof(ISampleInterfaceOne)));
    }
    
    [Fact]
    public void Implements_ReturnsFalse_WhenTypeDoesNotImplementInterface()
    {
        var type = typeof(SampleClassOne);
        Assert.False(type.Implements(typeof(ISampleInterfaceTwo)));
    }

    [Fact]
    public void Implements_ReturnsTrue_WhenTypeImplementsGenericInterfaceAndGenericArgumentsMatch()
    {
        var type = typeof(SampleGenericClassOne<string>);
        Assert.True(type.Implements(typeof(ISampleGenericInterfaceOne<string>)));
    }
    
    [Fact]
    public void Implements_ReturnsFalse_WhenTypeImplementsGenericInterfaceButGenericArgumentsDoNotMatch()
    {
        var type = typeof(SampleGenericClassOne<string>);
        Assert.False(type.Implements(typeof(ISampleGenericInterfaceOne<int>)));
    }
    
    [Fact]
    public void Implements_ReturnsFalse_WhenTypeDoesNotImplementGenericInterface()
    {
        var type = typeof(SampleGenericClassOne<string>);
        Assert.False(type.Implements(typeof(ISampleGenericInterfaceTwo<string>)));
    }
    
    [Fact]
    public void Implements_ReturnsTrue_WhenTypeImplementsOpenGenericInterface()
    {
        var type = typeof(SampleGenericClassOne<string>);
        Assert.True(type.Implements(typeof(ISampleGenericInterfaceOne<>)));
    }
    
    [Fact]
    public void Implements_ReturnsFalse_WhenTypeDoesNotImplementOpenGenericInterface()
    {
        var type = typeof(SampleGenericClassOne<string>);
        Assert.False(type.Implements(typeof(ISampleGenericInterfaceTwo<>)));
    }

    [Fact]
    public void Implements_ReturnsTrue_WhenOpenGenericTypeImplementsOpenGenericInterface()
    {
        var type = typeof(SampleGenericClassOne<>);
        Assert.True(type.Implements(typeof(ISampleGenericInterfaceOne<>)));
    }
    
    [Fact]
    public void Implements_ReturnsFalse_WhenOpenGenericTypeImplementsClosedGenericInterface()
    {
        var type = typeof(SampleGenericClassOne<>);
        Assert.False(type.Implements(typeof(ISampleGenericInterfaceOne<string>)));
    }
    
    [Fact]
    public void Implements_ReturnsFalse_WhenOpenGenericTypeDoesNotImplementOpenGenericInterface()
    {
        var type = typeof(SampleGenericClassOne<>);
        Assert.False(type.Implements(typeof(ISampleGenericInterfaceTwo<>)));
    }
}
