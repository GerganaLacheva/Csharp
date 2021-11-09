using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var username in input)
            {
                if (username.Length <= 3 || username.Length > 16)    //invalid username
                {
                    continue;
                }

                bool isValid = false;

                foreach (var symbol in username)
                {
                    if (!(char.IsDigit(symbol) || char.IsLetter(symbol) || symbol == '-' || symbol == '_'))
                    {
                        isValid = false;
                        break;
                    }
                    isValid = true;
                }
                if (isValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
//Valid Usernames
//Create a program that reads user names on a single line (joined by “, “) and prints all valid usernames. 
//A valid username is:
//•	Has length between 3 and 16 characters
//•	Contains only letters, numbers, hyphens and underscores
//Examples
//Input	                                                Output
//sh, too_long_username, !lleg@l ch@rs, jeffbutt	    jeffbutt
//
//Input	                                                Output
//Jeff, john45, ab, cd, peter-ivanov, @smith	        Jeff
//                                                      John45
//                                                      peter-ivanov
