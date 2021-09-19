using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sumIntNumber = 0;
            int sumDoubleNumbers = 0;

            while (command!= "stop")
            {
                int number = int.Parse(command);
                if (number<0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int count = 0;
                    for (int i = 1; i <= number; i++)
                    {
                        if (number%i==0)
                        {
                            count++;
                        }
                    }
                    if (count==2)
                    {
                        sumIntNumber += number;
                    }
                    else
                    {
                        sumDoubleNumbers += number;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumIntNumber}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumDoubleNumbers}");


        }
    }
}
