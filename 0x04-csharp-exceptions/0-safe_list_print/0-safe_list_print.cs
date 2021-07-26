using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;

        while (count < n)
        {
            try
            {
                Console.WriteLine(myList[count]);
                count++;
            }
            catch (ArgumentOutOfRangeException)
            {
                break;
            }
        }
        return count;
    }
}
