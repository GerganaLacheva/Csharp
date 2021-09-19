using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = 0;
            string sport = "";
            double totalPrice = 0;

            switch (season)
            {
                case "Winter":
                    if (groupType == "boys")
                    {
                        pricePerNight = 9.6;
                        sport = "Judo";
                    }
                    else if (groupType == "girls")
                    {
                        pricePerNight = 9.6;
                        sport = "Gymnastics";
                    }
                    else if (groupType == "mixed")
                    {
                        pricePerNight = 10.0;
                        sport = "Ski";
                    }
                    break;
                case "Spring":
                    if (groupType == "boys")
                    {
                        pricePerNight = 7.2;
                        sport = "Tennis";
                    }
                    else if (groupType == "girls")
                    {
                        pricePerNight = 7.2;
                        sport = "Athletics";
                    }
                    else if (groupType == "mixed")
                    {
                        pricePerNight = 9.5;
                        sport = "Cycling";
                    }
                    break;
                case "Summer":
                    if (groupType == "boys")
                    {
                        pricePerNight = 15;
                        sport = "Football";
                    }
                    else if (groupType == "girls")
                    {
                        pricePerNight = 15;
                        sport = "Volleyball";
                    }
                    else if (groupType == "mixed")
                    {
                        pricePerNight = 20;
                        sport = "Swimming";
                    }
                    break;
            }
            totalPrice = numberOfStudents * nights * pricePerNight;
            if (numberOfStudents >= 50)
            {
                totalPrice = numberOfStudents * nights * pricePerNight * 0.5;
            }
            if (numberOfStudents >= 20 && numberOfStudents < 50)
            {
                totalPrice = numberOfStudents * nights * pricePerNight * 0.85;
            }
            if (numberOfStudents >= 10 && numberOfStudents < 20)
            {
                totalPrice = numberOfStudents * nights * pricePerNight * 0.95;
            }
            Console.WriteLine($"{sport} {totalPrice:f2} lv.");
        }
    }
}
