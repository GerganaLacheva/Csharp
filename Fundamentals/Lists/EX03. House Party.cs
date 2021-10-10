using System;
using System.Collections.Generic;
using System.Linq;

namespace EX03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();                   //създаваме си един празен лист, в който ще добавяме/изтриваме гости

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandParts = Console.ReadLine().Split();     //директно разделяме командата на части при прочитането, тъй като не е необходимо да пазим частите във временен масив
                                                                        //по условие командата може да има 3 или 4 части {name} is going = 3части, {name} is not going = 4 части

                string guestName = commandParts[0];                     //името на госта винаги е на индекс [0] във входа

                if (commandParts.Length == 4)
                {
                    if (guests.Contains(guestName))                     //проверяваме дали гостът вече присъства в списъка
                    {
                        guests.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }


                    //горните две проверки дублират итерациите, 
                    //първо преминаваме през целия списък, за да проверим дали се съдържа, 
                    //след това обхождаме отново целия списък, за да го премахнем
                    //за да избегнем повтарящите се итерации можем да създадем bool
                    //bool removed=guests.Remove(guestName);
                    //if (!removed)
                    //{Console.WriteLine($"{guestName} is not in the list!");} 

                }
                else if (commandParts.Length == 3)
                {
                    if (guests.Contains(guestName))                     //проверяваме дали гостът вече присъства в списъка
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                    else
                    {
                        guests.Add(guestName);                          //ако не е фигурирал в списъка, го добавяме
                    }
                }

            }
                foreach (var guestname in guests)
                {
                    Console.WriteLine(guestname);
                }
        }
    }
}
//3.House Party
//Create a program that keeps track of the guests that are going to a house party. On the first line of input, you are going to receive the number of commands that will follow.
//On the next lines, you are going to receive some of the following:  "{name} is going!"
//•	You have to add the person if they are not in the guest list already.
//•	If the person is on the list print to the following to the console: "{name} is already in the list!"
//"{name} is not going!"
//•	You have to remove the person if they are in the list. 
//•	If not, print out: "{name} is not in the list!"
//Finally, print all of the guests, each on a new line.
//Examples
//Input                         Output
//4
//Allie is going!
//George is going!
//John is not going!
//George is not going!          John is not in the list!
//                              Allie
//
//5
//Tom is going!
//Annie is going!
//Tom is going!
//Garry is going!
//Jerry is going!	            Tom is already in the list!
//                              Tom
//                              Annie
//                              Garry
//                              Jerry
