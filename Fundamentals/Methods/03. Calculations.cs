using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (calculation)
            {
                case "add": Add(num1, num2); break;
                case "multiply": Multiply(num1, num2); break;
                case "subtract": Subtract(num1, num2); break;
                case "divide": Divide(num1, num2); break;

            }

            static void Add(int num1, int num2)
            {
                Console.WriteLine(num1+num2);
            }
            static void Multiply(int num1, int num2)
            {
                Console.WriteLine(num1*num2);
            }
            static void Subtract(int num1, int num2)
            {

                Console.WriteLine(num1 - num2);
            }
            static void Divide(int num1, int num2)
            {

                Console.WriteLine(num1 / num2);
            }
        }
    }
}
//3.Calculations
//Create a program that receives a string on the first line (add, multiply, subtract, divide) and, on the next two lines, receives two numbers. Create four methods (for each calculation) and invoke the corresponding method depending on the command. The method should also print the result (needs to be void).
//Example
//Input	    Output
//subtract
//5   
//4	        1
//divide
//8
//4	        2
