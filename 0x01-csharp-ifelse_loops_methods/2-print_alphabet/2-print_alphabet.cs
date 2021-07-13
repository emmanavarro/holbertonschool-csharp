// Program that prints the alphabet, in lowercase, not followed by a new line.
using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char alphabet = 'a'; alphabet < 'z'; alphabet++)
            {
                Console.Write(alphabet);
            }
        }
    }
}
