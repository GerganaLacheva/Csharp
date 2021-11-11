using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04.Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string cipher = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                letter += (char)3;
                cipher += letter;
            }
            Console.WriteLine(cipher);
        }
    }
}
//Caesar Cipher
//Create a program that returns an encrypted version of the same text. Encrypt the text by shifting each character with three positions forward. For example A would be replaced by D, B would become E, and so on. Print the encrypted text.
//Examples
//Input	                    Output
//Programming is cool!	    Surjudpplqj#lv#frro$
//One year has 365 days.	Rqh#|hdu#kdv#698#gd|v1
