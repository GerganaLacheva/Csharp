using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int qtyFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double moneyForFlowers = 0;

            switch (flowerType)
            {
                case "Roses":
                    moneyForFlowers = qtyFlowers * 5; 
                    if (qtyFlowers>80)
                    {
                        moneyForFlowers *= 0.90;
                    }
                    break;
                case "Dahlias": 
                    moneyForFlowers = qtyFlowers * 3.80;
                    if (qtyFlowers > 90)
                    {
                        moneyForFlowers *= 0.85;
                    }
                    break;
                case "Tulips": 
                    moneyForFlowers = qtyFlowers * 2.80;
                    if (qtyFlowers > 80)
                    {
                        moneyForFlowers *= 0.85;
                    }
                    break;
                case "Narcissus": 
                    moneyForFlowers = qtyFlowers * 3;
                    if (qtyFlowers < 120)
                    {
                        moneyForFlowers *= 1.15;
                    }
                    break;
                case "Gladiolus": 
                    moneyForFlowers = qtyFlowers * 2.50;
                    if (qtyFlowers < 80)
                    {
                        moneyForFlowers *= 1.20;
                    }
                    break;
            }
            if (moneyForFlowers<=budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {qtyFlowers} {flowerType} and {(budget-moneyForFlowers):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(moneyForFlowers-budget):f2} leva more.");
            }
        }
    }
}
