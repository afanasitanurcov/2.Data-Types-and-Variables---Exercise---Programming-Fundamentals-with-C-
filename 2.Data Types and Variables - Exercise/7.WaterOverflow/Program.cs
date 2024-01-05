using System;

namespace _7.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int litersOfWater = int.Parse(Console.ReadLine());
                
                sum += litersOfWater;
                if (sum > 255)
                {
                    sum -= litersOfWater;
                    Console.WriteLine($"Insufficient capacity!");

                }


            }
            Console.WriteLine(sum);
        }
    }
}
