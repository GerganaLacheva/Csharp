using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05.Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();      
            int multiplier = int.Parse(Console.ReadLine());    

            StringBuilder sb = new StringBuilder();
            int reminder = 0;   //запазваме остатъка, напр.12*2=24, (взимаме 4 и) 2 на ум

            if (input=="0" || multiplier==0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)    //започваме умножението от дясно на ляво
            {
                int currentDigit = int.Parse(input[i].ToString());
                int product = currentDigit * multiplier +reminder;

                int result = product % 10; //взимаме 4
                reminder = product / 10;    //взимаме 2

                sb.Insert(0, result);          //на всяка итерация слагаме продукта най-отпред
            }
            if (reminder>0)     //за остатъка след умножението на най-лявото число
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb);
        }
    }
}
//Multiply Big Number
//You are given two lines – the first one can be a really big number (0 to 1050). The second one will be a single digit number (0 to 9). Your taks is to display the product of these numbers.
//Note: do not use the BigInteger class.
//Examples
//Input	                            Output
//23
//2	                                46
//9999
//9	                                89991
//923847238931983192462832102
//4	                                3695388955727932769851328408
