using System;

class Array
{
	public static void Reverse(int[] array)
	{
		if (array != null)
		{
			for (int element = array.Length - 1; element >= 0; element--)
			{
				Console.Write(array[element]);
				if (element > 0)
				{
					Console.Write(" ");
				}
			}
		}
		Console.WriteLine();
	}
}
