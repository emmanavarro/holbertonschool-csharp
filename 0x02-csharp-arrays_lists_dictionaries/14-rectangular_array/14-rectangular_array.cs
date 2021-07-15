using System;

class twoDimensionArray
{
	static void Main(string[] args)
	{
		int width = 5;
		int height = 5;

		int[,] twoDArray = new int[width, height];
		twoDArray [2,2] = 1;

		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j++)
			{
				Console.Write("{0}", twoDArray[i, j]);
				if (j < height - 1)
					Console.Write(" ");
			}
			Console.WriteLine();
		}
	}
}
