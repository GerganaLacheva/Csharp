using System;
using System.Linq;
using System.Collections.Generic;

namespace EX01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPassangers = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                //["Add", "10"] - получаваме команда от два елемента, които ще бъдат от тип string; "Add" е с индекс [0], a "10" е с индекс [1]
                string[] commandAgruments = command.Split(); //тъй като можем да получим команда с повече от един аргумент, разделяме командата на части

                if (commandAgruments[0] == "Add")     //ако командата е от два аргумента
                {
                    int passangers = int.Parse(commandAgruments[1]);    //ако получим конада Add четем индекс [1] от нея като брой пътници
                    wagons.Add(passangers);     //добавяме нов вагон с пътници, който се добавя на края на листа.
                                                //В условието не е указан случай, в който получаваме вагон с повече от макс.капацитет пътници
                }

                else                            //ако командата е от един аргумент
                {
                    int passangers = int.Parse(commandAgruments[0]);    //четем индекс [0], защото командата с брой пътници е само от един аргумент

                    for (int i = 0; i < wagons.Count; i++)      //с for обхождаме всички вагони, за да проверим дали има свободни места за новите пътници
                    {
                        if (wagons[i] + passangers <= maxPassangers)              //wagons[i] е настоящият вагон
                        {
                            wagons[i] += passangers;            //ако условието е вярно, добавяме новите пътници в настоящия вагон
                            break;                              //прекъсваме изпълнението веднага щом намерим вагон, в който да поберем новите пътници
                        }
                    }
                }
            command = Console.ReadLine();       //четем всеки път нов вход докато не получим конада "end"
            }

            Console.WriteLine(string.Join(" ", wagons)); //принтираме новите вагони след изпълнението на командите
        }

    }
}
