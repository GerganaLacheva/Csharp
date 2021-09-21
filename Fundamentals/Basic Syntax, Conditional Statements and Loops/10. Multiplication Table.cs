using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n*i}");
            }
        }
    }
}
//Multiplication Table
//Create a program that receives an integer as an input. Print the 10 times table for this integer. See the examples below for more information.
//Output
//Print every row of the table in the following format:
//{ theInteger}
//X
//{ times} = { product}
//Constraints
//•	The integer will be in the interval [1…100]
//Examples
//Input	Output		
//5	    5 X 1 = 5
//      5 X 2 = 10
//      5 X 3 = 15
//      5 X 4 = 20
//      5 X 5 = 25
//      5 X 6 = 30
//      5 X 7 = 35
//      5 X 8 = 40
//      5 X 9 = 45
//      5 X 10 = 50		

