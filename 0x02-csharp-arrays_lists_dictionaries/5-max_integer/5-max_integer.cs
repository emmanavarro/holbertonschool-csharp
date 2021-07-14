using System;
using System.Collections.Generic;

class List
{
	public static int MaxInteger(List<int> myList)
	{
		// Returns the largest element in a given list
		// If list is empty, print List is empty and return -1
		// You are not allowed to use LINQ or .Max()
		if (myList.Count == 0)
		{
			Console.WriteLine("List is empty");
			return -1;
		}

		int max;
		myList.Sort();
		max = myList[myList.Count - 1];
		return max;
	}
}
