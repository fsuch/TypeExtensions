// ReSharper disable UnusedTypeParameter
namespace TypeExtensions.Tests;

public interface ISampleInterfaceOne
{
        
}

public class SampleClassOne : ISampleInterfaceOne
{
    
}

public class InheritingSampleClassOne : SampleClassOne
{
    
}

public class DoubleInheritingSampleClassOne : InheritingSampleClassOne
{
    
}

public interface ISampleInterfaceTwo
{
    
}

public class SampleClassTwo : ISampleInterfaceTwo
{
    
}

public interface ISampleGenericInterfaceOne<T>
{
    
}

public class SampleGenericClassOne<T> : ISampleGenericInterfaceOne<T>
{
    
}

public class InheritingSampleGenericClassOne<T> : SampleGenericClassOne<T>
{
    
}

public class DoubleInheritingSampleGenericClassOne<T> : InheritingSampleGenericClassOne<T>
{
    
}

public interface ISampleGenericInterfaceTwo<T>
{
    
}

public class SampleGenericClassTwo<T> : ISampleGenericInterfaceTwo<T>
{
    
}