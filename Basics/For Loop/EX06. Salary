using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te6.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FACEBOOK = 150;
            const int INSTAGRAM = 100;
            const int REDDIT = 50;

            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i <= tabs; i++)
            {
                if (salary<=0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    break;
                }
            string site = Console.ReadLine();

                if (site== "Facebook")
                {
                    salary -= FACEBOOK;
                }
                else if (site== "Instagram")
                {
                    salary -= INSTAGRAM;
                }
                else if (site== "Reddit")
                {
                    salary -= REDDIT;
                }
            }
            if (salary>0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
