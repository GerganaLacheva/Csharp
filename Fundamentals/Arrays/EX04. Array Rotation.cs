using System;
using System.Linq;

namespace EX04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());


            for (int j = 0; j < rotation; j++)
            {
                int firstNum = input[0];
                for (int i = 0; i < input.Length - 1; i++)
                {
                    input[i] = input[i + 1];
                }

                input[input.Length - 1] = firstNum;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
//4.Array Rotation
//Write a program that receives an array and number of rotations you have to perform (first element goes at the end) Print the resulting array.
//Examples
//Input	
//51 47 32 61 21
//2	
//Output
//32 61 21 51 47
