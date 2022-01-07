using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool partyStarted = false;
            HashSet<string> vipPeople = new HashSet<string>();
            HashSet<string> regularPeople = new HashSet<string>();
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "PARTY")
                {
                    partyStarted = true;
                    continue;
                }
                if (partyStarted)
                {
                    if (IsVip(command))
                    {
                        vipPeople.Remove(command);
                    }
                    else
                    {
                        regularPeople.Remove(command);
                    }
                }
                else
                {
                    if (IsVip(command))
                    {
                        vipPeople.Add(command);
                    }
                    else
                    {
                        regularPeople.Add(command);
                    }
                }
            }
            Console.WriteLine(vipPeople.Count + regularPeople.Count);

            foreach (var person in vipPeople)
            {
                Console.WriteLine(person);
            }
            foreach (var person in regularPeople)
            {
                Console.WriteLine(person);
            }
        }
        private static bool IsVip(string number)
        {
            int num = 0;
            return int.TryParse(number.Substring(0, 1), out num);
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
