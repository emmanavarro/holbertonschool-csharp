using System;

class Program
{
	static void Main(string[] args)
	{
		// Prints all numbers from 0 to 98 in decimal and in hexadecimal.
		for (int number = 0; number <= 98; number++)
		{
			Console.Write("{0} = 0x{0:x}\n", number);
		}
	}
}
