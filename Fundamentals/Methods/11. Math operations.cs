using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            char operatorSymbol = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double operation = DoMathOperations(num1, operatorSymbol, num2);
            Console.WriteLine(operation);
        }

        private static double DoMathOperations(double num1, char operatorSymbol, double num2)
        {
            double operation = 0;
            switch (operatorSymbol)
            {
                case '/': operation = num1 / num2; break;
                case '*': operation = num1 * num2;break;
                case '+': operation = num1 + num2;break;
                case '-': operation = num1 - num2;break;
            }
            return operation;
        }
    }
}
//11.Math Operations
//Write a method that receives two numbers and an operator, calculates the result and returns it. You will be given three lines of input. The first will be the first number, the second one will be the operator and the last one will be the second number.
//The possible operators are: /, *, +and -.
//Example
//Input	Output
//5
//*
//5	    25
//4
//+
//8	    12
