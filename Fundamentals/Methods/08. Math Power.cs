using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            double result = CalculateMathPower(input, pow);
            Console.WriteLine(result);
        }

        private static double CalculateMathPower(double input, double pow)
        {
            return Math.Pow(input, pow);
        }
    }
}
//8.Math Power
//Create a method that calculates and returns the value of a number raised to a given power.
//Examples
//Input	Output
//2
//8	    256
