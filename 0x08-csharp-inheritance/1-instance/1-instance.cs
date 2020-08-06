using System;

/// <summary>
/// Contains IsInstanceOfArray method
/// </summary>
public class Obj
{
    /// <summary>
    /// Returns true if the object is an instance of, or is an instance of a 
    /// class which inherits from Array.
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return (obj is Array);
    }
}