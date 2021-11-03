using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtySongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < qtySongs; i++)
            {
                string[] input = Console.ReadLine().Split( '_');
                string type = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }
            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                    else if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                    else if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
        class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
//3.Songs
//Define a class called Song that will hold the following information about some songs:
//•	Type List
//•	Name
//•	Time
//Input / Constraints
//•	On the first line, you will receive the number of songs - N.
//•	On the next N lines, you will be receiving data in the following format:  "{typeList}_{name}_{time}"
//•	On the last line, you will receive Type List or "all".
//Output
//If you receive Type List as an input on the last line, print out only the names of the songs which are from that Type List. If you receive the "all" command, print out the names of all the songs.
//Examples

//Input	Output
//3
//favourite_DownTown_3:14
//favourite_Kiss_4: 16
//favourite_Smooth Criminal_4:01
//favourite DownTown
//Kiss
//Smooth Criminal
