using System;

namespace EX03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(numberOfPeople / elevatorCapacity));
        }
    }
}
