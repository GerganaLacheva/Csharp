using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08._SoftUni_Party_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command == "PARTY")
                {
                    string visiting = Console.ReadLine();
                    while (visiting != "END")
                    {
                        if (vip.Contains(visiting))
                        {
                            vip.Remove(visiting);
                        }
                        else if (regular.Contains(visiting))
                        {
                            regular.Remove(visiting);
                        }
                        visiting = Console.ReadLine();
                    }
                    break;
                }
                else
                {
                    string pattern = @"[0-9](.){7,}";
                    Match match = Regex.Match(command, pattern);
                    if (match.Success)
                    {
                        vip.Add(command);
                    }
                    else
                    {
                        regular.Add(command);
                    }
                }
                command = Console.ReadLine();
            }

            int countAbsentPeople = regular.Count + vip.Count;
            Console.WriteLine(countAbsentPeople);
            if (vip.Any())
            {
                foreach (var person in vip)
                {
                    Console.WriteLine(person);
                }
            }
            if (regular.Any())
            {
                foreach (var person in regular)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}
//8.SoftUni Party
//There is a party in SoftUni. Many guests are invited and there are two types of them: VIP and Regular. When a guest comes, check if he/she exists in any of the two reservation lists.
//All reservation numbers will be with the length of 8 chars.
//All VIP numbers start with a digit.
//First, you will be receiving the reservation numbers of the guests. You can also receive 2 possible commands:
//•	"PARTY" – After this command, you will begin receiving the reservation numbers of the people, who came to the party.
//•	"END" – The party is over and you have to stop the program and print the appropriate output.
//In the end, print the count of the guests who didn't come to the party, and afterward, print their reservation numbers. the VIP guests must be first.
//Examples
//Input       
//7IK9Yo0h
//9NoBUajQ
//Ce8vwPmE
//SVQXQCbc
//tSzE5t0p
//PARTY
//9NoBUajQ
//Ce8vwPmE
//SVQXQCbc
//END

//Output
//2
//7IK9Yo0h
//tSzE5t0p

//Input
//m8rfQBvl
//fc1oZCE0
//UgffRkOn
//7ugX7bm0
//9CQBGUeJ
//2FQZT3uC
//dziNz78I
//mdSGyQCJ
//LjcVpmDL
//fPXNHpm1
//HTTbwRmM
//B5yTkMQi
//8N0FThqG
//xys2FYzn
//MDzcM9ZK
//PARTY
//2FQZT3uC
//dziNz78I
//mdSGyQCJ
//LjcVpmDL
//fPXNHpm1
//HTTbwRmM
//B5yTkMQi
//8N0FThqG
//m8rfQBvl
//fc1oZCE0
//UgffRkOn
//7ugX7bm0
//9CQBGUeJ
//END

//Output
//2
//xys2FYzn
//MDzcM9ZK
