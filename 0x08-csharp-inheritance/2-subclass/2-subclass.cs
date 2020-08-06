using System;

/// <summary>
/// Contains IsOnlyASubclass method.
/// </summary>
public class Obj
{
    /// <summary>
    ///  Returns True if the object is an instance of a class that inherits from the specified class, 
    ///  otherwise return False. The object must be a subclass.
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType != baseType && baseType.IsAssignableFrom(derivedType));
    }
}