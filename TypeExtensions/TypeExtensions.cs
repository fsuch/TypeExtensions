namespace TypeExtensions;

public static class TypeExtensions
{
    public static bool Implements(this Type type, Type targetImplementedType)
    {
        var implementedTypes = type.GetInterfaces()
            .Concat(GetBaseTypes(type))
            .ToArray();
        
        var targetImplementedTypeIsOpenGeneric =
            targetImplementedType.IsGenericType &&
            !targetImplementedType.GenericTypeArguments.Any();
        
        if (targetImplementedTypeIsOpenGeneric)
        {
            implementedTypes = implementedTypes
                .Where(t => t.IsGenericType)
                .Select(t => t.GetGenericTypeDefinition())
                .ToArray();
        }
        
        return implementedTypes.Any(typeInterface => typeInterface.IsAssignableTo(targetImplementedType));
    }

    private static IEnumerable<Type> GetBaseTypes(Type type)
    {
        var baseType = type.BaseType;
        while (baseType != null)
        {
            yield return baseType;
            baseType = baseType.BaseType;
        }
    }
}