using System;
using System.Collections.Generic;

namespace EX10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightSec = int.Parse(Console.ReadLine());
            int freeWindowSec = int.Parse(Console.ReadLine());

            Queue<string> carQueue = new Queue<string>();

            int totalCarsPassed = 0;

            while (true)
            {
                string input = Console.ReadLine();
                int currGreenLightSec = greenLightSec;
                int currFreeWindowSec = freeWindowSec;

                if (input == "END")
                {
                    Console.WriteLine($"Everyone is safe.");
                    Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
                    return;
                }
                if (input == "green")
                {
                    while (currGreenLightSec > 0 && carQueue.Count != 0)
                    {
                        string currCar = carQueue.Dequeue();
                        currGreenLightSec -= currCar.Length;
                        if (currGreenLightSec > 0)
                        {
                            totalCarsPassed++;
                        }
                        else
                        {
                            currFreeWindowSec += currGreenLightSec;
                            if (currFreeWindowSec < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currCar} was hit at {currCar[currCar.Length + currFreeWindowSec]}.");
                                return;
                            }
                            totalCarsPassed++;
                        }
                    }
                }
                else
                {
                    carQueue.Enqueue(input);
                }

            }
        }
    }
}
//Crossroads
//Our favorite super-spy action hero Sam is back from his mission in the previous exam, and he has finally found some time to go on a holiday. He is taking his wife somewhere nice and they’re going to have a really good time, but first, they have to get there. Even on his holiday trip, Sam is still going to run into some problems and the first one is, of course, getting to the airport. Right now, he is stuck in a traffic jam at a very active crossroads where a lot of accidents happen.
//Your job is to keep track of traffic at the crossroads and report whether a crash happened or everyone passed the crossroads safely and our hero is one step closer to a much desired vacation.
//The road Sam is on has a single lane where cars queue up until the light goes green. When it does, they start passing one by one during the green light and the free window before the intersecting road’s light goes green. During one second only one part of a car (a single character) passes the crossroads. If a car is still in the crossroads when the free window ends, it will get hit at the first character that is still in the crossroads.
//Input
//•	On the first line, you will receive the duration of the green light in seconds – an integer in the range [1-100]
//•	On the second line, you will receive the duration of the free window in seconds – an integer in the range [0-100]
//•	On the following lines, until you receive the "END" command, you will receive one of two things:
//	A car – a string containing any ASCII character, or
//	The command "green" which indicates the start of a green light cycle
//A green light cycle goes as follows:
//•	During the green light cars will enter and exit the crossroads one by one
//•	During the free window cars will only exit the crossroads
//Output
//•	If a crash happens, end the program and print:
//"A crash happened!"
//"{car} was hit at {characterHit}."
//•	If everything goes smoothly and you receive an "END" command, print:
//"Everyone is safe."
//"{totalCarsPassed} total cars passed the crossroads."
//Constraints
//•	The input will be within the constaints specified above and will always be valid. There is no need to check it explicitly.
//Examples
//Input		
//10
//5
//Mercedes
//green
//Mercedes
//BMW
//Skoda
//green
//END	
//
//Output
//Everyone is safe.
//3 total cars passed the crossroads.	
//
//Comments
//During the first green light (10 seconds), the Mercedes(8) passes safely.
//During the second green light, the Mercedes (8) passes safely and there are 2 seconds left.
//The BMW enters the crossroads and when the green light ends, it still has 1 part inside ('W'), but has 5 seconds to leave and
//passes successfully.
//The Skoda never enters the crossroads, so 3 cars passed successfully.
//
//Input
//9
//3
//Mercedes
//Hummer
//green
//Hummer
//Mercedes
//green
//END	
//
//Output
//A crash happened!
//Hummer was hit at e.	
//
//Comments
//Mercedes (8) passes successfully and Hummer (6) enters the crossroads but only the 'H' passes during the
//green light. There are 3 seconds of free window, so "umm" passes and the Hummer gets hit at 'e' and the program ends with a crash.

