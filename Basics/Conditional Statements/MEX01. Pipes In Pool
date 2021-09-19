using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double pipe1 = double.Parse(Console.ReadLine());
            double pipe2= double.Parse(Console.ReadLine());
            double hours= double.Parse(Console.ReadLine());

            double water = pipe1 * hours + pipe2 * hours;

            if (volume>=water)
            {
                Console.WriteLine($"The pool is {water/volume*100:f2}% full. Pipe 1: {pipe1*hours/water*100:f2}%. Pipe 2: {pipe2*hours/water*100:f2}%.");
            }
            else if (volume<water)
            {
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {(water-volume):f2} liters.");
            }
        }
    }
}
