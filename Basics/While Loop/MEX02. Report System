using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tae02.Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double expectedRevenue = double.Parse(Console.ReadLine());
            string input = "";

            double totalPayments = 0;
            int paymentsCounter = 0;
            double cardPayment = 0;
            int cardPaymentCounter = 0;
            double cashPayment = 0;
            int cashPaymentCounter = 0;


            while (totalPayments < expectedRevenue)
            {
                input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine($"Failed to collect required money for charity.");
                    break;
                }

                    paymentsCounter ++;


                    if (paymentsCounter % 2 == 0)
                    {
                        if (int.Parse(input) < 10)
                        {
                            Console.WriteLine($"Error in transaction!");
                        }
                        else
                        {
                            totalPayments += double.Parse(input);
                            cardPayment += double.Parse(input);
                            cardPaymentCounter++;
                            Console.WriteLine($"Product sold!");
                        }
                    }
                    else
                    {
                        if (int.Parse(input) > 100)
                        {
                            Console.WriteLine($"Error in transaction!");
                        }
                        else
                        {
                            totalPayments += double.Parse(input);
                            cashPayment += double.Parse(input);
                            cashPaymentCounter++;
                            Console.WriteLine($"Product sold!");
                        }
                    }
                }
                if (totalPayments >= expectedRevenue)
                {
                    Console.WriteLine($"Average CS: {cashPayment / cashPaymentCounter:f2}");
                    Console.WriteLine($"Average CC: {cardPayment / cardPaymentCounter:f2}");
                }
            }
        }
    }
