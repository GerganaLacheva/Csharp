using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."
            //Изготвянето на един проект отнема три часа.

            //George - name
            //4 - projects

            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int hoursNeeded = 3;
            int result = projects * hoursNeeded;

            Console.WriteLine($"The architect {name} will need {result} hours to complete {projects} project/s.");
        }
    }
}
