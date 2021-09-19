using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string location = Console.ReadLine();
            double qtySales = double.Parse(Console.ReadLine());

            if (qtySales>=0)
            {
                switch (location)
                {
                    case "Sofia":
                        if (qtySales >= 0 && qtySales <= 500)
                        {
                            Console.WriteLine($"{qtySales * 0.05:f2}");
                        }
                        else if (qtySales > 500 && qtySales <= 1000)
                        {
                            Console.WriteLine($"{qtySales * 0.07:f2}");
                        }
                        else if (qtySales > 1000 && qtySales <= 10000)
                        {
                            Console.WriteLine($"{qtySales * 0.08:f2}");
                        }

                        else if (qtySales > 10000)
                        {
                            Console.WriteLine($"{qtySales * 0.12:f2}");
                        }
                        break;

                    case "Varna":
                        if (qtySales >= 0 && qtySales <= 500)
                        {
                            Console.WriteLine($"{qtySales * 0.045:f2}");
                        }
                        else if (qtySales > 500 && qtySales <= 1000)
                        {
                            Console.WriteLine($"{qtySales * 0.075:f2}");
                        }
                        else if (qtySales > 1000 && qtySales <= 10000)
                        {
                            Console.WriteLine($"{qtySales * 0.10:f2}");
                        }

                        else if (qtySales > 10000)
                        {
                            Console.WriteLine($"{qtySales * 0.13:f2}");
                        }
                        break;

                    case "Plovdiv":
                        if (qtySales >= 0 && qtySales <= 500)
                        {
                            Console.WriteLine($"{qtySales * 0.055:f2}");
                        }
                        else if (qtySales > 500 && qtySales <= 1000)
                        {
                            Console.WriteLine($"{qtySales * 0.08:f2}");
                        }
                        else if (qtySales > 1000 && qtySales <= 10000)
                        {
                            Console.WriteLine($"{qtySales * 0.12:f2}");
                        }

                        else if (qtySales > 10000)
                        {
                            Console.WriteLine($"{qtySales * 0.145:f2}");
                        }
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
