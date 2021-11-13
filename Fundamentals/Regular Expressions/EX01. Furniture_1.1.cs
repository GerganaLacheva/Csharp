using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EX01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^>>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)");

            List<string> furnitures = new List<string>();
            double totalMoney = 0;


            while (true)
            {
                string line = Console.ReadLine();

                if (line== "Purchase")
                {
                    break;
                }

                Match match = regex.Match(line);

                if (!match.Success)     //invalid input
                {
                    continue;
                }

                string name = match.Groups["name"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);

                furnitures.Add(name);
                totalMoney += price * quantity;
            }
            Console.WriteLine("Bought furniture:");

            foreach (string furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }
    }
}
//1.Furniture
//Create a program to calculate the total cost of different types of furniture. You will be given some lines of input
//until you receive the line "Purchase". For the line to be valid it should be in the following format:
//">>{furniture name}<<{price}!{quantity}"
//The price can be floating point number or whole number. Store the names of the furniture and the total price.
//At the end print the each bought furniture on separate line in the format:
//"Bought furniture:
//{ 1st name}
//{ 2nd name}
//…"
//And on the last line print the following: "Total money spend: {spend money}" formatted to the second decimal point.
//Examples
//Input	                    Output	                            
//>>Sofa<<312.23!3          Bought furniture:                   
//>Invalid<<!5              TV
//Purchase                  Total money spend: 2436.69
//
//Input	                    Output		
//>>Chair<<412.23!3         Bought furniture:
//>>Sofa<<500!5             Chair
//>>Recliner<<<<!5          Sofa
//>>Bench<<230!10           Bench
//>>>>>>Rocking chair<<!5   Bed 
//>>Bed<<700!5              Total money spend: 9536.69
//Purchase	
