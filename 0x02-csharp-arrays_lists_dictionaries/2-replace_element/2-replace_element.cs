using System;

class Array
{
	public static int[] ReplaceElement(int[] array, int index, int n)
	{
		// Returns the updated array
		// If index is out of range, print Index out of range and return the unchanged array
		if (index < 0 || index >= array.Length)
		{
			Console.WriteLine("Index out of range");
			return array;
		}
		array[index] = n;
		return array;
	}
}
