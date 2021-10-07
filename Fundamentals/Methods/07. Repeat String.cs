using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repetitionNumber = int.Parse(Console.ReadLine());

            string repeatedText = RepeatText(text,repetitionNumber);
            Console.WriteLine(repeatedText);
        }

        private static string RepeatText(string text, int repetitionNumber)
        {
            StringBuilder repeatedText = new StringBuilder();
            for (int i = 0; i < repetitionNumber; i++)
            {
                repeatedText.Append(text);
            }
            return repeatedText.ToString();
        }
    }
}
//7.Repeat String
//Create a method that receives a string and a repetition number n (integer). The method should return a new string, containing the initial one, repeated n times. 
//Example
//Input	Output
//abc
//3	    abcabcabc
