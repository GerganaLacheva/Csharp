using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                int number = i;
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}
//5.Special Numbers
//A number is special when its sum of digits is 5, 7, or 11.
//Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).
//Examples
//Input	Output
//7	1 -> False
//2 -> False
//3 -> False
//4 -> False
//5 -> True
//6 -> False
//7 -> True
