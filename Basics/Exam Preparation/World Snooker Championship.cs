using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т03.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string champinshipStage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double totalPrice = 0;

            switch (champinshipStage)
            {
                case "Quarter final":
                    switch (ticketType)
                    {
                        case "Standard":
                            ticketPrice = 55.5;
                            break;
                        case "Premium":
                            ticketPrice = 105.20;
                            break;
                        case "VIP":
                            ticketPrice = 118.9;
                            break;
                    }
                    break;
                case "Semi final":
                    switch (ticketType)
                    {
                        case "Standard":
                            ticketPrice = 75.88;
                            break;
                        case "Premium":
                            ticketPrice = 125.22;
                            break;
                        case "VIP":
                            ticketPrice = 300.4;
                            break;
                    }
                    break;
                case "Final":
                    switch (ticketType)
                    {
                        case "Standard":
                            ticketPrice = 110.1;
                            break;
                        case "Premium":
                            ticketPrice = 160.66;
                            break;
                        case "VIP":
                            ticketPrice = 400;
                            break;
                    }
                    break;
            }
            totalPrice = ticketPrice * numberOfTickets;
            bool freePhoto = false;
            if (totalPrice>4000)
            {
                totalPrice *= 0.75;
                freePhoto = true;
            }
            else if (totalPrice>2500&&totalPrice<=4000)
            {
                totalPrice *= 0.9;
            }
            if (photo=='Y'&& !freePhoto)
            {
                totalPrice += 40 * numberOfTickets;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
