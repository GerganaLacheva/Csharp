using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ReadArrFromConsole();                //3, 6 ->> rows [index 0], columns [index 1]

            int[,] matrix = new int[dimensions[0], dimensions[1]];  //initiate 2-dimensional array
                
            for (int row = 0; row < dimensions[0]; row++)           //fill the matrix with rows
            {
                int[] arr = ReadArrFromConsole();                   //read input values of the row
                for (int columns = 0; columns < dimensions[1]; columns++)       //fill the matrix columns
                {
                    matrix[row, columns] = arr[columns];                    //create the matrix
                }
            }
            Console.WriteLine(dimensions[0]);
            Console.WriteLine(dimensions[1]);

            int sum = 0;
            foreach (var item in matrix)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }

        private static int[] ReadArrFromConsole()
        {
            return Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
//1.Sum Matrix Elements
//Write program that reads a matrix from the console and print:
//•	Count of rows
//•	Count of columns
//•	Sum of all matrix elements
//On first line you will get matrix sizes in format [rows, columns]
//Examples
//Input	
//3, 6
//7, 1, 3, 3, 2, 1
//1, 3, 9, 8, 5, 6
//4, 6, 7, 9, 1, 0
//	
//Output	
//3
//6
//76
