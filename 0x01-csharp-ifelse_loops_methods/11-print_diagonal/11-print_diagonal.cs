using System;

class Line
{
	public static void PrintDiagonal(int length)
	{
		if (length > 0)
		{
			for (int diagonal1 = 0; diagonal1 < length; diagonal1++)
			{
				for (int diagonal2 = 0; diagonal2 < diagonal1; diagonal2++)
				{
					Console.Write(" ");
				}
				Console.WriteLine(@"\");
			}
		}
		Console.WriteLine();
	}
}
