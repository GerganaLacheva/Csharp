using System;
using System.Linq;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
//2.Print Numbers in Reverse Order
//Read n numbers and print them in reverse order, separated by a single space.
//Examples
//Input	Output
//3       30 20 10
//10
//20
//30	

//3       10 20 30
//30
//20
//10

//1
//10	10
