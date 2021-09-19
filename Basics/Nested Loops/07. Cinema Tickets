using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int totalTicketsSold = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            while (movie != "Finish")
            {

                int capacity = int.Parse(Console.ReadLine());
                int numOfTicketsSold = 0;

                while (numOfTicketsSold < capacity)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType)
                    {
                        case "student": studentTickets++; break;
                        case "standard": standardTickets++; break;
                        case "kid": kidTickets++; break;
                    }
                    numOfTicketsSold++;
                }
                totalTicketsSold += numOfTicketsSold;
                Console.WriteLine($"{movie} - {1.0 * numOfTicketsSold / capacity * 100:f2}% full.");

                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTicketsSold}");
            Console.WriteLine($"{1.0*studentTickets/totalTicketsSold*100:f2}% student tickets.");
            Console.WriteLine($"{1.0*standardTickets/totalTicketsSold*100:f2}% standard tickets.");
            Console.WriteLine($"{1.0*kidTickets/totalTicketsSold*100:f2}% kids tickets.");
        }
    }
}
