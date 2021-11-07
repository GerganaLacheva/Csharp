using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05.SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> output = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArguments = Console.ReadLine().Split();
                string task = commandArguments[0];
                string userName = commandArguments[1];

                if (task == "register")
                {
                    string licencePlateNumber = commandArguments[2];

                    if (!output.ContainsKey(userName))
                    {
                        output.Add(userName, licencePlateNumber);
                        Console.WriteLine($"{userName} registered {licencePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licencePlateNumber}");
                    }
                }
                else if (task == "unregister")
                {
                    if (!output.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        output.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
//5.SoftUni Parking
//SoftUni just got a new parking lot.It’s so fancy, it even has online parking validation. Except the online service doesn’t work. It can only receive users’ data, but it doesn’t know what to do with it. Good thing you’re on the dev team and know how to fix it, right?
//Write a program, which validates a parking place for an online service.Users can register to park and unregister to leave.
//The program receives 2 commands:	
//•	"register {username} {licensePlateNumber}":
//o The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print:
//"ERROR: already registered with plate number {licensePlateNumber}"
//o If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
// "{username} registered {licensePlateNumber} successfully"
//•	"unregister {username}":
//o If the user is not present in the database, the system should print:
//"ERROR: user {username} not found"
//o If the aforementioned check passes successfully, the system should print:
//"{username} unregistered successfully"
//After you execute all of the commands, print all the currently registered users and their license plates in the format: 
//•	"{username} => {licensePlateNumber}"
//Input
//•	First line: n - number of commands – integer
//•	Next n lines: commands in one of the two possible formats:
//o Register: "register {username} {licensePlateNumber}"
//o Unregister: "unregister {username}"
//The input will always be valid and you do not need to check it explicitly.
//Examples
//Input	
//5
//register John CS1234JS
//register George JAVA123S
//register Andy AB4142CD
//register Jesica VR1223EE
//unregister Andy	
    
//Output
//John registered CS1234JS successfully
//George registered JAVA123S successfully
//Andy registered AB4142CD successfully
//Jesica registered VR1223EE successfully
//Andy unregistered successfully
//John => CS1234JS
//George => JAVA123S
//Jesica => VR1223EE
