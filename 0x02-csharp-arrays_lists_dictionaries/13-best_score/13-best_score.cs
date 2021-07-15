using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		if (myList.Count == 0)
			return "None";

		List<string> newList = new List<string> ();
		foreach (KeyValuePair<string, int> pair in myList.OrderBy(pair => pair.Value))
		{
			newList.Add(pair.Key);
		}
		return newList[newList.Count - 1];
	}
}
