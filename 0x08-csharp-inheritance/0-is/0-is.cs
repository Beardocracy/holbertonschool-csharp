using System;

/// <summary>
/// Contains the method IsOfTypeInt
/// </summary>
public class Obj
{
    /// <summary>
    /// Returns true if the obj passed is an int
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj.GetType() == typeof(int));
    }
}