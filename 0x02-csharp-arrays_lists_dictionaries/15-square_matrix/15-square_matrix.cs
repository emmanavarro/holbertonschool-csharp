using System;

class Matrix
{
	public static int[,] Square(int[,] myMatrix)
	{
		int row, column;

		for (row = 0; row < myMatrix.GetLength(0); row++)
		{
			for (column = 0; column < myMatrix.GetLength(1); column++)
			{
				myMatrix[row, column] *= myMatrix[row, column];
			}
		}
		return myMatrix;
	}
}
