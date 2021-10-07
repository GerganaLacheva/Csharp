using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {

            int sumEven = 0;
            int sumOdd = 0;

            int result = GetMultipleOfEvenAndOdds(sumEven, sumOdd);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvenAndOdds(int sumEven, int sumOdd)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            while (number>0)
            {
                if (number%2==0)
                {
                    sumEven += number % 10;
                    number /= 10;
                }
                else
                {
                    sumOdd += number % 10;
                    number /= 10;
                }
            }
            
            return sumEven * sumOdd;
        }
    }
}
//10.Multiply Evens by Odds
//Create a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:
//•	Create a method called GetMultipleOfEvenAndOdds()
//•	Create a method GetSumOfEvenDigits()
//•	Create GetSumOfOddDigits()
//•	You may need to use Math.Abs() for negative numbers
//Examples
//Input       Output      Comment
//- 12345     54          Evens: 2 4
//                        Odds: 1 3 5
//                        Even sum: 6
//                        Odd sum: 9
//                        6 * 9 = 54
//3453466     220
