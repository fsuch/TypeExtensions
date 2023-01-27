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
    
    [Fact]
    public void Implements_ReturnsTrue_WhenTypeImplementsClass()
    {
        var type = typeof(InheritingSampleClassOne);
        Assert.True(type.Implements(typeof(SampleClassOne)));
    }
    
    [Fact]
    public void Implements_ReturnsFalse_WhenTypeDoesNotImplementClass()
    {
        var type = typeof(InheritingSampleClassOne);
        Assert.False(type.Implements(typeof(SampleClassTwo)));
    }
    
    [Fact]
    public void Implements_ReturnsTrue_WhenTypeImplementsGenericClassAndGenericArgumentsMatch()
    {
        var type = typeof(InheritingSampleGenericClassOne<string>);
        Assert.True(type.Implements(typeof(SampleGenericClassOne<string>)));
    }
    
    [Fact]
    public void Implements_ReturnsFalse_WhenTypeImplementsGenericClassButGenericArgumentsDoNotMatch()
    {
        var type = typeof(InheritingSampleGenericClassOne<string>);
        Assert.False(type.Implements(typeof(SampleGenericClassOne<int>)));
    }
    
    [Fact]
    public void Implements_ReturnsFalse_WhenTypeDoesNotImplementGenericClass()
    {
        var type = typeof(InheritingSampleGenericClassOne<string>);
        Assert.False(type.Implements(typeof(SampleGenericClassTwo<string>)));
    }

    [Fact]
    public void Implements_ReturnsTrue_WhenTypeImplementsOpenGenericClass()
    {
        var type = typeof(InheritingSampleGenericClassOne<string>);
        Assert.True(type.Implements(typeof(SampleGenericClassOne<>)));
    }
    
    [Fact]
    public void Implements_ReturnsFalse_WhenTypeDoesNotImplementOpenGenericClass()
    {
        var type = typeof(InheritingSampleGenericClassOne<string>);
        Assert.False(type.Implements(typeof(SampleGenericClassTwo<>)));
    }

    [Fact]
    public void Implements_ReturnsTrue_WhenOpenGenericTypeImplementsOpenGenericClass()
    {
        var type = typeof(InheritingSampleGenericClassOne<>);
        Assert.True(type.Implements(typeof(SampleGenericClassOne<>)));
    }
    
    [Fact]
    public void Implements_ReturnsFalse_WhenOpenGenericTypeImplementsClosedGenericClass()
    {
        var type = typeof(InheritingSampleGenericClassOne<>);
        Assert.False(type.Implements(typeof(SampleGenericClassOne<string>)));
    }
    
    [Fact]
    public void Implements_ReturnsFalse_WhenOpenGenericTypeDoesNotImplementOpenGenericClass()
    {
        var type = typeof(InheritingSampleGenericClassOne<>);
        Assert.False(type.Implements(typeof(SampleGenericClassTwo<>)));
    }
    
    [Fact]
    public void Implements_ReturnsTrue_WhenTypeImplementsInterfaceInBaseClass()
    {
        var type = typeof(DoubleInheritingSampleClassOne);
        Assert.True(type.Implements(typeof(ISampleInterfaceOne)));
    }
    
    [Fact]
    public void Implements_ReturnsTrue_WhenTypeImplementsClassInBaseClass()
    {
        var type = typeof(DoubleInheritingSampleClassOne);
        Assert.True(type.Implements(typeof(SampleClassOne)));
    }
    
    [Fact]
    public void Implements_ReturnsTrue_WhenTypeImplementsGenericInterfaceInBaseClass()
    {
        var type = typeof(DoubleInheritingSampleGenericClassOne<string>);
        Assert.True(type.Implements(typeof(ISampleGenericInterfaceOne<string>)));
    }
    
    [Fact]
    public void Implements_ReturnsTrue_WhenTypeImplementsGenericClassInBaseClass()
    {
        var type = typeof(DoubleInheritingSampleGenericClassOne<string>);
        Assert.True(type.Implements(typeof(SampleGenericClassOne<string>)));
    }
    
    [Fact]
    public void Implements_ReturnsTrue_WhenTypeImplementsOpenGenericInterfaceInBaseClass()
    {
        var type = typeof(DoubleInheritingSampleGenericClassOne<string>);
        Assert.True(type.Implements(typeof(ISampleGenericInterfaceOne<>)));
    }
    
    [Fact]
    public void Implements_ReturnsTrue_WhenTypeImplementsOpenGenericClassInBaseClass()
    {
        var type = typeof(DoubleInheritingSampleGenericClassOne<string>);
        Assert.True(type.Implements(typeof(SampleGenericClassOne<>)));
    }
    
    [Fact]
    public void Implements_ReturnsTrue_WhenOpenGenericTypeImplementsOpenGenericInterfaceInBaseClass()
    {
        var type = typeof(DoubleInheritingSampleGenericClassOne<>);
        Assert.True(type.Implements(typeof(ISampleGenericInterfaceOne<>)));
    }
    
    [Fact]
    public void Implements_ReturnsTrue_WhenOpenGenericTypeImplementsOpenGenericClassInBaseClass()
    {
        var type = typeof(DoubleInheritingSampleGenericClassOne<>);
        Assert.True(type.Implements(typeof(SampleGenericClassOne<>)));
    }
}
