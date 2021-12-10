using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            Queue<string> queue = new Queue<string>();
            int countCarsPassed = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            countCarsPassed++;
                        }
                        else
                        {
                            break;//ако не са останали коли в опашката брейкваме, за да не въртим излишни итерации до n
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"{countCarsPassed} cars passed the crossroads.");
        }
    }
}
//8.Traffic Jam
//Create a program that simulates the queue that forms during a traffic jam. During a traffic jam only N cars can pass the crossroads when the light goes green. Then the program reads the vehicles that arrive one by one and adds them to the queue. When the light goes green N number of cars pass the crossroads and for each a message "{car} passed!" is displayed. When the "end" command is given, terminate the program and display a message with the total number of cars that passed the crossroads.
//Input
//•	On the first line you will receive N – the number of cars that can pass during a green light
//•	On the next lines, until the "end" command is given, you will receive commands – a single string, either a car or "green"
//Output
//•	Every time the "green" command is given, print out a message for every car that passes the crossroads in the format "{car} passed!"
//•	When the "end" command is given, print out a message in the format "{number of cars} cars passed the crossroads."
//Examples
//Input	
//4
//Hummer H2
//Audi
//Lada
//Tesla
//Renault
//Trabant
//Mercedes
//MAN Truck
//green
//green
//Tesla
//Renault
//Trabant
//end	
//
//Output
//Hummer H2 passed!
//Audi passed!
//Lada passed!
//Tesla passed!
//Renault passed!
//Trabant passed!
//Mercedes passed!
//MAN Truck passed!
//8 cars passed the crossroads.
//
//Input
//3
//Enzo's car
//Jade's car
//Mercedes CLS
//Audi
//green
//BMW X5
//green
//end	
//
//Output
//Enzo's car passed!
//Jade's car passed!
//Mercedes CLS passed!
//Audi passed!
//BMW X5 passed!
//5 cars passed the crossroads.
