using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums=Console.ReadLine().Split(", ").Select(int.Parse).Where(x=>x%2==0).OrderBy(x=>x).ToArray();
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
//1.Sort Even Numbers
//Create a program that reads one line of integers separated by ", ". Then prints the even numbers of that sequence sorted in increasing order.
//Examples
//Input							
//4, 2, 1, 3, 5, 7, 1, 4, 2, 12	
//Output
//2, 2, 4, 4, 12		
//
//Input
//1, 3, 5
//Output
//
//Input	
//2, 4, 6	
//Output
//2, 4, 6
