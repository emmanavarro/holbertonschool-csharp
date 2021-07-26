using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> divList = new List<int> ();

        for (int iterator = 0; iterator < listLength; iterator++)
        {
            try
            {
                divList.Add(list1[iterator] / list2[iterator]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                divList.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return divList;
    }
}
