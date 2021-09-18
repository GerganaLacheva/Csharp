using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticketPrice = 0;

            if (age >= 0 && age <= 18)
            {
                switch (typeOfDay)
                {
                    case "Weekday": ticketPrice = 12; break;
                    case "Weekend": ticketPrice = 15; break;
                    case "Holiday": ticketPrice = 5; break;
                }
                Console.WriteLine($"{ticketPrice}$");
            }
            else if (age > 18 && age <= 64)
            {
                switch (typeOfDay)
                {
                    case "Weekday": ticketPrice = 18; break;
                    case "Weekend": ticketPrice = 20; break;
                    case "Holiday": ticketPrice = 12; break;
                }
                Console.WriteLine($"{ticketPrice}$");
            }
            else if (age > 64 && age <= 122)
            {
                switch (typeOfDay)
                {
                    case "Weekday": ticketPrice = 12; break;
                    case "Weekend": ticketPrice = 15; break;
                    case "Holiday": ticketPrice = 10; break;
                }
                Console.WriteLine($"{ticketPrice}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
//7.Theatre Promotions
//A theatre is sail tickets at discount, and a program is needed to calculate the price of a single ticket. If the given age does not fit one of the categories, you should print "Error!".  
//The prices of the tickers are as follows:
//Day / Age   0 <= age <= 18  18 < age <= 64  64 < age <= 122
//Weekday 12$	18$	12$
//Weekend 15$	20$	15$
//Holiday 5$	12$	10$
//Input
//The input comes in two lines. On the first line, you will receive the type of day. On the second – the age of the person.
//Output
//Print the price of the ticket according to the table, or "Error!" if the age is not in the table.
//Constraints
//•	The age will be in the interval [-1000…1000].
//•	The type of day will always be valid. 
//Examples
//Input	Output		
//Weekday
//42	18$		Holiday
//-12	Error!		Holiday
//15	5$		Weekend
//122	15$
