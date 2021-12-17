using System;
using System.Linq;

namespace EX1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] matrix = new int[n];

            int sumRight = 0;
            int sumLeft = 0;
            int m = n;

            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                m = m - 1;
                for (int j = 0; j < n; j++)
                {
                    matrix[j] = arr[i];
                    if (i == j)
                    {
                        sumRight += arr[j];
                    }
                    if (j == m)
                    {
                        sumLeft += arr[j];
                    }

                }
            }
            Console.WriteLine(Math.Abs(sumRight-sumLeft));
        }
    }
}
//1.Diagonal Difference
//Create a program that finds the difference between the sums of the square matrix diagonals (absolute value).

//Input
//•	On the first line, you are given the integer N – the size of the square matrix
//•	The next N lines holds the values for every row – N numbers separated by a space
//Output
//•	Print the absolute difference between the sums of the primary and the secondary diagonal
//Examples
//Input		
//3
//11 2 4
//4 5 6
//10 8 -12	
//
//Output
//15	
//
//Comments
//Primary diagonal: sum = 11 + 5 + (-12) = 4
//Secondary diagonal: sum = 4 + 5 + 10 = 19
//Difference: | 4 - 19 | = 15

