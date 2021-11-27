using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EP02.Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "^@#+[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1}@#+$";
            string digitsPattern = "[0-9]";

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string currentInput = Console.ReadLine();

                Match match = Regex.Match(currentInput, pattern);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                MatchCollection matches = Regex.Matches(currentInput, digitsPattern);

                Console.Write($"Product group: ");

                if (matches.Count==0)
                {
                    Console.WriteLine("00");
                    continue;
                }

                foreach (Match item in matches)
                {
                    Console.Write(item.Value);
                }
                Console.WriteLine();

            }
        }
    }
}
//Problem 2 - Fancy Barcodes
//Problem for exam preparation for the Programming Fundamentals Course @SoftUni.
//Submit your solutions in the SoftUni judge system at https://judge.softuni.org/Contests/Practice/Index/2303#1.

//Your first task is to determine if the given sequence of characters is a valid barcode or not. 
//Each line must not contain anything else but a valid barcode. A barcode is valid when:
//•	It is surrounded by a "@" followed by one or more "#"
//•	It is at least 6 characters long (without the surrounding "@" or "#")
//•	It starts with a capital letter
//•	It contains only letters (lower and upper case) and digits
//•	It ends with a capital letter
//Examples of valid barcodes: @#FreshFisH@#, @###Brea0D@###, @##Che46sE@##, @##Che46sE@###
//Examples of invalid barcodes: ##InvaliDiteM##, @InvalidIteM@, @#Invalid_IteM@#
//Next, you have to determine the product group of the item from the barcode. The product group is obtained by concatenating all the digits found in the barcode. If there are no digits present in the barcode, the default product group is "00".
//Examples:  
//@#FreshFisH@# -> product group: 00
//@###Brea0D@### -> product group: 0
//@##Che4s6E@## -> product group: 46
//Input
//On the first line, you will be given an integer n – the count of barcodes that you will be receiving next. 
//On the following n lines, you will receive different strings.
//Output
//For each barcode that you process, you need to print a message.
//If the barcode is invalid:
//•	"Invalid barcode"
//If the barcode is valid:
//•	"Product group: {product group}"
//Examples
//Input	
//3
//@#FreshFisH@#
//@###Brea0D@###
//@##Che4s6E@##	
//
//Output
//Product group: 00
//Product group: 0
//Product group: 46
//
//Input 
//6
//@###Val1d1teM@###
//@#ValidIteM@#
//##InvaliDiteM##
//@InvalidIteM@
//@#Invalid_IteM@#
//@#ValiditeM@#	
//
//Output
//Product group: 11
//Product group: 00
//Invalid barcode
//Invalid barcode
//Invalid barcode
//Product group: 00
