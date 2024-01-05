using System;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfLines = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = numberOfLines; i > 0; i--)
            {
              char Symbol = char.Parse(Console.ReadLine());
                sum += Symbol;
            }
            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}
