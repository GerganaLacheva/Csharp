using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = @"\b(?<date>[0-9]{2})([\/\.\-])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";

            MatchCollection matchDate = Regex.Matches(input, patern);


            foreach (Match date in matchDate)
            {
                string day = date.Groups["date"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
