using System;

namespace MEX05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string alphabet = "abcdefghijklmnopqrstuvwxyz", result = "";
            int digits = 0, temp = 0, mainDigit = 0, offset = 0, letterIndex = 0;
            for (int i = 1; i <= input; i++)
            {
                temp = int.Parse(Console.ReadLine());
                if (temp == 0)
                {
                    result += " ";
                }
                else
                {
                    while (temp > 0)
                    {
                        mainDigit = temp % 10;
                        temp /= 10;
                        digits++;
                    }
                    offset = (mainDigit - 2) * 3;
                    letterIndex = offset + digits - 1;
                    if (mainDigit == 8 || mainDigit == 9)
                        letterIndex++;
                    result += alphabet[letterIndex];
                }
                digits = 0;
            }
            Console.WriteLine(result);
        }
    }
}
