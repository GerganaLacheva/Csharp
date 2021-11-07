using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01.Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (!occurrences.ContainsKey(letter))
                    {
                        occurrences.Add(letter,0);
                    }
                    occurrences[letter]++;
                }
            }
            foreach (var characters in occurrences)
            {
                char currChar = characters.Key;
                int currValue = characters.Value;
                Console.WriteLine($"{currChar} -> {currValue}");
            }
        }
    }
}
//1.Count Chars in a String
//Create a program that counts all characters in a string except for space (' '). 
//Print all the occurrences in the following format:
//"{char} -> {occurrences}"
//Examples
//Input	
//text
//Output
//t -> 2
//e -> 1
//x -> 1

//Input
//text text text
//Output
//t -> 6
//e -> 3
//x -> 3
