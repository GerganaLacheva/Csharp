using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1))
            if (date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        Console.WriteLine(holidaysCount);
    }
}
//You are assigned to find and fix all bugs in existing code. By using the Visual Studio debugger, place a breakpoint and find the lines of code that produce incorrect or unexpected results.
//You are given a program (existing source code) that aims to count the non-working days between two dates in format day.month.year (e.g. between 1.05.2015 and 15.05.2015 there are 5 non-working days – Saturday and Sunday).
//Examples
//Input	Output	Comments
//1.05.2016
//15.05.2016	5	There are 5 non-working days (Saturday / Sunday) in this period:
//1 - May - 2016, 7 - May - 2016, 8 - May - 2016, 14 - May - 2016, 15 - May - 2016
//1.5.2016
//2.5.2016    1   Only 1 non - working day in the specified period: 1.05.2016(Sunday)
//15.5.2020
//10.5.2020   0   The second date is before the first. No dates in the range.
//22.2.2020
//1.3.2020	4	Two Saturdays and Sundays:
//•	22.02.2020 and 23.02.2020
//•	29.02.2020 and 1.03.2020
//You can find the broken code in the judge system: Broken Code for Refactoring. It looks as follows:
//HolidaysBetweenTwoDates.cs
//using System;
//using System.Globalization;

//class HolidaysBetweenTwoDates
//{
//    static void Main()
//    {
//        var startDate = DateTime.ParseExact(Console.ReadLine(),
//            "dd.m.yyyy", CultureInfo.InvariantCulture);
//        var endDate = DateTime.ParseExact(Console.ReadLine(),
//            "dd.m.yyyy", CultureInfo.InvariantCulture);
//        var holidaysCount = 0;
//        for (var date = startDate; date <= endDate; date.AddDays(1))
//            if (date.DayOfWeek == DayOfWeek.Saturday &&
//                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
//        Console.WriteLine(holidaysCount);
//    }
//}
//Hints
//There are 4 mistakes in the code. You’ve got to use the debugger to find them and fix them.
