using System;
using System.Collections.Generic;

namespace EX05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();

            char[] chars = input.ToCharArray();

            foreach (var item in chars)
            {
                if (!charsCount.ContainsKey(item))
                {
                    charsCount.Add(item, 0);
                }
                charsCount[item]++;
            }
            foreach (var (item, count) in charsCount)
            {
                Console.WriteLine($"{item}: {count} time/s");
            }
        }
    }
}
//Problem 5.Count Symbols
//Create a program that reads some text from the console and counts the occurrences of each character in it. Print the results in alphabetical (lexicographical) order.
//Examples
//Input	
//SoftUni rocks	
//
//Output
//: 1 time / s
//S: 1 time / s
//U: 1 time / s
//c: 1 time / s
//f: 1 time / s
//i: 1 time / s
//k: 1 time / s
//n: 1 time / s
//o: 2 time / s
//r: 1 time / s
//s: 1 time / s
//t: 1 time / s
