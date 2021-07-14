using System;

class Array
{
	public static int elementAt(int[] array, int index)
	{
		// Returns the element at the given index
		// If index is out of range, print Index out of range and return -1
		if (index < 0 || index >= array.Length)
		{
			Console.WriteLine("Index out of range");
			return -1;
		}
		else
		{
			return array[index];
		}
	}
}
