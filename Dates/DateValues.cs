using System;
namespace DateValues
{
    public class DateValues
    {
        public static void ExtractValues()
        {
            var data = new DateTime(2025, 10, 15, 13, 23, 14);

            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);

        }
    }
}

