using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t09.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();
            switch (weather)
            {
                case "sunny": Console.WriteLine("It's warm outside!");break;
                default:
                    Console.WriteLine("It's cold outside!");
                    break;
            }
        }
    }
}
