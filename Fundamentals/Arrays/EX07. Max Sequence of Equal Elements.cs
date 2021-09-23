using System;
using System.Linq;

namespace EX07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int biggestCounter = 0;
            int position = 0;
            string number = string.Empty;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    counter++;
                    if (counter > biggestCounter)
                    {
                        biggestCounter = counter;
                        position = i;
                        number = input[i].ToString();
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = 0; i <= biggestCounter; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}
//7.Max Sequence of Equal Elements
//Write a program that finds the longest sequence of equal elements in an array of integers. If several longest sequences exist, print the leftmost one.
//Examples
//Input	                Output
//2 1 1 2 3 3 2 2 2 1	    2 2 2
//1 1 1 2 3 1 3 3	        1 1 1
//4 4 4 4	                4 4 4 4
//0 1 1 5 2 2 6 3 3	    1 1
