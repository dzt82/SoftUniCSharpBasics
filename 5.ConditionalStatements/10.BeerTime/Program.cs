using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        CultureInfo enUS = new CultureInfo("en-US");
        DateTime time;
        DateTime openTime = DateTime.Parse("1:00 PM");
        DateTime closeTime = DateTime.Parse("3:00 AM");
        Console.WriteLine("Please enter time in the format hh:mm am/pm, where hh[01...12] and mm [00..59] ");
        string dateString = Console.ReadLine();

        if (DateTime.TryParseExact(dateString, "h:mm tt", enUS, DateTimeStyles.None, out time))
        {
            if (time > openTime || time < closeTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}

