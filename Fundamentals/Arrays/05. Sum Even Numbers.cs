using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentInput = arr[i];
                if (currentInput % 2 == 0)
                {
                    sum += currentInput;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
//5.Sum Even Numbers
//Read an array from the console and sum only its even values. 
//Examples
//Input	        Output
//1 2 3 4 5 6	    12
//3 5 7 9	        0
//2 4 6 8 10	    30

