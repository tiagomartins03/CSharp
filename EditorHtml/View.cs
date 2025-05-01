using System;
using System.Text.RegularExpressions;
using EditorHTML;

namespace EdHtml 
{

    public class View
    {
         public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Modo visualização");
            Console.WriteLine("-----------");
            Replace(text);
            Console.WriteLine("---------");
            Console.ReadKey();
            Menu.Show();
 

        }

        public static void Replace(string text)
        {
                var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*/\s*strong");
                Console.WriteLine(strong);
        }

    }
}