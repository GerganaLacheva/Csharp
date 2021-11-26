using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP03.Need_for_Speed_III
{
    class Car
    {
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|');
                
                cars.Add(input[0], new Car()
                {
                    Mileage = int.Parse(input[1]),
                    Fuel = int.Parse(input[2])
                }) ; 
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] splittedCommands = command.Split(" : ");

                if (splittedCommands[0] == "Drive")
                {
                    string car = splittedCommands[1];
                    int distance = int.Parse(splittedCommands[2]);
                    int fuel = int.Parse(splittedCommands[3]);

                   Car carData = cars[car];
                    if (carData.Fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[car].Mileage += distance;
                        cars[car].Fuel -= fuel;

                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (cars[car].Mileage >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            cars.Remove(car);
                        }
                    }
                }
                if (splittedCommands[0] == "Refuel")
                {
                    string car = splittedCommands[1];
                    int fuel = int.Parse(splittedCommands[2]);
                    int oldFuel = cars[car].Fuel;
                    cars[car].Fuel += fuel;

                    if (cars[car].Fuel > 75)
                    {
                        cars[car].Fuel = 75;
                        Console.WriteLine($"{car} refueled with {75 - oldFuel} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }

                }
                if (splittedCommands[0] == "Revert")
                {
                    string car = splittedCommands[1];
                    int distance = int.Parse(splittedCommands[2]);
                    cars[car].Mileage -= distance;

                    if (cars[car].Mileage < 10000)
                    {
                        cars[car].Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {distance} kilometers");
                    }
                }

                command = Console.ReadLine();
            }

            cars = cars.OrderByDescending(c => c.Value.Mileage).ThenBy(c => c.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }
    }
}
//Problem 3 - Need for Speed III
//Problem for exam preparation for the Programming Fundamentals Course @SoftUni.
//Submit your solutions in the SoftUni judge system at https://judge.softuni.org/Contests/Practice/Index/2307#2.

//You have just bought the latest and greatest computer game – Need for Seed III. Pick your favorite cars and drive them all you want! We know that you can't wait to start playing.
//On the first line of the standard input, you will receive an integer n – the number of cars that you can obtain.On the next n lines, the cars themselves will follow with their mileage and fuel available, separated by "|" in the following format:
//"{car}|{mileage}|{fuel}"
//Then, you will be receiving different commands, each on a new line, separated by " : ", until the "Stop" command is given:
//•	"Drive : {car} : {distance} : {fuel}":
//o   You need to drive the given distance, and you will need the given fuel to do that.If the car doesn 't have enough fuel, print: "Not enough fuel to make that ride"
//o If the car has the required fuel available in the tank, increase its mileage with the given distance, decrease its fuel with the given fuel, and print: 
//"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed."
//o You like driving new cars only, so if a car's mileage reaches 100 000 km, remove it from the collection(s) and print: "Time to sell the {car}!"
//•	"Refuel : {car} : {fuel}":
//o Refill the tank of your car. 
//o	Each tank can hold a maximum of 75 liters of fuel, so if the given amount of fuel is more than you can fit in the tank, take only what is required to fill it up. 
//o	Print a message in the following format: "{car} refueled with {fuel} liters"
//•	"Revert : {car} : {kilometers}":
//o Decrease the mileage of the given car with the given kilometers and print the kilometers you have decreased it with in the following format:
//"{car} mileage decreased by {amount reverted} kilometers"
//o If the mileage becomes less than 10 000km after it is decreased, just set it to 10 000km and 
//DO NOT print anything.
//Upon receiving the "Stop" command, you need to print all cars in your possession, sorted by their mileage in descending order, then by their name in ascending order, in the following format:
//"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."
//Input / Constraints
//•	The mileage and fuel of the cars will be valid, 32-bit integers, and will never be negative.
//•	The fuel and distance amounts in the commands will never be negative.
//•	The car names in the commands will always be valid cars in your possession.
//Output
//•	All the output messages with the appropriate formats are described in the problem description.
//Examples
//Input	
//3
//Audi A6|38000|62
//Mercedes CLS|11000|35
//Volkswagen Passat CC|45678|5
//Drive : Audi A6 : 543 : 47
//Drive: Mercedes CLS : 94 : 11
//Drive: Volkswagen Passat CC: 69 : 8
//Refuel: Audi A6 : 50
//Revert: Mercedes CLS : 500
//Revert: Audi A6 : 30000
//Stop
//
//Output
//Audi A6 driven for 543 kilometers. 47 liters of fuel consumed.
//Mercedes CLS driven for 94 kilometers. 11 liters of fuel consumed.
//Not enough fuel to make that ride
//Audi A6 refueled with 50 liters
//Mercedes CLS mileage decreased by 500 kilometers
//Volkswagen Passat CC -> Mileage: 45678 kms, Fuel in the tank: 5 lt.
//Mercedes CLS -> Mileage: 10594 kms, Fuel in the tank: 24 lt.
//Audi A6 -> Mileage: 10000 kms, Fuel in the tank: 65 lt.
//Comments
//After we receive the cars with their mileage and fuel, we start driving them. When we get to
//"Drive : Volkswagen Passat CC : 69 : 8" command, our program calculates that there is not enough fuel,
//and we print the appropriate message. Then we refuel the Audi A6 with 50 l of fuel and Revert the Mercedes with 500 kilometers.
//When we receive the "Revert : Audi A6 : 30000", we set its mileage to 10000 km, because if the current mileage
//of the Audi is 38543 kms and if we subtract 30000 from it, we receive 8543 kms, which is less than 10000 kms.
//After all the commands, we print our current collection of cars with their current mileage and current fuel.
//
//Input	
//4
//Lamborghini Veneno|11111|74
//Bugatti Veyron|12345|67
//Koenigsegg CCXR|67890|12
//Aston Martin Valkryie|99900|50
//Drive : Koenigsegg CCXR : 382 : 82
//Drive: Aston Martin Valkryie: 99 : 23
//Drive: Aston Martin Valkryie: 2 : 1
//Refuel: Lamborghini Veneno : 40
//Revert: Bugatti Veyron : 2000
//Stop
//
//Output
//Not enough fuel to make that ride
//Aston Martin Valkryie driven for 99 kilometers. 23 liters of fuel consumed.
//Aston Martin Valkryie driven for 2 kilometers. 1 liters of fuel consumed.
//Time to sell the Aston Martin Valkryie!
//Lamborghini Veneno refueled with 1 liters
//Bugatti Veyron mileage decreased by 2000 kilometers
//Koenigsegg CCXR -> Mileage: 67890 kms, Fuel in the tank: 12 lt.
//Lamborghini Veneno -> Mileage: 11111 kms, Fuel in the tank: 75 lt.
//Bugatti Veyron -> Mileage: 10345 kms, Fuel in the tank: 67 lt.

