using System;
using System.Runtime.InteropServices;

namespace DatesBegin
{
    public class Dates
    {
        public static void BeginWithDates()
        {
            Console.Clear();
            //var data = new DateTime();
            var data = DateTime.Now;
            Console.WriteLine(data);
        }

    }
}