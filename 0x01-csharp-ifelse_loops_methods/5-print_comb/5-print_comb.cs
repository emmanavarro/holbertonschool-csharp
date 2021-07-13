using System;

class Program
{
	static void Main(string[] args)
	{
		for (int number = 0; number <= 99; number++)
		{
			if (number != 99)
			{
				Console.Write("{0:D2}, ", number);
			}
			else
			{
				Console.Write("{0:D2}\n", number);
			}
		}
	}
}
