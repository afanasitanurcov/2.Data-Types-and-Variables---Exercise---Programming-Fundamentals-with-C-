using System;

namespace _9.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYieldOfSpice = int.Parse(Console.ReadLine());

            int totalSpice = 0;

            int spicePerDay = 0;

            int countOfDays = 0;
            for (int i = startingYieldOfSpice; i >= 100; i -= 10)
            {
                spicePerDay = i - 26;

                totalSpice += spicePerDay;

                countOfDays++;
            }
            totalSpice -= 26;
            if (totalSpice < 0)
            {
                totalSpice = 0;
            }
            Console.WriteLine($"{countOfDays}");
            Console.WriteLine($"{totalSpice}");
        }
    }
}
