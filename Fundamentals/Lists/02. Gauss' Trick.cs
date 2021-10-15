using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < input.Count / 2; i++)
            {
                int sum = input[i] + input[input.Count - i - 1];
                Console.Write($"{sum} ");
            }
            if (input.Count%2==1)
            {
                Console.Write($"{input[input.Count/2]} ");
            }
        }
    }
}
//2.Gauss' Trick
//Create a program that sums all numbers in a list in the following order:
//first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.
//Example
//Input	        Output
//1 2 3 4 5	    6 6 3
//1 2 3 4	        5 5
