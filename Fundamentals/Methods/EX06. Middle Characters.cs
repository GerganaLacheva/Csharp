using System;

namespace EX06._Middle_Characters.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string middle = FindMiddle(input);

            Console.WriteLine(middle);
        }

        private static string FindMiddle(string input)
        {
            if (input.Length%2==0)
            {
                return $"{input[input.Length / 2 - 1]}{input[input.Length / 2]}";
            }
            else
            {
                return $"{input[(input.Length - 1) / 2]}";
            }
        }
    }
}
//6.Middle Characters
//You will receive a single string. Create a method that prints the character found at its middle. If the length of the string is even there are two middle characters.
//Examples
//Input	    Output
//aString	    r
//someText	eT
//3245	    24
