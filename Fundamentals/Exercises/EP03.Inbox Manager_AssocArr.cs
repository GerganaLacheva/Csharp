using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Inbox_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, List<string>> users=new Dictionary<string, List<string>>();

            string command=Console.ReadLine();

            while (command!="Statistics")
            {
                var split=command.Split("->");
                
                if (command.Contains("Add"))
                {
                    if (users.ContainsKey(split[1]))
                    {
                        Console.WriteLine($"{split[1]} is already registered");
                    }
                    else
                    {
                        users.Add(split[1], new List<string>());
                    }
                }
                if (command.Contains("Send"))
                {
                    string username = split[1];
                    string email=split[2];
                    users[username].Add(email);
                }

                if (command.Contains("Delete"))
                {
                    string username=split[1];
                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");

            var sortedUsers=users.OrderByDescending(x => x.Value.Count).ThenBy(x=>x.Key).ToList();

            foreach (var user in sortedUsers)
            {
                Console.WriteLine($"{user.Key}");
                for (int i = 0; i < user.Value.Count; i++)
                {
                    Console.WriteLine($" - {user.Value[i]}");
                }
            }
        }
    }
}
//Input
//Add ->Mike
//Add->George
//Send->George->Hello World
//Send->George->Some random test mail
//Send->Mike->Hello, do you want to meet up tomorrow?
//Send->George->It would be a pleasure
//Send->Mike->Another random test mail
//Statistics
//
//Output
//Users count:2
//George
// - Hello World
// - Some random test mail
// - It would be a pleasure
//Mike
// - Hello, do you want to meet up tomorrow?
// - Another random test mail

