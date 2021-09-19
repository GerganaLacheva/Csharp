using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tae2.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i%3==0 && untreatedPatients>treatedPatients)
                {
                    doctors++;
                }

                int patients = int.Parse(Console.ReadLine());

                if (patients==doctors)
                {
                    treatedPatients += doctors;
                }
                else if (patients>doctors)
                {
                    treatedPatients += doctors;
                    patients -= doctors;
                    untreatedPatients += patients;
                }
                else 
                {
                    treatedPatients +=patients;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
