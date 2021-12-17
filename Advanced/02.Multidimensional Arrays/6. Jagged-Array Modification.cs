using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                jagged[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split();
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 || row > n || col < 0 || col > jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine();
                    continue;
                }
                switch (tokens[0])
                {
                    case "Add": jagged[row][col] += value; break;

                    case "Subtract": jagged[row][col] -= value; break;
                        
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ",jagged[i]));
            }
        }
    }
}
//6.Jagged - Array Modification
//Create a program that reads a matrix from the console. On the first line you will get matrix rows. On next rows lines you will get elements for each column separated with space. You will be receiving commands in the following format:
//•	Add
//{ row}
//{ col}
//{ value} – Increase the number at the given coordinates with the value.
//•	Subtract {row} { col}
//{ value} – Decrease the number at the given coordinates by the value.
//Coordinates might be invalid. In this case you should print "Invalid coordinates". When you receive "END" you should print the matrix and stop the program.
//Examples
//Input	
//3
//1 2 3
//4 5 6
//7 8 9
//Add 0 0 5
//Subtract 1 1 2
//END
//
//Output
//6 2 3
//4 3 6
//7 8 9

//Input
//4
//1 2 3 4
//5 6 7 8
//8 7 6 5
//4 3 2 1
//Add 4 4 100
//Add 3 3 100
//Subtract -1 -1 42
//Subtract 0 0 42
//END	
//
//Output
//Invalid coordinates
//Invalid coordinates
//-41 2 3 4
//5 6 7 8
//8 7 6 5
//4 3 2 101
