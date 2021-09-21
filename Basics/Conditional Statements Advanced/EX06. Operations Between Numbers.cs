using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();


            switch (symbol)
            {
                case "+":
                    if ((N1 + N2) % 2 == 0)
                    {
                        Console.WriteLine($"{N1} + {N2} = {N1 + N2} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} + {N2} = {N1 + N2} - odd");
                    }
                    break;
                case "-":
                    if ((N1 - N2) % 2 == 0)
                    {
                        Console.WriteLine($"{N1} - {N2} = {N1 - N2} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} - {N2} = {N1 - N2} - odd");
                    }
                    break;
                case "*":
                    if ((N1 * N2) % 2 == 0)
                    {
                        Console.WriteLine($"{N1} * {N2} = {N1 * N2} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} * {N2} = {N1 * N2} * odd");
                    }
                    break;
                case "/":
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} / {N2} = {(N1 / N2):f2}");
                    }
                    break;
                case "%":
                    if (N2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{N1} % {N2} = {N1 % N2}");
                    }
                    break;
            }
        }
    }
}
