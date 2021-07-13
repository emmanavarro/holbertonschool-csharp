using System;

class Program
{
	static void Main(string[] args)
	{
		for (int num1 = 0; num1 <= 8; num1++)
		{
			for (int num2 = num1 + 1; num2 <= 9; num2++)
			{
				if (num1 == 8 && num2 == 9)
				{
					Console.Write("{0}{1}\n", num1, num2);
				}
				else
				{
					Console.Write("{0}{1}, ", num1, num2);
				}
			}
		}
	}
}
