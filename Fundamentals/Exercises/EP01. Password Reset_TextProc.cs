using System;
using System.Linq;
using System.Text;

namespace EP01._Password_Reset_TextProc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = Console.ReadLine();


            while (input != "Done")
            {
                string[] tokens = input.Split();
                string action = tokens[0];

                if (tokens[0] == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sb.Append(password[i]);
                        }
                    }
                    password = sb.ToString();
                    Console.WriteLine(password);

                }
                else if (tokens[0] == "Cut")
                {
                    int index = int.Parse(tokens[1]);
                    int cutLenght = int.Parse(tokens[2]);

                    password = password.Remove(index, cutLenght);
                    Console.WriteLine(password);
                }
                else if (tokens[0] == "Substitute")
                {
                    string substring = tokens[1];
                    string substitute = tokens[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
//Problem 1 - Password Reset
//Problem for exam preparation for the Programming Fundamentals Course @SoftUni.
//Submit your solutions in the SoftUni judge system at https://judge.softuni.org/Contests/Practice/Index/2303#0.

//Yet again, you have forgotten your password. Naturally, it's not the first time this has happened. Actually, you got so tired of it that you decided to help yourself with an intelligent solution.
//Write a password reset program that performs a series of commands upon a predefined string. First, you will receive a string, and afterward, until the command "Done" is given, you will be receiving strings with commands split by a single space. The commands will be the following:
//•	"TakeOdd"
//o Takes only the characters at odd indices and concatenates them to obtain the new raw password and then prints it.
//•	"Cut {index} {length}"
//o	Gets the substring with the given length starting from the given index from the password and removes its first occurrence, then prints the password on the console.
//o	The given index and the length will always be valid.
//•	"Substitute {substring} {substitute}"
//o	If the raw password contains the given substring, replaces all of its occurrences with the substitute text given and prints the result.
//o	If it doesn't, prints "Nothing to replace!".
//Input
//•	You will be receiving strings until the "Done" command is given.
//Output
//•	After the "Done" command is received, print:
//o "Your password is: {password}"
//Constraints
//•	The indexes from the "Cut {index} {length}" command will always be valid.
//
//Examples
//Input	
//Siiceercaroetavm!:?:ahsott.:i: nstupmomceqr
// TakeOdd
//Cut 15 3
//Substitute:: -
//Substitute | ^
//Done
//
//Output
//icecream::hot::summer
//icecream::hot::mer
//icecream-hot-mer
//Nothing to replace!
//Your password is: icecream-hot-mer
//
//Comments
//TakeOdd -> We only take the chars at odd indices 1, 3, 5 etc.
//Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr -> icecream::hot::summer
//Cut 15  3 -> We cut a substring starting at index 15 with length 3, then remove it from the raw password:
//icecream::hot::summer -> sum
//              Substitute :: - -> We replace "::" with "-":
//icecream::hot::summer -> icream-hot-summer
//              Substitute | ^ -> "|" is not found anywhere in the raw password, so we print "Nothing to replace!"
//Finally, after receiving the "Done" command, we print the resulting password in the proper format.
//
//Input 
//up8rgoyg3r1atmlmpiunagt!-irs7!1fgulnnnqy
//TakeOdd
//Cut 18 2
//Substitute ! ***
//Substitute? .!.
//Done
//
//Output
//programming!is!funny
//programming!is!fun
//programming***is***fun
//Nothing to replace!
//Your password is: programming***is***fun
