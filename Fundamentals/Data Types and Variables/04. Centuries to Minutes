using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;    //1 year = 365.2422 days on average (the Tropical year)
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years:f0} years = {days:f0} days = {hours} hours = {minutes} minutes");
        }
    }
}
