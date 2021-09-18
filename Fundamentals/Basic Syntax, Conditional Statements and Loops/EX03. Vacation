using System;

namespace EX03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double singlePrice = 0;
            double totalExpenses = 0;

            switch (dayOfWeek)
            {
                case "Friday":
                    switch (groupType)
                    {
                        case "Students": singlePrice = 8.45; break;
                        case "Business": singlePrice = 10.9; break;
                        case "Regular": singlePrice = 15; break;
                    }
                    break;
                case "Saturday":
                    switch (groupType)
                    {
                        case "Students": singlePrice = 9.8; break;
                        case "Business": singlePrice = 15.6; break;
                        case "Regular": singlePrice = 20; break;
                    }
                    break;
                case "Sunday":
                    switch (groupType)
                    {
                        case "Students": singlePrice = 10.46; break;
                        case "Business": singlePrice = 16; break;
                        case "Regular": singlePrice = 22.5; break;
                    }
                    break;
            }
            totalExpenses = singlePrice * peopleCount;

            if (groupType == "Students" && peopleCount >= 30)
            {
                totalExpenses *= 0.85;
            }
            if (groupType == "Business" && peopleCount >= 100)
            {
                totalExpenses = (peopleCount - 10) * singlePrice;
            }
            if (groupType == "Regular" && peopleCount >= 10 && peopleCount <= 20)
            {
                totalExpenses *= 0.95;
            }

            Console.WriteLine($"Total price: {totalExpenses:f2}");
        }
    }
}
//You will receive three lines from the console:
//•	A count of people, which are going on vacation.
//•	Type of the group (Students, Business, or Regular).
//•	 The day of the week which the group will stay (Friday, Saturday, or Sunday).
//Based on the given information calculate how much the group will pay for the entire vacation. 
//The price for a single person is as follows:
//	        Friday Saturday	Sunday
//Students	8.45	9.80	10.46
//Business	10.90	15.60	16
//Regular	15	    20	    22.50
//There are also discounts based on some conditions:
//•	Students – if the group is bigger than or equal to 30 people you should reduce the total price by 15%
//•	Business – if the group is bigger than or equal to 100 people 10 of them can stay for free.
//•	Regular – if the group is bigger than or equal to 10 and less than or equal to 20 reduce the total price by 5%
//Note: You should reduce the prices in that EXACT order!
//As an output print the final price which the group is going to pay in the format: 
//"Total price: {price}"
//The price should be formatted to the second decimal point.
//Examples
//Input	Output
//30
//Students
//Sunday	Total price: 266.73
//40
//Regular
//Saturday	Total price: 800.00
