using System;
using System.Linq;

namespace EX05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < inputArr.Length; i++)
            {
                bool isBigger = true;
                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] <= inputArr[j])
                    {
                        isBigger = false;
                    }
                }

                if (isBigger)
                {
                    Console.Write(inputArr[i] + " ");
                }
            }
        }
    }
}
//5.Top Integers
//Write a program to find all the top integers in an array. A top integer is an integer which is bigger than all the elements to its right. 
//Examples
//Input	
//1 4 3 2	
//Output
//4 3 2
