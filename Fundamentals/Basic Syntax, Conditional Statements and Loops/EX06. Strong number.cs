using System;

namespace EX06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int initialValue = input;
            int sumFactorial = 0;

            while (input > 0)
            {
                int currentNumber = input % 10;
                int factorial = 1;
                for (int i = 1; i <= currentNumber; i++)
                {
                    factorial *= i;
                }
                sumFactorial += factorial;
                input /= 10;
            }
            if (initialValue == sumFactorial)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
//Write a program that calculates if a given number is strong or not. A number is strong if the sum of the Factorial of each digit is equal to the number. 
//Example: 145 is a strong number, because 1! + 4! + 5! = 145.
//Print "yes" if the number is strong or "no" if the number is not strong.
//Examples
//Input   Output
//2         yes
//3451      no
//40585     yes
