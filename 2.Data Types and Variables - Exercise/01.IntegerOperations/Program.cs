using System;

namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            int firstOperations = number1 + number2;

            int secondOperations = firstOperations / number3;

            int thirdOperations = secondOperations * number4;

            Console.WriteLine(thirdOperations);
        }
    }
}
