using System;
using System.Collections.Generic;
using System.Linq;

namespace EX04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> appearances = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!appearances.ContainsKey(number))
                {
                    appearances.Add(number, 0);
                }
                appearances[number]++;
            }

            foreach (var (key, value) in appearances)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(key);
                    break;
                }
            }
            //appearances = appearances.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key, x => x.Value);

            //foreach (var kvp in appearances)
            //{
            //    Console.WriteLine(kvp.Key);
            //}
        }
    }
}
//Problem 4.Even Times
//Create a program that prints a number from a collection, which appears an even number of times in it. On the first line, you will be given n – the count of integers you will receive. On the next n lines, you will be receiving the numbers. It is guaranteed that only one of them appears an even number of times. Your task is to find that number and print it in the end. 
//Examples
//Input	
//3
//2
//-1
//2	
//
//Output
//2

