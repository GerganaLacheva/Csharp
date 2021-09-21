using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtyJoinery = int.Parse(Console.ReadLine());
            string size = Console.ReadLine();
            string delivery = Console.ReadLine();

            double singlePrice = 0;
            double totalPrice = 0;

            if (qtyJoinery < 10 )
            {
                Console.WriteLine($"Invalid order");
            }
            else
            {

                switch (size)
                {
                    case "90X130":

                        if (qtyJoinery > 60)
                        {
                            singlePrice = 110 * 0.92;
                        }
                        else if (qtyJoinery > 30)
                        {
                            singlePrice = 110 * 0.95;
                        }
                        else if (qtyJoinery >= 10)
                        {
                            singlePrice = 110;
                        }
                        break;
                    case "100X150":
                        if (qtyJoinery > 80)
                        {
                            singlePrice = 140 * 0.9;
                        }
                        else if (qtyJoinery > 40)
                        {
                            singlePrice = 140 * 0.94;
                        }
                        else if (qtyJoinery >= 10)
                        {
                            singlePrice = 140;
                        }
                        break;
                    case "130X180":
                        if (qtyJoinery > 50)
                        {
                            singlePrice = 190 * 0.88;
                        }
                        else if (qtyJoinery > 20)
                        {
                            singlePrice = 190 * 0.93;
                        }
                        else if (qtyJoinery >= 10)
                        {
                            singlePrice = 190;
                        }
                        break;
                    case "200X300":
                        if (qtyJoinery > 50)
                        {
                            singlePrice = 250 * 0.86;
                        }
                        else if (qtyJoinery > 25)
                        {
                            singlePrice = 250 * 0.91;
                        }
                        else if (qtyJoinery >= 10)
                        {
                            singlePrice = 250;
                        }
                        break;
                }
                totalPrice = singlePrice * qtyJoinery;
                if (delivery == "With delivery")
                {
                    totalPrice += 60;
                }
                if (qtyJoinery > 99)
                {
                    totalPrice *= 0.96;
                }

                Console.WriteLine($"{totalPrice:f2} BGN");
            }

        }
    }
}
