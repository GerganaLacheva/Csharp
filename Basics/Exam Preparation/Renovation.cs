using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t05.Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            double highOfWall = int.Parse(Console.ReadLine());
            double lenghtOfWall = int.Parse(Console.ReadLine());
            double percentNoPainting = int.Parse(Console.ReadLine());

            double space = Math.Ceiling(highOfWall * lenghtOfWall * 4);
            space -= space * percentNoPainting / 100;

            string input = Console.ReadLine();

            while (input!="Tired!")
            {
                int paintLiters = int.Parse(input);
                space -= paintLiters;
                if (space==0)
                {
                    Console.WriteLine($"All walls are painted! Great job, Pesho!");
                    break;
                }
                else if (space<0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(space)} l paint left!");
                    break;
                }


                input = Console.ReadLine();
            }
            if (input=="Tired!")
            {
                Console.WriteLine($"{space} quadratic m left.");
            }
        }
    }
}
