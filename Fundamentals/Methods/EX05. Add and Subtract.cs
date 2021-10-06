using System;

namespace EX05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            int subtract = Subtract(sum, num3);
            Console.WriteLine(subtract);
        }

        private static int Subtract(int sum, int num3)
        {
            return sum - num3;
        }

        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
//5.Add and Subtract
//You will receive 3 integers. Create a method that returns the sum of the first two integers and another method that subtracts the third integer from the result of the sum method.
//Examples
//Input	Output
//23
//6
//10	    19
//1
//17
//30	    -12
//42 
//58
//100	    0
