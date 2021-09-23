using System;
using System.Linq;

namespace EX03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int num1 = input[0];
                int num2 = input[1];

                if (i % 2 == 0)
                {
                    arr1[i] = num1;
                    arr2[i] = num2;
                }
                else
                {
                    arr1[i] = num2;
                    arr2[i] = num1;
                }
            }
            Console.WriteLine(string.Join(" ",arr1));
            Console.WriteLine(string.Join(" ",arr2));
        }
    }
}
//3.Zig - Zag Arrays
//Write a program which creates 2 arrays. You will be given an integer n. On the next n lines you get 2 integers. Form 2 arrays as shown below.
//Examples
//Input	
//4
//1 5
//9 10
//31 81
//41 20

//Output
//1 10 31 20
//5 9 81 41
