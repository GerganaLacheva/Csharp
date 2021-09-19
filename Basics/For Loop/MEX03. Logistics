using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tae3.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLoads = int.Parse(Console.ReadLine());

            double pricePerToneMinibus = 0;
            double pricePerToneTruck = 0;
            double pricePerToneTrain = 0;
            double totalWeightMinibus = 0;
            double totalWeghtTruck = 0;
            double totalWeightTrain = 0;
            double totalTonage = 0;

            for (int i = 1; i <= numberOfLoads; i++)
            {

                int tonagePerLoad = int.Parse(Console.ReadLine());
                totalTonage += tonagePerLoad;

                if (tonagePerLoad<=3)
                {
                    totalWeightMinibus += tonagePerLoad;
                    pricePerToneMinibus += tonagePerLoad * 200;
                }
                if (tonagePerLoad>3 && tonagePerLoad<=11)
                {
                    totalWeghtTruck += tonagePerLoad;
                    pricePerToneTruck += tonagePerLoad *175;
                }
                if (tonagePerLoad>11)
                {
                    totalWeightTrain += tonagePerLoad;
                    pricePerToneTrain += tonagePerLoad * 120;
                }

            }
            double averagePrice = (pricePerToneMinibus + pricePerToneTrain + pricePerToneTruck) / totalTonage;
            double conv1 = totalWeightMinibus / totalTonage * 100;
            double conv2 = totalWeghtTruck / totalTonage * 100;
            double conv3 = totalWeightTrain / totalTonage * 100;
            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{conv1:f2}%");
            Console.WriteLine($"{conv2:f2}%");
            Console.WriteLine($"{conv3:f2}%");


        }
    }
}
