using System;

namespace EX04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValidPassword = true;

            if (!isValidLength(password))
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
                isValidPassword = false;
            }

            if (ContainsSymbols(password))
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                isValidPassword = false;
            }

            if (!ContainsEnoughtDigits(password,2))
            {
                Console.WriteLine($"Password must have at least 2 digits");
                isValidPassword = false;
            }

            if (isValidPassword)
            {
                Console.WriteLine($"Password is valid");
            }
        }

        private static bool ContainsEnoughtDigits(string password, int count)
        {
            int digitsCount = 0;
            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    digitsCount += 1;
                    if (digitsCount==count)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool ContainsSymbols(string password)
        {
            foreach (var symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }
            }
                return false;
        }

        private static bool isValidLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}


//4.Password Validator
//Create a program that checks if a given password is valid.
//The password validation rules are:
//•	It should contain 6 – 10 characters (inclusive)
//•	It should contain only of letters and digits
//•	It should contain at least 2 digits 
//If it is not valid, for any unfulfilled rule print the corresponding message:
//•	"Password must be between 6 and 10 characters"
//•	"Password must consist only of letters and digits"
//•	"Password must have at least 2 digits"
//Examples
//Input	    Output
//logIn	    Password must be between 6 and 10 characters 
//          Password must have at least 2 digits
//
//MyPass123	Password is valid
//
//Pa$s$s	Password must consist only of letters and digits
//          Password must have at least 2 digits
