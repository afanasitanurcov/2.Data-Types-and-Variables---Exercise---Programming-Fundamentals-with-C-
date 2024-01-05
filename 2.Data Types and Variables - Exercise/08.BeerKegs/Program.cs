using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfKegs = int.Parse(Console.ReadLine());
            double bigestKeg = 0;
            double kegsVolume = 0;
            string nameOfBigestKeg = "null";
            for (int i = 0; i < numberOfKegs; i++)
            {
                string kegsModel = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                kegsVolume = Math.PI * radius * radius * height;
                if (kegsVolume > bigestKeg)
                {
                    bigestKeg = kegsVolume;
                    nameOfBigestKeg = kegsModel;
                }

            }
            Console.WriteLine($"{nameOfBigestKeg}");
        }
    }
}
