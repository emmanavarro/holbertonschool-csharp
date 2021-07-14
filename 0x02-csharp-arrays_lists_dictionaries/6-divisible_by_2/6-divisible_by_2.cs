using System;
using System.Collections.Generic;

class List
{
	public static List<bool> DivisibleBy2(List<int> myList)
	{
		List<bool> multiples = new List<bool> ();

		for (int item = 0; item < myList.Count; item++)
		{
			if (myList[item] % 2 == 0)
			{
				multiples.Add(true);
			}
			else
			{
				multiples.Add(false);
			}
		}
		return multiples;
	}
}
