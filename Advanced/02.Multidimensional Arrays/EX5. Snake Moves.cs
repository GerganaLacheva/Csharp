using System;
using System.Collections.Generic;
using System.Linq;

namespace EX5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string input = Console.ReadLine();

            char[,] matrix = new char[rows, cols];
            var queue = new Queue<char>(input);

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    PrintTheOddRows(cols, matrix, queue, row);
                }
                else
                {
                    PrintTheEvenRows(cols, matrix, queue, row);
                }
            }
        }

        private static void PrintTheEvenRows(int cols, char[,] matrix, Queue<char> queue, int row)
        {
            char[] currentRow = new char[cols];
            for (int col = cols - 1; col >= 0; col--)
            {
                matrix[row, col] = queue.Dequeue();
                queue.Enqueue(matrix[row, col]);
                currentRow[col] = matrix[row, col];
            }

            string result = new string(currentRow);
            Console.WriteLine(result);
        }

        private static void PrintTheOddRows(int cols, char[,] matrix, Queue<char> queue, int row)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = queue.Dequeue();
                queue.Enqueue(matrix[row, col]);
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
//5.Snake Moves
//You are walking in the park and you encounter a snake! You are terrified, and you start running zig-zag, so
//the snake starts following you. You have a task to visualize the snake’s path in a square form. A snake is
//represented by a string. The isle is a rectangular matrix of size NxM. A snake starts going down from the
//top-left corner and slithers its way down. The first cell is filled with the first symbol of the snake,
//the second cell is filled with the second symbol, etc. The snake is as long as it takes in order to fill
//the stairs completely – if you reach the end of the string representing the snake, start again at the beginning.
//After you fill the matrix with the snake’s path, you should print it.
//
//Input
//•	The input data should be read from the console. It consists of exactly two lines
//•	On the first line, you’ll receive the dimensions of the stairs in format: "N M", where N is the number of rows,
//and M is the number of columns. They’ll be separated by a single space
//•	On the second line you’ll receive the string representing the snake
//Output
//•	The output should be printed on the console. It should consist of N lines
//•	Each line should contain a string representing the respective row of the matrix
//Constraints
//•	The dimensions N and M of the matrix will be integers in the range [1 … 12]
//•	The snake will be a string with length in the range [1 … 20] and will not contain any whitespace characters
//
//Examples
//Input	
//5 6
//SoftUni	
//
//Output
//SoftUn
//UtfoSi
//niSoft
//foSinU
//tUniSo
