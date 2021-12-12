using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in words)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
//4.Text Filter
//Write a program that takes a text and a string of banned words. All words included in the ban list should be replaced with
//asterisks "*", equal to the word's length. The entries in the ban list will be separated by a comma and space ", ".
//The ban list should be entered on the first input line and the text on the second input line. 
//Examples
//Input	
//Linux, Windows
//It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by
//calling the OS GNU/Linux! Sincerely, a Windows client	
//
//Output
//It is not *****, it is GNU/*****. ***** is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by
//calling the OS GNU/*****! Sincerely, a ******* client
