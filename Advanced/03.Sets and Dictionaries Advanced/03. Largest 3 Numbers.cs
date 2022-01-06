using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();
            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
//3.Largest 3 Numbers
//Read a list of integers and print the largest 3 of them. If there are less than 3, print all of them.
//Examples
//Input	            Output		
//10 30 15 20 50 5	50 30 20		
//Input	            Output
//20 30	            30 20
