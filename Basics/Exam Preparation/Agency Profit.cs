using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Agency_Profit_07._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string airline = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int childrenTickets = int.Parse(Console.ReadLine());
            double adultTicketPrice = double.Parse(Console.ReadLine());
            double serviceFee = double.Parse(Console.ReadLine());

            double childrenTicketPrice = adultTicketPrice * 0.3;
            double totalPrice = adultTickets * (adultTicketPrice+serviceFee) + childrenTickets * (childrenTicketPrice+serviceFee);
            double profit = totalPrice * 0.2;

            Console.WriteLine($"The profit of your agency from {airline} tickets is {profit:f2} lv.");
        }
    }
}
