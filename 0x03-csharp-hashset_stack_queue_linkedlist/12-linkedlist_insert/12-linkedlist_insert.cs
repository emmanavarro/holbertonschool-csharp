using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        if (myLList.First == null || myLList.First.Value >= newNode.Value)
        {
            myLList.AddFirst(n);
            return newNode;
        }
        LinkedListNode<int> actualNode = myLList.First;
        while (actualNode.Next != null && actualNode.Next.Value < newNode.Value)
            actualNode = actualNode.Next;
        myLList.AddAfter(actualNode, newNode);
        return newNode;
    }
}
