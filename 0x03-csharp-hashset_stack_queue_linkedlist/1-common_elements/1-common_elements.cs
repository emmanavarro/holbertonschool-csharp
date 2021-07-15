using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> numbers1 = new HashSet<int>(list1);
        HashSet<int> numbers2 = new HashSet<int>(list2);

        List<int> sum = new List<int>();

        numbers1.IntersectWith(numbers2);

        foreach (int number in numbers1)
        {
            sum.Add(number);
        }
        return sum;
    }
}
