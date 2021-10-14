using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleOnQueue = int.Parse(Console.ReadLine());

            int[] lift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxCapacity = 4;

            bool noPeopleWaiting = false;

            for (int i = 0; i < lift.Length; i++)
            {
                int currentWagon = lift[i];

                if (peopleOnQueue - (maxCapacity - currentWagon) == 0)
                {
                    peopleOnQueue -= maxCapacity - currentWagon;
                    lift[i] = 4;
                    noPeopleWaiting = true;
                    break;
                }
                else if (peopleOnQueue - (maxCapacity - currentWagon) < 0)
                {
                    lift[i] = peopleOnQueue;
                    peopleOnQueue = 0;
                    noPeopleWaiting = true;
                    break;
                }
                else
                {
                    peopleOnQueue -= maxCapacity - currentWagon;
                    lift[i] = 4;
                }
            }

            bool emptyWagons = false;

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)
                {
                    emptyWagons = true;
                    break;
                }
            }

            if (noPeopleWaiting == true && emptyWagons == true)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", lift));

            }
            else if (peopleOnQueue > 0 && emptyWagons == false)
            {
                Console.WriteLine($"There isn't enough space! {peopleOnQueue} people in a queue!");
                Console.WriteLine(String.Join(" ", lift));
            }
            else if (peopleOnQueue == 0 && emptyWagons == false)
            {
                Console.WriteLine(String.Join(" ", lift));
            }
        }
    }
}

//Write a program that finds a place for the tourist on a lift. 
//Every wagon should have a maximum of 4 people on it. If a wagon is full, you should direct the people to the next one with space available.
//Input
//•	On the first line, you will receive how many people are waiting to get on the lift
//•	On the second line, you will receive the current state of the lift separated by a single space: " ".
//Output
//When there is no more available space left on the lift, or there are no more people in the queue, you should print on the console the final state of the lift's wagons separated by " " and one of the following messages:
//•	If there are no more people and the lift have empty spots, you should print:
//"The lift has empty spots!
//{ wagons separated by ' '}
//"
//•	If there are still people in the queue and no more available space, you should print:
//"There isn't enough space! {people} people in a queue!
//{ wagons separated by ' '}
//"
//•	If the lift is full and there are no more people in the queue, you should print only the wagons separated by " "
//Examples
//Input	Output
//15
//0 0 0 0	The lift has empty spots!
//4 4 4 3
//Comment
//First state - 4 0 0 0 -> 11 people left
//Second state – 4 4 0 0 -> 7 people left
//Third state – 4 4 4 0 -> 3 people left
//Input	Output
//20
//0 2 0	There isn't enough space! 10 people in a queue!
//4 4 4
//Comment
//First state - 4 2 0  -> 16 people left
//Second state – 4 4 0  -> 14 people left
//Third state – 4 4 4 -> 10 people left, but there're no more wagons.
