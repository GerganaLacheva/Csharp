using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalPrice = 0;
            double taxes = 0;
            

            while (command != "special" && command != "regular")
            {
                double inputPrice = double.Parse(command);

                if (inputPrice <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }
                        totalPrice += inputPrice;
                        taxes += inputPrice * 0.2;
                

                command = Console.ReadLine();
            }
            if (totalPrice <= 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else if (command== "regular")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice*1.2:f2}$");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice * 1.2*0.9:f2}$");
            }
        }
    }
}
//Write a program that prints you a receipt for your new computer.You will receive the parts' prices (without tax) until you receive what type of customer this is - special or regular. Once you receive the type of customer you should print the receipt.
//The taxes are 20% of each part's price you receive. 
//If the customer is special, he has a 10% discount on the total price with taxes.
//If a given price is not a positive number, you should print "Invalid price!" on the console and continue with the next price.
//If the total price is equal to zero, you should print "Invalid order!" on the console.
//Input
//•	You will receive numbers representing prices (without tax) until command "special" or "regular":
//Output
//•	The receipt should be in the following format: 
//"Congratulations you've just bought a new computer!
//Price without taxes: { total price without taxes}$
//Taxes: { total amount of taxes}$
//-----------
//Total price: { total price with taxes}
//$"
//Note: All prices should be displayed to the second digit after the decimal point! The discount is applied only on the total price. Discount is only applicable to the final price!
//Examples
//Input	
//1050
//200
//450
//2
//18.50 
//16.86 
//special
    
//Output
//Congratulations you've just bought a new computer!
//Price without taxes: 1737.36$
//Taxes: 347.47$
//-----------
//Total price: 1876.35$
//Input 
//1023 
//15
//-20
//-5.50
//450
//20 
//17.66 
//19.30
//regular

//Output
//Invalid price!
//Invalid price!
//Congratulations you've just bought a new computer!
//Price without taxes: 1544.96$
//Taxes: 308.99$
//-----------
//Total price: 1853.95$
//https://judge.softuni.org/Contests/Practice/Index/2517#0
