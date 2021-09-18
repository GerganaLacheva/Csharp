using System;
using System.Linq;

namespace EX05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Join("",username.Reverse()); //

            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                if (input==password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (i==3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                if (input!=password)
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
            }

            //string password = string.Empty; //==""
            //for (int i = username.Length - 1; i >= 0; i--)
            //{
            //    password += username[i];
            //}
           
        }
    }
}
//5.Login
//You will be given a username. The password will be the username reversed. 
//Until you receive the correct password print on the console:
// "Incorrect password. Try again."
// When you receive the correct password print:
// "User {username} logged in."
//However, on the fourth try if the password is still not correct print:
//"User {username} blocked!"
//Then the program stops.
//Examples
//Input	Output
//Acer
//login
//go
//let me in
//recA
//	Incorrect password. Try again.
//Incorrect password. Try again.
//Incorrect password. Try again.
//User Acer logged in.

//momo
//omom	User momo logged in.
//sunny
//rainy
//cloudy
//sunny
//not sunny	Incorrect password. Try again.
//Incorrect password. Try again.
//Incorrect password. Try again.
//User sunny blocked!
