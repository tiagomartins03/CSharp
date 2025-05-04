using System;

namespace AddValuesProgram
{
    public class AddValues
    {
        public static void AddValuesFunction()
        {
            var varData = DateTime.Now;
            var varDataAdded = varData.AddDays(30);

            Console.WriteLine($"Data Atual : {varData}");
            Console.WriteLine($"Data Acrescida : {varDataAdded}");
        }
    }
}