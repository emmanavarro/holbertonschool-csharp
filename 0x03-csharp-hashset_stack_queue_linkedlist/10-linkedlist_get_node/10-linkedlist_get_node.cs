using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int counter = 0;

        foreach (int node in myLList)
        {
            if (counter == n)
                return node;
            counter += 1;
        }
        return (0);
    }
}
