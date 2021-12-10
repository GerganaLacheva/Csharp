using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());

            Queue<string> game = new Queue<string>(children);

            while (game.Count>1)
            {
                for (int i = 1; i < n; i++)
                {
                    game.Enqueue(game.Dequeue());   //добави в опашката това, което си махнал от нея
                }
                Console.WriteLine($"Removed {game.Dequeue()}");
            }
            Console.WriteLine($"Last is {game.Dequeue()}");
        }
    }
}
//7.Hot Potato
//Hot potato is a game in which children form a circle and start passing a hot potato. The counting starts with the fist kid. Every nth toss the child left with the potato leaves the game. When a kid leaves the game, it passes the potato along. This continues until there is only one kid left.
//Create a program that simulates the game of Hot Potato.  Print every kid that is removed from the circle. In the end, print the kid that is left last.
//Examples
//Input	
//Alva James William
//2	
//
//Output
//Removed James
//Removed Alva
//Last is William
//
//Input
//Lucas Jacob Noah Logan Ethan
//10	
//
//Output
//Removed Ethan
//Removed Jacob
//Removed Noah
//Removed Lucas
//Last is Logan
//
//Input
//Carter Dylan Jack Luke Gabriel
//1	
//
//Output
//Removed Carter
//Removed Dylan
//Removed Jack
//Removed Luke
//Last is Gabriel
