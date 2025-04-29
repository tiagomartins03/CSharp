using System;
using System.Diagnostics.Contracts;

namespace StringManipulation_Program
{
    public class String_Manipulation

    {

        public static void Manipulacao()

        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Replace("e", "X"));
            Console.WriteLine(texto.Replace("xxxxxx","X"));

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);

            var resultado = texto.Substring(5,5);
            Console.WriteLine(resultado);

        }
    }
}