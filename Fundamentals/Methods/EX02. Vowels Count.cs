using System;

namespace EX02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vowelsCount = CountVowels(input);
            Console.WriteLine(vowelsCount);
        }

        private static int CountVowels(string input)
        {
            int counter = 0;
            input = input.ToLower();

            foreach (char letter in input)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    counter++;
                }
            };
            return counter;
        }
    }
}
//2.Vowels Count
//Create a method that receives a single string and prints out the number of vowels contained in it.
//Examples
//Input	Output
//SoftUni	3
//Cats	1
//JS	    0
