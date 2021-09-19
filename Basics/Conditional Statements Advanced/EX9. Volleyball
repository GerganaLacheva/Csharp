using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t9.Volleyball
{
	class Program
	{
		static void Main(string[] args)
		{
			string year = Console.ReadLine();
			int holidayDay = int.Parse(Console.ReadLine());
			int weekendDay = int.Parse(Console.ReadLine());

			double daysinYear = 48 - weekendDay;
			double gameinSofia = 3.0 / 4 * daysinYear;
			double gameinTown = weekendDay;
			double gameHoliday = holidayDay * (2.0 / 3);
			double gameSum = gameinSofia + gameinTown + gameHoliday;
			double sum = 0;

			switch (year)

			{
				case "leap": sum = gameSum * 0.15; break;
			}

			Console.WriteLine("{0}", Math.Truncate(gameSum + sum));
		}
	}
}
