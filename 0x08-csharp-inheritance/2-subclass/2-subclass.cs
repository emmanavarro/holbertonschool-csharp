using System;

/// <summary> Obj class define a method to check its inheritance </summary>
class Obj
{
    /// <summary>
    /// Method to check if an object inherits from a specified class
    /// <param name="derivedType">derived class to check</param>
    /// <param name="baseType">base class to evaluate from</param>
    /// <returns>True if derivedType is a subclass of baseType, else False</returns>
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
