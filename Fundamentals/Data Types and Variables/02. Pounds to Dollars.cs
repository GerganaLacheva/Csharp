using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double GBP = double.Parse(Console.ReadLine());
            double USD = 1.31;

            decimal fxConverter = (decimal)GBP * (decimal)USD;
            Console.WriteLine($"{fxConverter:f3}");
        }
    }
}
