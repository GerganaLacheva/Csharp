using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t04.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int input = 1;

            while (input<=n)
            {
                Console.WriteLine(input);
                input = input * 2 + 1;
            }
        }
    }
}
