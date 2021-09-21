using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMashine = double.Parse(Console.ReadLine());
            double pricePerToy = double.Parse(Console.ReadLine());
            double moneyPresent = 10;
            double savedMoney = 0;
            int counterToys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += moneyPresent;
                    moneyPresent += 10;
                    savedMoney--;
                }
                else
                {
                    counterToys++;
                }
            }
            double totalMoney = savedMoney + counterToys * pricePerToy;

            if (priceWashingMashine <= totalMoney)
            {
                Console.WriteLine($"Yes! {(totalMoney - priceWashingMashine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceWashingMashine - totalMoney):f2}");
            }
        }
    }
}
