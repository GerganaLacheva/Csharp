using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] firstLength = new int[originalArray.Length - 1];

            int finalResult = 0;

            if (originalArray.Length == 1)
            {
                Console.WriteLine(originalArray[0]);
            }
            else
            {
                for (int i = 0; i < firstLength.Length; i++)
                {

                    int[] condensed = new int[originalArray.Length - 1];
                    for (int j = 0; j < condensed.Length; j++)
                    {
                        condensed[j] = originalArray[j] + originalArray[j + 1];
                    }
                    originalArray = condensed;
                    finalResult = condensed[0];
                }
                Console.WriteLine(finalResult);
            }
        }
    }
}
//8.Condense Array to Number
//Create a program to read an array of integers and condense them by summing all adjacent couples of elements until a single integer remains.
//For example, let us say we have 3 elements - {2, 10, 3}. We sum the first two and the second two elements and get {2+10, 10+3} = { 12, 13}, then we sum all adjacent elements again. This results in {12+13} = { 25}.
//Examples
//Input	Output	Comments
//2 10 3	25	2 10 3  2+10 10+3  12 13  12 + 13  25
//5 0 4 1 2	35	5 0 4 1 2  5+0 0+4 4+1 1+2  5 4 5 3  5+4 4+5 5+3  9 9 8  9+9 9+8  18 17  18+17  35
//1	1	1 is already condensed to number
