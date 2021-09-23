using System;
using System.Linq;

namespace EX08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == num)
                    {
                        Console.WriteLine(input[i] + " " + input[j]);
                    }
                }
            }
        }
    }
}
//8.Magic Sum
//Write a program, which prints all unique pairs in an array of integers whose sum is equal to a given number. 
//Examples
//Input	
//1 7 6 2 19 23
//8	
//Output
//1 7
//6 2

//Input
//14 20 60 13 7 19 8
//27	
//Output
//14 13
//20 7
//19 8
