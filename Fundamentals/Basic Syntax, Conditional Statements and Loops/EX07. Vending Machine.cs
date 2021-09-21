using System;

namespace EX07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalMoney = 0;
            double productPrice = 0;

            while (command != "Start")
            {
                double insertedMoney = double.Parse(command);

                if (insertedMoney == 0.1 || insertedMoney == 0.2 || insertedMoney == 0.5 || insertedMoney == 1 || insertedMoney == 2)
                {
                    totalMoney += insertedMoney;

                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertedMoney}");
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts": productPrice = 2; break;
                    case "Water": productPrice = 0.7; break;
                    case "Crisps": productPrice = 1.5; break;
                    case "Soda": productPrice = 0.8; break;
                    case "Coke": productPrice = 1; break;
                    default:
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        continue;
                }

                if (productPrice <= totalMoney)
                {
                    totalMoney -= productPrice;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
//7.Vending Machine
//Until you receive "Start" you will be given different coins that are being inserted into the machine. You have to sum them to have the total money inserted. There is a problem though. 
//Your vending machine only works with 0.1, 0.2, 0.5, 1, and 2 coins. If someone tries to insert some other coins you have to display "Cannot accept {money}" and not add it to the total money. 
//On the next few lines until you receive "End" you will be given products to purchase. Your machine has however only "Nuts", "Water", "Crisps", "Soda", "Coke". The prices are: 2.0, 0.7, 1.5, 0.8, 1.0 respectively.If the person tries to purchase a not existing product print "Invalid product". 
//Be careful that the person may try to purchase a product they don’t have the money for. In that case, print "Sorry, not enough money". If the person purchases a product successfully print "Purchased {product name}". 
//After the "End" command print the money that is left formatted to the second decimal point in the format "Change: {money left}".
//Examples
//Input	Output
//1
//1
//0.5
//0.6
//Start
//Coke
//Soda
//Crisps
//End	Cannot accept 0.6
//Purchased coke
//Purchased soda
//Sorry, not enough money
//Change: 0.70
//1
//Start
//Nuts
//Coke
//End	Sorry, not enough money
//Purchased coke
//Change: 0.00
