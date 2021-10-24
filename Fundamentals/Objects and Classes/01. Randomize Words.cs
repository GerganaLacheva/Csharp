using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Randomize_Words_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random randomized = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int position = randomized.Next(words.Length);   //Next връща число от Random-генератор
                string word = words[i];                         //разменяме местата
                words[i] = words[position];                     //разменяме местата
                words[position] = word;                         //разменяме местата
            }
            Console.Write(string.Join('\n',words));
        }
    }
}
//1.Randomize Words
//You will be given a string that will contain words separated by a single space. Randomize their order and print each word on a new line.
//Examples
//Input   Output Comments
//Welcome to SoftUni and have fun learning programming	learning
//Welcome
//SoftUni
//and
//fun
//programming
//have
//to	The order of the words in the output will be different after each program execution.
