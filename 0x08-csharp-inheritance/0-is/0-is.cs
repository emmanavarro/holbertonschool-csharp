using System;

/// <summary>
/// Obj class define an method to check type of object
/// </summary>
class Obj
{
    /// <summary>
    /// Method to check if an object is of int type
    /// <param name="obj">integer</param>
    /// <returns>True if obj is int, else False</returns>
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
