using System;

namespace EX08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());
            double biggestVolume = 0;
            string biggestKeg = "";

            for (int i = 0; i < kegs; i++)
            {
                string kegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int hight = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * hight;

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = kegModel;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
//8.Beer Kegs
//Create a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines. Every three lines will hold information for a single keg. First up is the model of the keg, after that is the radius of the keg, and lastly is the height of the keg.
//Calculate the volume using the following formula: π* r^2 * h.
//In the end, print the model of the biggest keg.
//Input
//You will receive 3 * n lines. Each group of lines will be on a new line:
//•	First – model – string.
//•	Second –radius – floating - point number
//•	Third – height – integer number
//Output
//Print the model of the biggest keg.
//Examples
//Input	    Output
//3           Keg 2
//Keg 1
//10
//10
//Keg 2
//20
//20
//Keg 3
//10
//30	
