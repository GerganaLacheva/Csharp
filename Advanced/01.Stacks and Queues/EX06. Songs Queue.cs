using System;
using System.Linq;
using System.Collections.Generic;

namespace EX06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);


            while (queue.Count > 0)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "Play": queue.Dequeue(); break;
                    case "Show": Console.WriteLine(string.Join(", ", queue)); break;
                    default:
                        int commandAdd = command.IndexOf(" ");
                        string song = command.Substring(commandAdd+1);
                        if (queue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            queue.Enqueue(song);
                        }
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
//6.Songs Queue
//Write a program that keeps track of a songs queue. The first song that is put in the queue, should be the first that gets played. A song cannot be added if it is currently in the queue.
//You will be given a sequence of songs, separated by a comma and a single space. After that you will be given commands until there are no songs enqueued. When there are no more songs in the queue print "No more songs!" and stop the program.
//The possible commands are:
//•	"Play" - plays a song(removes it from the queue)
//•	"Add {song}" - adds the song to the queue if it isn’t contained already, otherwise print "{song} is already contained!"
//•	"Show" - prints all songs in the queue separated by a comma and a white space (start from the first song in the queue to the last)
//Input
//•	On the first line, you will be given a sequence of strings, separated by a comma and a white space
//•	On the next lines you will be given commands until there are no songs in the queue
//Output
//•	While receiving the commands, print the proper messages described above
//•	After the command "Show", print the songs from the first to the last
//Constraints
//•	The input will always be valid and in the formats described above
//•	There might be commands even after there are no songs in the queue (ignore them)
//•	There will never be duplicate songs in the initial queue
//Examples
//Input	
//All Over Again, Watch Me
//Play
//Add Watch Me
//Add Love Me Harder
//Add Promises
//Show
//Play
//Play
//Play
//Play	
//
//Output
//Watch Me is already contained!
//Watch Me, Love Me Harder, Promises
//No more songs!
