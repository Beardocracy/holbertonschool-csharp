using System;
using System.Reflection;

/// <summary>
/// Contains the Print method
/// </summary>
class Obj
{
    /// <summary>
    /// Prints the names of available properties and methods of an object.
    /// </summary>
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();

        Console.WriteLine(type.Name + " Properties:");

        foreach (PropertyInfo prop in type.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }
        
        Console.WriteLine(type.Name + " Methods:");

        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}