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
            string pattern = @"\b(?<date>[0-9]{2})([\/\.\-])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";

            MatchCollection matchDate = Regex.Matches(input, pattern);


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
//3.Match Dates
//Write a program, which matches a date in the format "dd{separator}MMM{separator}yyyy". Use named capturing groups in your regular expression.
//Compose the Regular Expression
//Every valid date has the following characteristics:
//•	Always starts with two digits, followed by a separator
//•	After that, it has one uppercase and two lowercase letters (e.g. Jan, Mar).
//•	After that, it has a separator and exactly 4 digits (for the year).
//•	The separator could be either of three things: a period("."), a hyphen("-") or a forward slash ("/")
//•	The separator needs to be the same for the whole date (e.g. 13.03.2016 is valid, 13.03/2016 is NOT). Use a group backreference to check for this.
//You can follow the table below to help with composing your RegEx:
//Match ALL of these	Match NONE of these
//13/Jul/1928, 10-Nov-1934, 25.Dec.1937	01/Jan-1951, 23/sept/1973, 1/Feb/2016
//Examples
//Input	
//13/Jul/1928, 10-Nov-1934, , 01/Jan-1951, f 25.Dec.1937 23/09/1973, 1/Feb/2016	

//Output
//Day: 13, Month: Jul, Year: 1928
//Day: 10, Month: Nov, Year: 1934
//Day: 25, Month: Dec, Year: 1937

//Input
//03 - Mar - 1878, 25 / Apr / 1915, 31 - May - 1916, 22 / Jun - 1941, 25.Dec.1937, 23 / 09 / 1973


//Output
//Day: 03, Month: Mar, Year: 1878
//Day: 25, Month: Apr, Year: 1915
//Day: 31, Month: May, Year: 1916
//Day: 25, Month: Dec, Year: 1937
