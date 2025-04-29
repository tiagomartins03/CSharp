using System;

namespace StringCompair
{
    public class Compapair

    {
        public static void CompareString(string FirstString, string SecString)
        {
            bool varResult = FirstString.Contains(SecString);

            if (varResult == false)

            {

                Console.WriteLine("Não são iguais");
            }
            else

            {
                Console.WriteLine("São iguais");
            }

        }
    }
}