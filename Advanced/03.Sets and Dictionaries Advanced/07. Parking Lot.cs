using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(", ");
                string direction = tokens[0];
                string carPlate=tokens[1];

                switch (direction)
                {
                    case "IN": cars.Add(carPlate); break;
                    case "OUT": cars.Remove(carPlate); break;
                }

                input = Console.ReadLine();
            }
            if (cars.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine,cars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
//7.Parking Lot
//Create a program that:
//•	Records a car number for every car that enters the parking lot
//•	Removes a car number when the car leaves the parking lot
//The input will be a string in the format: "direction, carNumber".You will be receiving commands until the "END" command is given.
//Print the car numbers of the cars, which are still in the parking lot:
//Examples
//Input	
//IN, CA2844AA
//IN, CA1234TA
//OUT, CA2844AA
//IN, CA9999TT
//IN, CA2866HI
//OUT, CA1234TA
//IN, CA2844AA
//OUT, CA2866HI
//IN, CA9876HH
//IN, CA2822UU
//END	
//
//Output
//CA9999TT
//CA2844AA
//CA9876HH
//CA2822UU
