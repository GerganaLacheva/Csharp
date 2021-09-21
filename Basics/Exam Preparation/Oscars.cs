using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t05.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int numOfJudges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfJudges; i++)
            {
                string juryName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());

                pointsFromAcademy+= juryName.Length*juryPoints/ 2;
                if (pointsFromAcademy>1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsFromAcademy:f1}!");
                    break;
                }
            }
            if (pointsFromAcademy<=1250.5)
            {
                    Console.WriteLine($"Sorry, {actorName} you need {1250.5-pointsFromAcademy:f1} more!");
            }
        }
    }
}
