using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EX05.Nether_Realms
{
    public class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public double Damage { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputDemons = Console.ReadLine().Split(',').Select(e => e.Trim()).ToArray();

            Regex hpRegex = new Regex(@"[^\d\-+.*\/]");                 //health points
            Regex numbersRegex = new Regex(@"[+\-]{0,1}\d+\.?\d*");     //damage points
            Regex manipulatorsRegex = new Regex(@"[*\/]");              //symbols ('*' and '/') that can further alter the base damage by multiplying or dividing it by 2

            List<Demon> demons = new List<Demon>();

            foreach (var demon in inputDemons)
            {
                MatchCollection hpMatches = hpRegex.Matches(demon);
                int health = GetHealth(hpMatches);

                MatchCollection numberMatches = numbersRegex.Matches(demon);
                double damage = GetBaseDamage(numberMatches);

                MatchCollection manipulatorsMatches = manipulatorsRegex.Matches(demon);
                foreach (Match match in manipulatorsMatches)
                {
                    if (match.Value == "*")
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                demons.Add(new Demon
                {
                    Name = demon,
                    Damage = damage,
                    Health = health
                });
            }
            List<Demon> sorted = demons.OrderBy(d => d.Name).ToList();
            foreach (Demon demon in sorted)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }

        }

        private static double GetBaseDamage(MatchCollection matchCollection)
        {
            double damage = 0;
            foreach (Match match in matchCollection)
            {
                damage += double.Parse(match.Value);
            }
            return damage;
        }

        private static int GetHealth(MatchCollection matchCollection)
        {
            int sum = 0;
            foreach (Match match in matchCollection)
            {
                sum += char.Parse(match.Value);
            }
            return sum;
        }
    }
}
//Nether Realms
//Mighty battle is coming. In the stormy nether realms, demons are fighting against each other for supremacy in a duel from which only one will survive. 
//Your job, however is not so exciting. You are assigned to sign in all the participants in the nether realm's mighty battle's demon book, which of course is sorted alphabetically. 
//A demon's name contains his health and his damage. 
//The sum of the asci codes of all characters (excluding numbers (0-9), arithmetic symbols('+', '-', '*', '/') and delimiter dot ('.')) gives a demon's total health. 
//The sum of all numbers in his name forms his base damage. Note that you should consider the plus '+' and minus '-' signs (e.g. +10 is 10 and -10 is -10). However, there are some symbols ('*' and '/') that can further alter the base damage by multiplying or dividing it by 2 (e.g. in the name "m15*/c-5.0", the base damage is 15 + (-5.0) = 10 and then you need to multiply it by 2 (e.g. 10 * 2 = 20) and then divide it by 2 (e.g. 20 / 2 = 10)). 
//So, multiplication and division are applied only after all numbers are included in the calculation and in the order they appear in the name. 
//You will get all demons on a single line, separated by commas and zero or more blank spaces. Sort them in alphabetical order and print their names along their health and damage. 
//Input
//The input will be read from the console. The input consists of a single line containing all demon names separated by commas and zero or more spaces in the format: "{demon name}, {demon name}, … {demon name}"
//Output
//Print all demons sorted by their name in ascending order, each on a separate line in the format:
//•	"{demon name} - {health points} health, {damage points} damage"
//Constraints
//•	A demon's name will contain at least one character
//•	A demon's name cannot contain blank spaces ' ' or commas ','
//•	A floating point number will always have digits before and after its decimal separator
//•	Number in a demon's name is considered everything that is a valid integer or floating point number (with dot '.' used as separator). For example, all these are valid numbers: '4', '+4', '-4', '3.5', '+3.5', '-3.5' 
//Examples
//Input	                    Output	
//M3ph-0.5s-0.5t0.0**	    M3ph-0.5s-0.5t0.0** - 524 health, 8.00 damage	
//
//Comments
//M3ph-0.5s-0.5t0.0**:
//Health = 'M' + 'p' + 'h' + 's' + 't' = 524 health.
//Damage = (3 + (-0.5) + (-0.5) + 0.0) * 2 * 2 = 8 damage.


//Input                     Output	
//M3ph1st0**, Azazel	    Azazel - 615 health, 0.00 damage 
//                          M3ph1st0** - 524 health, 16.00 damage
//
//Comments
//Azazel: 
//Health - 'A' + 'z' + 'a' + 'z' + 'e' + 'l' = 615 health.Damage - no digits = 0 damage.
//M3ph1st0 * *:
//Health - 'M' + 'p' + 'h' + 's' + 't' = 524 health.
//Damage - (3 + 1 + 0) * 2 * 2 = 16 damage.

//Input                     Output
//Gos / ho                  Gos / ho - 512 health, 0.00 damage
