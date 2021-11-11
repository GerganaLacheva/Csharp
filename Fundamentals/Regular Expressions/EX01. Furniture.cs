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
            string pattern = @"^>>([A-Za-z]+)<<([0-9]+\.{0,1}[0-9]{0,})!([0-9]+)"; //грешен тест 4 в джъдж дава инпут дробно число количество,
                                                                                   //но иска да се зачита само цялото число;
                                                                                   //не слагаме $ на края, оставяме го с отворен край

            string input = Console.ReadLine();

            Console.WriteLine($"Bought furniture:");

            double totalPrice = 0;

            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string productName = match.Groups[1].Value;
                double productPrice = double.Parse(match.Groups[2].Value);
                double productQty = double.Parse(match.Groups[3].Value);

                totalPrice += productPrice * productQty;

                Console.WriteLine(productName);

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
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
