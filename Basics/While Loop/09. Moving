using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widht = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int freeSpace = widht * lenght * hight;
            string command = Console.ReadLine();

            while (command!="Done")
            {
                freeSpace -= int.Parse(command);
                if (freeSpace<=0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (freeSpace>0)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
