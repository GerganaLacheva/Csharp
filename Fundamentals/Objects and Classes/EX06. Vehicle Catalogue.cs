using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06.Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] vehicleParts = command.Split();

                string type = vehicleParts[0];
                string model = vehicleParts[1];
                string color = vehicleParts[2];
                int horsepower = int.Parse(vehicleParts[3]);

                Vehicle vehicle = new Vehicle
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    Horsepower = horsepower

                };

                vehicles.Add(vehicle);
            }

            while (true)
            {
                string model = Console.ReadLine();

                if (model == "Close the Catalogue")
                {
                    break;
                }

                Vehicle vehicle = GetVehicleByModel(vehicles, model);

                if (vehicle == null)
                {
                    continue;
                }

                if (vehicle.Type == "car")
                {
                    Console.WriteLine($"Type: Car");
                }
                else
                {
                    Console.WriteLine($"Type: Truck");
                }

                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
            }

            double averageCarHorsepower = CalcAverageHorsepower(vehicles, "car");
            double averageTruckHorsepower = CalcAverageHorsepower(vehicles, "truck");

            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsepower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsepower:f2}.");
        }

        private static double CalcAverageHorsepower(List<Vehicle> vehicles, string type)
        {
            int vehicleCount = 0;
            int totalHorsepower = 0;

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == type)
                {
                    vehicleCount += 1;
                    totalHorsepower += vehicle.Horsepower;
                }
            }
            if (vehicleCount==0)
            {
                return 0;
            }
            return (double)totalHorsepower / vehicleCount;
        }

        private static Vehicle GetVehicleByModel(List<Vehicle> vehicles, string model)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Model == model)
                {
                    return vehicle;
                }
            }
            return null;
        }
        class Vehicle
        {
            public string Type { get; set; }

            public string Model { get; set; }

            public string Color { get; set; }

            public int Horsepower { get; set; }
        }
    }
}
//6.Vehicle Catalogue
//Until you receive the "End" command, you will be receiving lines of input in the following format:
//{ typeOfVehicle}
//{ model}
//{ color}
//{ horsepower}
//After When you receive the "End" command, you will start receiving information about some vehicles.
//For every vehicle, print out the information about it in the following format:
//Type: { typeOfVehicle}
//Model: { modelOfVehicle}
//Color: { colorOfVehicle}
//Horsepower: { horsepowerOfVehicle}

//When you receive the "Close the Catalogue" command, print out the average horsepower of the cars and the average horsepower of the trucks in the format:
//"{typeOfVehicles} have average horsepower of {averageHorsepower}."
//The average horsepower is calculated by dividing the sum of the horsepower of all vehicles of the given type by the total count of all vehicles from that type. Format the answer to the second digit after the decimal point.
//Constraints
//•	The type of vehicle will always be either a car or a truck.
//•	You will not receive the same model twice.
//•	The received horsepower will be an integer in the range [1…1000]
//•	You will receive at most 50 vehicles.
//•	The separator will always be a single whitespace.
//Examples
//Input	Output
//truck Man red 200
//truck Mercedes blue 300
//car Ford green 120
//car Ferrari red 550
//car Lamborghini orange 570
//End
//Ferrari
//Ford
//Man
//Close the Catalogue	Type: Car
//Model: Ferrari
//Color: red
//Horsepower: 550
//Type: Car
//Model: Ford
//Color: green
//Horsepower: 120
//Type: Truck
//Model: Man
//Color: red
//Horsepower: 200
//Cars have average horsepower of: 413.33.
//Trucks have average horsepower of: 250.00.
