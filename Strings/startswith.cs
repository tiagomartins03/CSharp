using System;
using System.Runtime.CompilerServices;

namespace StrComp
{
    public class Startswith

    {
        public static void CompairStartsWith(String FirstString, String SecondString)

        {
            Console.WriteLine(FirstString.StartsWith(SecondString));

        }

    }

    public class Endswith

    {

        public static void CompairEndsWith(String FirstString, String SecondString)

        {

            Console.WriteLine(FirstString.EndsWith(SecondString));
        }
    }
}