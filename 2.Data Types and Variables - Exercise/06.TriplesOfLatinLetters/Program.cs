using System;

namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int rangeStart = 97;
            int endRange = 97 + number;
            for (int i = rangeStart; i < endRange; i++)
            {
                for (int j = rangeStart; j < endRange; j++)
                {
                    for (int k = rangeStart; k < endRange; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }

            }
            
        }
    }
}
