using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tae6.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricity = 0;
            double water = 0;
            double internet = 0;
            double average = 0;
            double othersTotal = 0;

            for (int i = 0; i < months; i++)
            {
                double electricityInput = double.Parse(Console.ReadLine());
                electricity += electricityInput;
                water += 20;
                internet += 15;
                double others = (electricity + water + internet) * 1.2;
                othersTotal = others;

            }
            average = (electricity + water + internet + othersTotal) / months;
            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {othersTotal:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
