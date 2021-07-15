using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> uniqueElem = new List<int>();

        foreach (int number in list1)
        {
            if (!list2.Contains(number))
                uniqueElem.Add(number);
        }

        foreach (int number in list2)
        {
            if (!list1.Contains(number))
                uniqueElem.Add(number);
        }

        uniqueElem.Sort();
        return uniqueElem;
    }
}
