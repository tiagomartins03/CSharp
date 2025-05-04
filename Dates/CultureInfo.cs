using System;
using System.Globalization;


namespace CultureInfoProgram
{
public class CultureInfoClass
{
    public static void CultureInfoFunction()
    {
        Console.Clear();

        var br = new CultureInfo("pt-BR");
        var pt = new CultureInfo("pt-BR");
        var en = new CultureInfo("pt-US");
        var DE = new CultureInfo("de-DE");

        Console.WriteLine(DateTime.Now);
    }
}

}