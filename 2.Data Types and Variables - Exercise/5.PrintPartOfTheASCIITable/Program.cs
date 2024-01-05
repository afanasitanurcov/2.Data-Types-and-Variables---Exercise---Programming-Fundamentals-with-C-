using System;

namespace _5.PrintPartOfTheASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startRange = int.Parse(Console.ReadLine());
            int endRange = int.Parse(Console.ReadLine());

            for (int i = startRange; i <= endRange; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
