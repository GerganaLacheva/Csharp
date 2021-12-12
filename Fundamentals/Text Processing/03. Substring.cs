using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textToRemove = Console.ReadLine();
            string originalText = Console.ReadLine();

            while (originalText.Contains(textToRemove))
            {
                int index = originalText.IndexOf(textToRemove);
                originalText = originalText.Remove(index, textToRemove.Length);
            }
            Console.WriteLine(originalText);
        }
    }
}
//3.Substring
//On the first line you will receive a string. On the second line you will receive a second string. Write a program that
//removes all of the occurrences of the first string in the second until there is no match. At the end print the remaining string.
//Examples
//Input	            Output	    Comment
//ice
//kicegiciceeb	    kgb	        We remove ice once and we get "kgiciceeb"
//                              We match "ice" one more time and we get "kgiceb"
//                              There is one more match. The finam result is "kgb"
