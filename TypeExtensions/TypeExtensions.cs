namespace TypeExtensions;

public static class TypeExtensions
{
    public static bool Implements(this Type type, Type implementedType)
    {
        var typeInterfaces = type.GetInterfaces();
        var implementedTypeIsOpenGeneric = implementedType.IsGenericType &&
            !implementedType.GenericTypeArguments.Any();
        
        if (implementedTypeIsOpenGeneric)
        {
            typeInterfaces = typeInterfaces
                .Where(t => t.IsGenericType)
                .Select(t => t.GetGenericTypeDefinition())
                .ToArray();
        }
        
        return typeInterfaces.Any(typeInterface => typeInterface.IsAssignableTo(implementedType));
    }
}