using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x >= 0)
                .Reverse()
                .ToList();



            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
//5.Remove Negatives and Reverse
//Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. If there are no elements left in the list, print "empty".
//Examples
//Input	                    Output
//10 -5 7 9 -33 50	        50 9 7 10
//7 -2 -10 1	            1 7
//-1 -2 -3	                empty
