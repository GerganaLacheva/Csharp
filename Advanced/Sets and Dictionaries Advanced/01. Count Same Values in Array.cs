using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
             .Split()
             .Select(double.Parse)
             .ToArray();

            Dictionary<double, int> occurancesCount = new Dictionary<double, int>();
            foreach (var item in numbers)
            {
                if (!occurancesCount.ContainsKey(item))
                {
                    occurancesCount.Add(item, 0);
                }
                occurancesCount[item]++;

            }

            foreach (var (key, value) in occurancesCount)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
//1.	Count Same Values in Array
//Write a program that counts in a given array of double values the number of occurrences of each value. 
//Examples
//Input	
//-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3

//Output
//-2.5 - 3 times
//4 - 2 times
//3 - 4 times
//-5.5 - 1 times

//Input	
//2 4 4 5 5 2 3 3 4 4 3 3 4 3 5 3 2 5 4 3

//Output
//2 - 3 times
//4 - 6 times
//5 - 4 times
//3 - 7 times
