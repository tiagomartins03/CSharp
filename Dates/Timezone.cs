using System;


namespace TimezoneProgram
{
    public class Timezone
    {
        public static void TimezoneFunction()
        {
            Console.Clear();

            var dateTime = DateTime.UtcNow;
            Console.WriteLine(dateTime);

            var utcDate = DateTime.UtcNow;
            Console.WriteLine(utcDate);
            Console.WriteLine(utcDate.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();


            foreach(var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
            }
        }
    }
}