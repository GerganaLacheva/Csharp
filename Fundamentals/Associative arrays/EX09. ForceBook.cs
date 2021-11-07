using System;
using System.Collections.Generic;
using System.Linq;

namespace _09ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, List<string>>();
            var forceUsers = new List<string>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.IndexOf(" | ") >= 0)
                {
                    string[] tokens = input.Split(" | ");
                    string forceSide = tokens[0];
                    string forceUser = tokens[1];

                    if (!forceUsers.Contains(forceUser))
                    {
                        if (!database.ContainsKey(forceSide))
                        {
                            database.Add(forceSide, new List<string>() { forceUser });
                        }
                        else
                        {
                            database[forceSide].Add(forceUser);
                        }
                    }

                    forceUsers.Add(forceUser);
                }
                else
                {
                    string[] tokens = input.Split(" -> ");
                    string forceUser = tokens[0];
                    string forceSide = tokens[1];

                    // change sides
                    if (forceUsers.Contains(forceUser))
                    {
                        string userCurrentSide = string.Empty;
                        foreach (var key in database.Keys)
                        {
                            if (database[key].Contains(forceUser))
                            {
                                userCurrentSide = key;
                                break;
                            }
                        }

                        if (!database.ContainsKey(forceSide))
                        {
                            database[forceSide] = new List<string>();
                        }
                        database[userCurrentSide].Remove(forceUser);
                        database[forceSide].Add(forceUser);
                    }
                    else
                    {
                        if (!database.ContainsKey(forceSide))
                        {
                            database.Add(forceSide, new List<string>() { forceUser });
                        }
                        else
                        {
                            database[forceSide].Add(forceUser);
                        }
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    if (!forceUsers.Contains(forceUser))
                    {
                        forceUsers.Add(forceUser);
                    }
                }
            }


            foreach (var item in database.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                string forceSide = item.Key;
                var members = item.Value;
                if (members.Count > 0)
                {
                    Console.WriteLine($"Side: {forceSide}, Members: {members.Count}");
                    foreach (var member in members.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {member}");
                    }
                }
            }
        }
    }
}
//ForceBook
//The force users are struggling to remember which side is the different forceUsers from because they switch them too often. So you are tasked to create a web application to manage their profiles. You should store an information for every unique forceUser, registered in the application.
//You will receive several input lines in one of the following formats:
//{forceSide} | {forceUser}
//{forceUser} -> {forceSide}
//The forceUser and forceSide are strings, containing any character. 
//If you receive forceSide | forceUser, you should check if such forceUser already exists, and if not, add him/her to the corresponding side. 
//If you receive a forceUser -> forceSide, you should check if there is such a forceUser already and if so, change his/her side. If there is no such forceUser, add him/her to the corresponding forceSide, treating the command as a newly registered forceUser.
//Then you should print on the console: "{forceUser} joins the {forceSide} side!" 
//You should end your program when you receive the command "Lumpawaroo". At that point, you should print each force side, ordered descending by forceUsers count then ordered by name. For each side print the forceUsers, ordered by name.
//In case there are no forceUsers in the side, you shouldn`t print the side information. 
//Input / Constraints
//•	The input comes in the form of commands in one of the formats specified above.
//•	The input ends, when you receive the command "Lumpawaroo".
//Output
//•	As output for each forceSide, ordered descending by forceUsers count, then by name,  you must print all the forceUsers, ordered by name alphabetically.
//•	The output format is:
//"Side: {forceSide}, Members: {forceUsers.Count}"
//"! {forceUser}"
//"! {forceUser}"
//"! {forceUser}"
//•	In case there are NO forceUsers, don`t print this side. 
//Examples
//Input	Output	Comments
//Light | George
//Dark | Peter
//Lumpawaroo	Side: Dark, Members: 1
//! Peter
//Side: Light, Members: 1
//! George	We register George in the Light side and Pesho in the Dark side. After receiving "Lumpawaroo" we print both sides, ordered by membersCount and then by name.
