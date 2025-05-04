using System;

namespace DateFormatingFunction
{
    public class DateFormating
    {
        public static void FormatDate()
        {
            Console.Clear();
            var data = DateTime.Now;
            var formatada = string.Format("{0:yyyy-MM-dd}",data);
            Console.WriteLine(formatada);
        
        }
    }
}