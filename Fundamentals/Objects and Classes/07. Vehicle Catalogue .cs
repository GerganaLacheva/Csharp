using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            var catalogue = new Catalog();
            catalogue.trucks = new List<Truck>();
            catalogue.cars = new List<Car>();

            while (command != "end")
            {
                string[] commandArguments = command.Split( '/');
                string type = commandArguments[0];

                if (type == "Car")
                {

                    catalogue.cars.Add(new Car(commandArguments));
                }

                else if (type == "Truck")
                {
                    catalogue.trucks.Add(new Truck(commandArguments));
                }


                command = Console.ReadLine();
            }

            if (catalogue.cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalogue.cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogue.trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalogue.trucks.OrderBy(y => y.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }

    class Catalog
    {
        public List<Truck> trucks;
        public List<Car> cars;
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }

        public Truck(string[] commandArr)
        {
            string brand = commandArr[1];
            string model = commandArr[2];
            string weight = commandArr[3];

            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }

        public Car(string[] commandArr)
        {
            string brand = commandArr[1];
            string model = commandArr[2];
            string horsePower = commandArr[3];

            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
    }
}
//7.Vehicle Catalogue
//Your task is to create a Vehicle catalogue, which contains only Trucks and Cars.
//Define a class Truck with the following properties: Brand, Model and Weight.
//Define a class Car with the following properties: Brand, Model and Horse Power.
//Define a class Catalog with the following properties: Collections of Trucks and Cars.
//You must read the input until you receive the "end" command. It will be in following format: { type}/{ brand}/{ model}/{ horse power / weight}
//In the end you have to print all of the vehicles ordered alphabetical by brand, in the following format:
//Cars:
//{ Brand}: { Model}
//- { Horse Power}
//hp
//Trucks:
//{ Brand}: { Model}
//- { Weight}
//kg
//Examples
//Input	Output
//Car/Audi/A3/110
//Car/Maserati/Levante/350
//Truck/Mercedes/Actros/9019
//Car/Porsche/Panamera/375
//end	Cars:
//Audi: A3 - 110hp
//Maserati: Levante - 350hp
//Porsche: Panamera - 375hp
//Trucks:
//Mercedes: Actros - 9019kg
