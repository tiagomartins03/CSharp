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
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) -
                                 words[i].IndexOf('>')

                            )
                        )

                    );
                    Console.Write(" ");

                }
                else { Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine(words[i]);}
            }
        }

    }
}