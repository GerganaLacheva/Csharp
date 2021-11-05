using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var number in input)
            {
                if (numbers.ContainsKey(number))
                {
                    numbers[number]++;
                }
                else
                {
                    numbers.Add(number, 1);
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
//1.Count Real Numbers
//Read a list of integers and print them in ascending order, along with their number of occurrences.
//Examples
//Input	    Output		
//8 2 2 8 2	2 -> 3
//            8 -> 2		

//1 5 1 3	    1 -> 2
//            3 -> 1
//            5 -> 1	

//-2 0 0 2	-2 -> 1
//            0 -> 2
//            2 -> 1
