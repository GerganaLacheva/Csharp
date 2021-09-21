using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            double dryMaterials = double.Parse(Console.ReadLine());

            double capacityAquarium = lenght * depth * high;
            double capacityAquariumLiters = capacityAquarium * 0.001;
            double netOfDryMaterial = capacityAquariumLiters*(1-dryMaterials / 100);

            Console.WriteLine(netOfDryMaterial);
        }
    }
}
