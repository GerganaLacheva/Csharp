using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int qtyDrinks = int.Parse(Console.ReadLine());
            double price = 0;
            
            

            switch (drink)
            {
                case "Espresso":
                    switch (sugar)
                    {
                        case "Without":
                            price = 0.9*qtyDrinks*0.65;
                            break;
                        case "Normal":
                            price = qtyDrinks * 1;
                            break;
                        case "Extra":
                            price = qtyDrinks * 1.2;
                            break;

                    }
                    break;

                case "Cappuccino":
                    switch (sugar)
                    {
                        case "Without":
                            price = qtyDrinks *1.0*0.65;
                            break;
                        case "Normal":
                            price= qtyDrinks * 1.2;
                            break;
                        case "Extra":
                            price = qtyDrinks * 1.6;
                            break;
                    }
                    break;
                case "Tea":
                    switch (sugar)
                    {
                        case "Without":
                            price = qtyDrinks * 0.5*0.65;
                            break;
                        case "Normal":
                            price = qtyDrinks * 0.6;
                            break;
                        case "Extra":
                            price = qtyDrinks * 0.7;
                            break;
                    }
                    break;
            }
            if (drink== "Espresso" && qtyDrinks>=5)
            {
                price *= 0.75;
            }
            if (price>15)
            {
                price *= 0.8;
            }

            Console.WriteLine($"You bought {qtyDrinks} cups of {drink} for {price:f2} lv.");
        }
    }
}
