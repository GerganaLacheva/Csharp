using System;
using System.Linq;

namespace EX03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());

            char smallerChar = input1;
            char biggerChar = input2;

            if (input2 < input1)
            {
                smallerChar = input2;
                biggerChar = input1;
            }
                PrintCharsRange(smallerChar, biggerChar);
        }

        private static void PrintCharsRange(char smallerChar, char biggerChar)
        {
            for (char i = (char)(smallerChar+1); i < biggerChar; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
//3.Characters in Range
//Create a method that receives two characters and prints all the characters between them according to ASCII (on a single line).
//NOTE: If the second letter's ASCII value is less than that of the first one then the two initial letters should be swapped.
//Examples
//Input	Output
//a
//d	    b c
//#
//:	    $ % &' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9
//C
//#	    $ % & ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9 : ; < = > ? @ A B
