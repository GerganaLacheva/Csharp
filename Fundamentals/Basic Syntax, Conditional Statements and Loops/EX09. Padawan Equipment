using System;

namespace EX09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            double countOfStudents = double.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());


            double qtyLightsabers = Math.Ceiling(countOfStudents * 1.1);
            double qtyBelts = countOfStudents - Math.Floor(countOfStudents / 6);
            double totalExpenses = qtyLightsabers * priceLightsabers + qtyBelts * priceBelts + countOfStudents * priceRobes;

            if (totalExpenses <= moneyAvailable)
            {
                Console.WriteLine($"The money is enough - it would cost {totalExpenses:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalExpenses - moneyAvailable:f2}lv more.");
            }
        }
    }
}
//Padawan Equipment
//Yoda is starting his newly created Jedi academy. So, he asked master Ivan Cho to buy the needed equipment. The number of items depends on how many students will sign up. The equipment for the Padawan contains lightsabers, belts, and robes. 
//You will be given the amount of money Ivan Cho has, the number of students, and the prices of each item. You have to help Ivan Cho calculate if the money he has is enough to buy all of the equipment, or how much more money he needs. 
//Because the lightsabres sometimes break, Ivan Cho should buy 10% more (taken from the student's count), rounded up to the next integer. Also, every sixth belt is free. 
//Input / Constraints
//The input data should be read from the console. It will consist of exactly 5 lines:
//•	The amount of money Ivan Cho has – the floating-point number in the range [0.00…1,000.00]
//•	The count of students – integer in the range [0…100]
//•	The price of lightsabers for a single saber – the floating-point number in the range [0.00…100.00]
//•	The price of robes for a single robe – the floating-point number in the range [0.00…100.00]
//•	The price of belts for a single belt – the floating-point number in the range [0.00…100.00]
//The input data will always be valid. There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//•	If the calculated price of the equipment is less or equal to the money Ivan Cho has:
//o "The money is enough - it would cost {the cost of the equipment}lv."
//•	If the calculated price of the equipment is more than the money Ivan Cho has:
//o "Ivan Cho will need {neededMoney}lv more."
//•	All prices must be rounded to two digits after the decimal point.
//Examples
//Input	Output	Comments
//100
//2
//1.0
//2.0
//3.0	The money is enough - it would cost 13.00lv.	Needed equipment for 2 padawans  :
//sabresPrice * (studentsCount + 10 %) + robesPrice * (studentsCount) + beltsPrice * (studentsCount - freeBelts)
//1 * (3) + 2 * (2) + 3 * (2) = 13.00
//13.00 <= 100 – the money will be enough.
//Input	Output	Comments
//100
//42
//12.0
//4.0
//3.0	Ivan Cho will need 737.00lv more.	Needed equipment for 42 padawans:
//12 * 47 + 4 * 42 + 3 * 35 = 837.00
//837 > 100 – need 737.00 lv.more.
