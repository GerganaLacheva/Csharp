using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                 .Split();
            string str1 = input[0];
            string str2 = input[1];
            char[] char1 = input[0].ToCharArray();
            char[] char2 = input[1].ToCharArray();
            int total = 0;

            int minArr = Math.Min(input[0].Length, input[1].Length);
            for (int i = 0; i < minArr; i++)
            {
                int midTotal = char1[i] * char2[i];
                total += midTotal;
            }
            if (char1.Length > char2.Length)
            {
                for (int i = 0; i < char1.Length - minArr; i++)
                {
                    total += char1[i + minArr];
                }
            }
            else
            {
                for (int i = 0; i < str2.Length - minArr; i++)
                {
                    total += char2[i + minArr];
                }
            }

            Console.WriteLine(total);
        }
    }
}
//Character Multiplier
//Create a method that takes two strings as arguments and returns the sum of their character codes multiplied (multiply str1[0] with str2[0] and add to the total sum). Then continue with the next two characters. If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.
//Examples
//Input	        Output
//Peter George	52114
//123 522	        7647
//a aaaa	        9700
