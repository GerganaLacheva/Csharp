using System;
using System.Linq;

namespace EX01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int min = FindMinNum(n1, n2, n3);
            Console.WriteLine(min);
        }
        private static int FindMinNum(int n1, int n2, int n3)
        {
            int min = Math.Min(Math.Min(n1, n2),n3);
            return min;
        }
    }
}
//1.Smallest of Three Numbers
//Create a method that prints out the smallest of three integer numbers.
//Examples
//Input	Output
//2
//5
//3	    2
//600
//342
//123	123
//25
//21
//4	    4
