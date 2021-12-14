using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];

            int[] sum = new int[dimensions[1]];

            for (int i = 0; i < dimensions[0]; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < dimensions[1]; j++)
                {
                    matrix[i, j] = arr[j];
                    sum[j]+=arr[j];
                }
            }
            foreach (var item in sum)
            {
                Console.WriteLine(item);
            }
        }
    }
}
//2.Sum Matrix Columns
//Create a program that read a matrix from console and print the sum for each column. On first line you will get matrix rows. On the next rows lines, you will get elements for each column separated with a space. 
//Examples
//Input	
//3, 6
//7 1 3 3 2 1
//1 3 9 8 5 6
//4 6 7 9 1 0	
//
//Output
//12
//10
//19
//20
//8
//7
//
//Input
//3, 3
//1 2 3
//4 5 6
//7 8 9	
//
//Output
//12
//15
//18

