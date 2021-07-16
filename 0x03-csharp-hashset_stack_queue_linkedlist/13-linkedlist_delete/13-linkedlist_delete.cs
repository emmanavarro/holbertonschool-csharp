using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int counter = 0;
        LinkedListNode<int> actualNode = myLList.First;
        for (; counter <= index && actualNode.Next != null; counter++)
        {
            if (counter == index)
                myLList.Remove(actualNode);
            actualNode = actualNode.Next;
        }
        if (counter == index)
            myLList.Remove(actualNode);
    }
}
