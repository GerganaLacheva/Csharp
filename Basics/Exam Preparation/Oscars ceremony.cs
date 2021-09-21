using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t01.Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double figurines = rent * 0.7;
            double catering = figurines * 0.85;
            double soundSystem = catering * 0.5;

            double totalExpenses = rent + figurines + catering + soundSystem;

            Console.WriteLine($"{totalExpenses:f2}");
        }
    }
}
