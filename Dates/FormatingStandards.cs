using System;

namespace FormatingStandards
{
    public class FormatStandard
    {
        public static void FormatFormatStandard()
        {
            Console.Clear();
            var data = DateTime.Now;
            var formatada = string.Format("{0:g}",data);
            //U,t,Y,Z...
            Console.WriteLine(formatada);
        
        }
    }
}