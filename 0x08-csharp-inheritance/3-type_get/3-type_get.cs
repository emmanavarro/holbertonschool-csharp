using System;
using System.Reflection;

/// <summary>Obj class define a method to print object's information</summary>
class Obj
{
    /// <summary>
    /// Method that prints the names of the available properties and methods
    /// of an object.
    /// <param name="myObj">Object to print self properties and methods</param>
    /// <returns>void</returns>
    /// </summary>
    public static void Print(object myObj)
    {
        TypeInfo myInfo = myObj.GetType().GetTypeInfo();

        Console.WriteLine("{0} Properties:", myInfo.Name);
        foreach (PropertyInfo myProp in myInfo.GetProperties())
            Console.WriteLine("{0}", myProp.Name);

        Console.WriteLine("{0} Methods:", myInfo.Name);
        foreach (MethodInfo myMethod in myInfo.GetMethods())
            Console.WriteLine("{0}", myMethod.Name);
    }
}
