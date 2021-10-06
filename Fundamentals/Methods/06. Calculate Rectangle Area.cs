using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = int.Parse(Console.ReadLine());
            double length = int.Parse(Console.ReadLine());

            double rectangleArea = CalculateArea(width, length);
            Console.WriteLine(rectangleArea);
        }

        private static double CalculateArea(double width, double length)
        {
            return width * length;
        }
    }
}
//6.Calculate Rectangle Area
//Create a method that calculates and returns the area of a rectangle by its side width and length.
//Examples

//Input	Output
//3
//4	    12
