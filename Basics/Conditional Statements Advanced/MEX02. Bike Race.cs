using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t02.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string routType = Console.ReadLine();
            double ticketPerJunior = 0;
            double ticketPerSenior = 0;
            double totalIncome = 0;
            double charityTotal = 0;

            switch (routType)
            {
                case "trail":
                    ticketPerJunior = 5.5;
                    ticketPerSenior = 7;
                    totalIncome = juniors * ticketPerJunior + seniors * ticketPerSenior;
                    break;
                case "cross-country":
                    if ((juniors + seniors) >= 50)
                    {
                        ticketPerJunior = 8 * 0.75;
                        ticketPerSenior = 9.5 * 0.75;
                    }
                    else
                    {
                        ticketPerJunior = 8;
                        ticketPerSenior = 9.5;
                    }
                    totalIncome = juniors * ticketPerJunior + seniors * ticketPerSenior;
                    break;
                case "downhill":
                    ticketPerJunior = 12.25;
                    ticketPerSenior = 13.75;
                    totalIncome = juniors * ticketPerJunior + seniors * ticketPerSenior;
                    break;
                case "road":
                    ticketPerJunior = 20;
                    ticketPerSenior = 21.5;
                    totalIncome = juniors * ticketPerJunior + seniors * ticketPerSenior;
                    break;
            }
            charityTotal = totalIncome * 0.95;
            Console.WriteLine($"{charityTotal:f2}");
        }
    }
}
