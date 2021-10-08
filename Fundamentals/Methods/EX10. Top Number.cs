using System;

namespace EX10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (isTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool isTopNumber(int number)
        {
            return isDivisibleBy(number, 8) && ContainsOddDigit(number);
        }

        private static bool ContainsOddDigit(int number)
        {
            while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        private static bool isDivisibleBy(int number, int divider)
        {
            int sum = 0;
            while (number != 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }
            return sum % divider == 0;          //дали можем да разделим сумата на делителя без остатък
        }
    }
}
//10.Top Number
//A top number is an integer that holds the following properties:
//•	Its sum of digits is divisible by 8, e.g. 8, 17, 88
//•	Holds at least one odd digit, e.g. 232, 707, 87578
//•	Some examples of top numbers are: 17, 161, 251, 4310, 123200
//Create a program to print all top numbers in range [1…n].
//You will receive a single integer from the console, representing the end value. Examples
//Input	    Output		
//50	      17
//            35		
//100	      17
//            35
//            53
//            71
//            79
//            97
