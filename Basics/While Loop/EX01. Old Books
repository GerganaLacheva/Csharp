using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string book = Console.ReadLine();
            int bookCounter = 0;

            while (book!=searchedBook)
            {
                if (book=="No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {bookCounter} books.");
                    break;
                }

                bookCounter++;
                book = Console.ReadLine();
            }
            if (book==searchedBook)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }

        }
    }
}
