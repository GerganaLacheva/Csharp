using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Разхода на зелената боя е 1 литър за 3.4 м2
            //Разхода на червената – 1 литър за 4.3 м2

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            
            double faceOfRoof = (x * h / 2) * 2 + x * y * 2;
            double faceOfHouse = (x * x * 2 - 1.2 * 2) + (x * y * 2 - 1.5 * 1.5 * 2);
            Console.WriteLine($"{faceOfHouse/3.4:f2}");
            Console.WriteLine($"{faceOfRoof/4.3:f2}");
        }
    }
}
