using System;

class Array
{
	public static int[] CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}

		int[] array = new int[size];

		if (size > 0)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = i;
				Console.Write(i);
				if (i < array.Length - 1)
				{
					Console.Write(" ");
				}
				else
				{
					Console.WriteLine();
				}
			}
		}
		else if (size == 0)
		{
			Console.WriteLine();
		}
		return array;
	}
}
