using System;
using System.Collections.Generic;
using System.Linq;

namespace EX10._ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> forceRegister = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                if (input.Contains('|'))
                {
                    string[] data = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string side = data[0];
                    string user = data[1];
                    if (forceRegister.ContainsKey(side) == false)
                    {
                        forceRegister.Add(side, new List<string>());
                    }
                    if (forceRegister[side].Contains(user) == false &&
                        forceRegister.Values.Any(x => x.Contains(user)) == false)
                    {
                        forceRegister[side].Add(user);

                    }

                }
                else if (input.Contains("->"))
                {
                    string[] data = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string user = data[0];
                    string side = data[1];

                    if (forceRegister.Any(x => x.Value.Contains(user)) == false)
                    {
                        if (forceRegister.ContainsKey(side) == false)
                        {

                            forceRegister.Add(side, new List<String>());
                        }

                        forceRegister[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        foreach (var s in forceRegister)
                        {
                            if (s.Value.Contains(user))
                            {
                                s.Value.Remove(user);
                            }
                        }

                        if (forceRegister.ContainsKey(side) == false)
                        {
                            forceRegister.Add(side, new List<string>());
                        }
                        forceRegister[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var side in forceRegister.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count()}");
                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
//ForceBook
//The force users are struggling to remember which side is the different forceUsers from because they switch them too often.
//So you are tasked to create a web application to manage their profiles. You should store an information for every
//unique forceUser, registered in the application.
//You will receive several input lines in one of the following formats:
//{ forceSide} | { forceUser}
//{ forceUser} -> { forceSide}
//The forceUser and forceSide are strings, containing any character. 
//If you receive forceSide | forceUser, you should check if such forceUser already exists, and if not, add him/her
//to the corresponding side. 
//If you receive a forceUser -> forceSide, you should check if there is such a forceUser already and if so, change his/her side.
//If there is no such forceUser, add him/her to the corresponding forceSide, treating the command as a newly registered forceUser.
//Then you should print on the console: "{forceUser} joins the {forceSide} side!"
//You should end your program when you receive the command "Lumpawaroo". At that point, you should print each force side,
//ordered descending by forceUsers count then ordered by name. For each side print the forceUsers, ordered by name.
//In case there are no forceUsers in the side, you shouldn`t print the side information. 
//Input / Constraints
//•	The input comes in the form of commands in one of the formats specified above.
//•	The input ends, when you receive the command "Lumpawaroo".
//Output
//•	As output for each forceSide, ordered descending by forceUsers count, then by name, you must print all the forceUsers,
//ordered by name alphabetically.
//•	The output format is:
//"Side: {forceSide}, Members: {forceUsers.Count}"
//"! {forceUser}"
//"! {forceUser}"
//"! {forceUser}"
//•	In case there are NO forceUsers, don`t print this side. 
//Examples
//Input		
//Light | George
//Dark | Peter
//Lumpawaroo	
//
//Output
//Side: Dark, Members: 1
//! Peter
//Side: Light, Members: 1
//! George
//
//Comments
//We register George in the Light side and Pesho in the Dark side. After receiving "Lumpawaroo" we print both sides,
//ordered by membersCount and then by name.

//Input
//Lighter | Royal
//Darker | DCay
//John Johnys -> Lighter
//DCay -> Lighter
//Lumpawaroo	

//Output
//John Johnys joins the Lighter side!
//DCay joins the Lighter side!
//Side: Lighter, Members: 3
//! DCay
//! John Johnys
//! Royal	
    
//Comments
//Although John Johnys doesn`t have profile, we register him and add him to the Lighter side.
//We remove DCay from Darker side and add him to Lighter side.
//We print only Lighter side because Darker side has no members.


