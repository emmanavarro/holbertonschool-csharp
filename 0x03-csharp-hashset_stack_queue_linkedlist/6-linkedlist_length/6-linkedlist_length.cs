using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int total = 0;

        foreach (int number in myLList)
            total += 1;

        return (total);
    }
}
