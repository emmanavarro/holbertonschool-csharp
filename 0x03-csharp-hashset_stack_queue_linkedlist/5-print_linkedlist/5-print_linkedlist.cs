using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myLinkedList = new LinkedList<int>();

        for (int number = 0; number < size; number++)
        {
            myLinkedList.AddLast(number);
            Console.WriteLine(number);
        }
        return myLinkedList;
    }
}
