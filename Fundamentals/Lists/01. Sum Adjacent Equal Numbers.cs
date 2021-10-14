using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                double nextIndex = 0;
                if (i + 1 > numbers.Count - 1)
                {
                    break;
                }
                else
                {
                    nextIndex = i + 1;
                }
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
//1.Sum Adjacent Equal Numbers
//Create a program to sum all of the adjacent equal numbers in a list of decimal numbers, starting from left to right.
//•	After two numbers are summed, the result could be equal to some of its neighbors and should be summed as well (see the examples below)
//•	Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available)
//Examples
//Input	Output	Explanation
//3 3 6 1	12 1	3 3 6 1  6 6 1  12 1
