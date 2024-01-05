using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            
            
                int a = numberOfPeople / elevatorCapacity;
                int peopleLeft = numberOfPeople % elevatorCapacity;

            

            if (peopleLeft != 0)
            {
                Console.WriteLine(a + 1);
            }
            else
            {
                Console.WriteLine(a);
            }

           

        }
    }
}
