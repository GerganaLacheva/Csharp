using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double degrees = rad * 180 / Math.PI;
            Console.WriteLine(Math.Round(degrees));

        }
    }
}
