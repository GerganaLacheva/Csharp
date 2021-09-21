using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int cakePieces = lenght * width;

            while (cakePieces>0)
            {
                string input = Console.ReadLine();
                if (input=="STOP")
                {
                    break;
                }
                int pieces = int.Parse(input);
                cakePieces -= pieces;
            }
            if (cakePieces>=0)
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }

        }
    }
}
