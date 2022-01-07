using System;
using System.Collections.Generic;
using System.Linq;

namespace EX03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> periodicTable = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split().ToArray();

                foreach (var element in elements)
                {
                    periodicTable.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
//Problem 3.Periodic Table
//Create a program that keeps all the unique chemical elements. On the first line, you will be given a number n - the count of input lines that you are going to receive. On the next n lines, you will be receiving chemical compounds, separated by a single space. Your task is to print all the unique ones in ascending order:
//Examples
//Input	
//4
//Ce O
//Mo O Ce
//Ee
//Mo	
//
//Output
//Ce Ee Mo O
