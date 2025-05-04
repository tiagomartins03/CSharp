using System;

namespace DateComparingProgram
{
    public class DateComparing
    {
        public static void CompareDates()
        {
            Console.Clear();
            var varData = DateTime.Now;

            if (varData.Date >= DateTime.Now.Date)
            {
                Console.WriteLine("É igual");
            }
        }
    }
}