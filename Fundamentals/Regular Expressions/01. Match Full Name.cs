using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)";

            Regex regex = new Regex(pattern);

            MatchCollection match = Regex.Matches(text, pattern);


            foreach (Match item in match)
            {
                Console.Write("{0} ", string.Join(" ", item));
            }
        }
    }
}
//1.Match Full Name
//Write a C# Program to match full names from a list of names and print them on the console.
//Writing the Regular Expression
//First, create a regular expression to match a valid full name, according to these conditions:
//•	A valid full name has the following characteristics:
//o It consists of two words.
//o	Each word starts with a capital letter.
//o	After the first letter, it only contains lowercase letters afterwards.
//o	Each of the two words should be at least two letters long.
//o	The two words are separated by a single space.
//To help you out, we've outlined several steps:
//1.	Use an online regex tester like https://regex101.com/ 
//2.Check out how to use character sets (denoted with square brackets - "[]")
//3.Specify that you want two words with a space between them (the space character ' ', and not any whitespace symbol)
//4.For each word, specify that it should begin with an uppercase letter using a character set.The desired characters are in a range – from 'A' to 'Z'.
//5.	For each word, specify that what follows the first letter are only lowercase letters, one or more – use another character set and the correct quantifier.
//6.	To prevent capturing of letters across new lines, put "\b" at the beginning and at the end of your regex. This will ensure that what precedes and what follows the match is a word boundary (like a new line).
//In order to check your RegEx, use these values for reference (paste all of them in the Test String field):
//Match ALL of these	Match NONE of these
//Bethany Taylor John Smith	Bethany Taylor, Oliver miller, sophia Johnson, SARah Wilson, John Smith, Sam	        Smith
//By the end, the matches should look something like this:
 
//After you’ve constructed your regular expression, it’s time to write the solution in C#.
//Examples

//Input	
//Bethany Taylor, Oliver miller, sophia Johnson, SARah Wilson, John Smith, Sam	        Smith 	

//Output
//Bethany Taylor John Smith

//Input
//Elvis Presley a a C C-Muhammad Ali EE PeterpeterJR-a a xi ban D D bb b b-B B-c c EE-Michael Jackson DD peter smith B B PETER BROWN IVAN DAVIES-	

//Output
//Elvis Presley Muhammad Ali Michael Jackson
