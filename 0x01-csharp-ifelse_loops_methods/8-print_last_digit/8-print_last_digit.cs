using System;

class Number
{
	public static int PrintLastDigit(int number)
	{
		int last = number % 10;
		Console.Write(Math.Abs(last));
		return Math.Abs(last);
	}
}
