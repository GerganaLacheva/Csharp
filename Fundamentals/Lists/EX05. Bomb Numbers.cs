using System;
using System.Linq;
using System.Collections.Generic;

namespace EX05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombSpecifications = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombPosition = bombSpecifications[0];                       //индекс [0] от входа е числото-бомба, индекс [1] от входа е обхвата на взрива на ляво и на дясно
            int bombPower = bombSpecifications[1];

            for (int i = 0; i < numbers.Count; i++)                         //обхождаме всички числа от листа, за да намерим числото бомба
            {
                if (numbers[i] == bombPosition)                             //ако настоящото число е равно на числото-бомба, значи сме намерили бомбата
                {
                    for (int j = i - bombPower; j <= i + bombPower; j++)    //стартираме от настоящата бомба i минус обхвата, по усл. взривяваме от ляво на дясно и обхождаме до i+обхвата
                    {
                        if (j < 0 || j >= numbers.Count)                    //проверяваме дали индекса на числото-бомба е в границите на масива, ако не е - преминаваме към следваща итерация
                        {
                            continue;
                        }

                        numbers[j] = 0;                                     //всички отстреляни числа в обсега на бомбата приемат стойност нула
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
//5.Bomb Numbers
//Create a program that reads a sequence of numbers and a special bomb number holding a certain power. Your task is to detonate every occurrence of the special bomb number and according to its power the numbers to its left and right. The bomb power refers to how many numbers to the left and right will be removed, no matter their values. Detonations are performed from left to right and all the detonated numbers disappear. Finally, print the sum of the remaining elements in the sequence.
//Examples
//Input	                Output	Comments
//1 2 2 4 2 2 2 9         12	Special number is 4 with power 2. After detontaion we are left with the sequence [1, 2, 9] with sum 12.
//4 2	
//1 4 4 2 8 9 1
//9 3	                  5	Special number is 9 with power 3. After detontaion we are left with the sequence [1, 4] with sum 5. Since the 9 has only 1 neighbour from the right we remove just it (one number instead of 3).
//1 7 7 1 2 3
//7 1                     6   Detonations are performed from left to right. We cannot detonate the second occurance of 7, because its already destroyed by the first occurance. The numbers [1, 2, 3] survive.Their sum is 6.
//1 1 2 1 1 1 2 1 1 1
//2 1	                  4	The red and yellow numbers disappear in two sequential detonations. The result is the sequence [1, 1, 1, 1]. Sum = 4.
