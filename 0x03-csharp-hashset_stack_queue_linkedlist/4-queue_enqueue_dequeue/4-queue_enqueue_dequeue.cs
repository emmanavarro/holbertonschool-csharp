using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print the number of items in aQueue
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        // Print the item at the top of aQueue without removing it
        if (aQueue.Count > 0)
            Console.WriteLine("Top item: {0}", aQueue.Peek());
        else
            Console.WriteLine("Queue is empty");

        // Add a new given item newItem to aQueue
        aQueue.Enqueue(newItem);

        // Print if aQueue contains a given item search
        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search) ? "True" : "False");

        // If aQueue contains the given item search, remove all items up to and including search;
        // otherwise, leave aQueue as is
        if (aQueue.Contains(search))
            while (aQueue.Dequeue() != search);

        return aQueue;
    }
}
