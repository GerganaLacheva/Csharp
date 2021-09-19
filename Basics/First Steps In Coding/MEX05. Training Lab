using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ограничения: 3 ≤ h ≤ w ≤ 100.
            double w = double.Parse(Console.ReadLine());//дължина в метри
            double h = double.Parse(Console.ReadLine());//широчина в метри

            double hWithoutCorridor = h - 1;
            double numberOfRows = Math.Floor(w / 1.2);
            double numberOfColumns = Math.Floor(hWithoutCorridor / 0.7);

            double numberOfWorkingStations = numberOfRows*numberOfColumns-3;
            Console.WriteLine(Math.Floor(numberOfWorkingStations));
        }
    }
}
