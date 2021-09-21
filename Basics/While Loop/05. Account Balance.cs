using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            //string command = Console.ReadLine();
            //double bankAccount = 0;

            //while (command!= "NoMoreMoney")
            //{
            //    double currentDeposit=double.Parse(command);

            //    if (currentDeposit<0)
            //    {
            //        Console.WriteLine($"Invalid operation!");
            //        break;
            //    }

            //    bankAccount += currentDeposit;
            //    Console.WriteLine($"Increase: {currentDeposit:f2}");
            //    command = Console.ReadLine();

            //}
            //Console.WriteLine($"Total: {bankAccount:f2}");


            string input = Console.ReadLine();
            double account = 0;

            while (input!= "NoMoreMoney")
            {
                double money = double.Parse(input);
                if (money<0)
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {money:f2}");
                account += money;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {account:f2}");


        }
    }
}
