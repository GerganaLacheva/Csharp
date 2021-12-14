using System;
using System.Linq;

namespace _3._1_Secondary_Left__Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int m = n;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                m = m - 1;
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = arr[j];

                    if (j == m)
                    {
                        sum = sum + arr[j];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
//Create a program that finds the sum of matrix primary diagonal.
//•	On the first line, you are given the integer N – the size of the square matrix
//•	The next N lines holds the values for every row – N numbers separated by a space
//Examples
//Input	
//3
//11  2   4
//4   5   6
//10  8  -12	
//
//Output
//19
