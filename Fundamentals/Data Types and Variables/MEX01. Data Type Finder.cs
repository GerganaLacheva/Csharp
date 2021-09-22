using System;

namespace MEX01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (int.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else 
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
//1.Data Type Finder
//You will receive input until you receive "END". Find what data type is the input. Possible data types are:
//•	Integer 
//•	Floating point 
//•	Characters
//•	Boolean
//•	Strings
//Print the result in the following format: "{input} is {data type} type"
//Examples
//Input	
//5
//2.5
//true
//END	
//Output
//5 is integer type
//2.5 is floating point type
//true is boolean type
//Input	
//a
//asd
//-5
//END	
//Output
//a is character type
//asd is string type
//-5 is integer type
