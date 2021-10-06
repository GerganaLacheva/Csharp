using System;

namespace EX08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double num1Factoral = CalculateFactorial(num1);     
            double num2Factoral = CalculateFactorial(num2);

            double result = num1Factoral / num2Factoral;
            Console.WriteLine($"{result:f2}");
        }

        private static double CalculateFactorial(int num)
        {
            double factorial = 1;
            for (int i = 1; i <= num; i++)      //int i = 2 ->>dismiss the first iteration where 1*1=1
            {
                factorial *= i;
            }
                return factorial;
        }
    }
}
//8.Factorial Division
//Read two integers. Calculate factorial of each number. Divide the first result by the second and print the result of the division formatted to the second decimal point.
//Examples
//Input	Output		
//5
//2	    60.00		

