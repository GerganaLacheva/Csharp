using System;
using System.Linq;
using System.Text;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                var reversedInput = input.ToArray().Reverse();

                Console.WriteLine($"{input} = {string.Join("", reversedInput)}");

                input = Console.ReadLine();
            }
        }
    }
}
//1.Reverse Strings
//You will be given series of strings until you receive an "end" command. Write a program that reverses strings and prints each pair on separate line in format "{word} = {reversed word}".
//Examples
//Input	            Output
//helLo             helLo = oLleh
//Softuni           Softuni = inutfoS
//bottle            bottle = elttob
//end	            
