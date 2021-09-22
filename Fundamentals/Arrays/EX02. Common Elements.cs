using System;
using System.Linq;

namespace EX02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(" ");
            string[] arr2 = Console.ReadLine().Split(" ");

            string[] intersection = arr2.Intersect(arr1).ToArray();
            Console.WriteLine(string.Join(" ", intersection));
        }
    }
}
//2.Common Elements
//Write a program, which prints common elements in two arrays. You have to compare the elements of the second array to the elements of the first.
//Examples
//Input	
//Hey hello 2 4

//Output
//10 hey 4 hello	4 hello
