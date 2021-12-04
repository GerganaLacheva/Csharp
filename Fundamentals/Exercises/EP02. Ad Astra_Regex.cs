using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace EP02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||#)([A-Za-z\s]+)\1(\d{2}\/\d{2}\/\d{2})\1(\d{1,4}|10000)\1";

            Regex regex = new Regex(pattern);

            string data = Console.ReadLine();

            MatchCollection matches = regex.Matches(data);

            int calories = matches.Select(m => int.Parse(m.Groups[4].ToString())).Sum();

            Console.WriteLine($"You have food to last you for: {calories/2000} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups[2].Value}, Best before: {match.Groups[3].Value}, Nutrition: {match.Groups[4]}");
            }
        }
    }
}
//Problem 2 - Ad Astra
//Problem for exam preparation for the Programming Fundamentals Course @SoftUni.
//Submit your solutions in the SoftUni judge system at https://judge.softuni.org/Contests/Practice/Index/2525#1.

//You are an astronaut who just embarked on a mission across the solar system. Since you will be in space for a long time, you have packed a lot of food with you. Create a program, which helps you identify how much food you have left and gives you information about its expiration date.
//On the first line of the input, you will be given a text string. You must extract the information about the food and calculate the total calories. 
//First, you must extract the food info. It will always follow the same pattern rules:
//•	It will be surrounded by "|" or "#" (only one of the two) in the following pattern: 
//#{item name}#{expiration date}#{calories}#   or 
//|{ item name}|{ expiration date}|{ calories}|
//•	The item name will contain only lowercase and uppercase letters and whitespace
//•	The expiration date will always follow the pattern: "{day}/{month}/{year}", where the day, month, and year will be exactly two digits long
//•	The calories will be an integer between 0-10000
//Calculate the total calories of all food items and then determine how many days you can last with the food you have. Keep in mind that you need 2000kcal a day.
//Input / Constraints
//•	You will receive a single string
//Output
//•	First, print the number of days you will be able to last with the food you have:
//"You have food to last you for: {days} days!"
//•	The output for each food item should look like this:
//"Item: {item name}, Best before: {expiration date}, Nutrition: {calories}"
//
//Examples
//Input
//#Bread#19/03/21#4000#|Invalid|03/03.20||Apples|08/10/20|200||Carrots|06/08/20|500||Not right|6.8.20|5|
//
//Output	
//You have food to last you for: 2 days!
//Item: Bread, Best before: 19 / 03 / 21, Nutrition: 4000
//Item: Apples, Best before: 08 / 10 / 20, Nutrition: 200
//Item: Carrots, Best before: 06 / 08 / 20, Nutrition: 500
//
//Comments
//We have a total of three matches – bread, apples, and carrots. 
//The sum of their calories is 4700. Since you need 2000kcal a day, we divide 4700/2000, which means this food will last you for 2 days.
//We print each item
//
//Input
//$$#@@%^&#Fish#24/12/20#8500#|#Incorrect#19.03.20#450|$5*(@!#Ice Cream#03/10/21#9000#^#@aswe|Milk|05/09/20|2000|
//
//Output	
//You have food to last you for: 9 days!
//Item: Fish, Best before: 24 / 12 / 20, Nutrition: 8500
//Item: Ice Cream, Best before: 03 / 10 / 21, Nutrition: 9000
//Item: Milk, Best before: 05 / 09 / 20, Nutrition: 2000
//
//Comments
//We have three matches. The total calories are 8500 + 9000 + 2000 = 19500, which means you have food for a total of 9 days.
//
//Input
//Hello|#Invalid food#19/03/20#450|$5*(@
//Output	
//You have food to last you for: 0 days!
//
//Comments
//We have no matches, which means we have no food.
//The colored text is not a match since it doesn't have a # at the end.
