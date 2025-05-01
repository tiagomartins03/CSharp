using System;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear(); // aplica o fundo azul em tudo
            DrawScreen();
            WriteOptions();

            //Console.SetCursorPosition(10, 16); // posição da leitura
            var option = short.Parse(Console.ReadLine()!);
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            int width = 40;
            int height = 20;

            // Topo
            Console.Write("+");
            for (int i = 0; i < width; i++) Console.Write("-");
            Console.WriteLine("+");

            // Corpo
            for (int line = 0; line < height; line++)
            {
                Console.Write("|");
                for (int i = 0; i < width; i++) Console.Write(" ");
                Console.WriteLine("|");
            }

            // Rodapé
            Console.Write("+");
            for (int i = 0; i < width; i++) Console.Write("-");
            Console.WriteLine("+");
        }

        
        public static void WriteOptions()
        
        {
            Console.SetCursorPosition(12, 2);
            Console.WriteLine("📝 Editor HTML");

            Console.SetCursorPosition(12, 3);
            Console.WriteLine("======================");

            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Selecione uma opção abaixo:");

            Console.SetCursorPosition(10, 7);
            Console.WriteLine("1 - Criar novo arquivo");

            Console.SetCursorPosition(10, 8);
            Console.WriteLine("2 - Abrir arquivo");

            Console.SetCursorPosition(10, 10);
            Console.WriteLine("0 - Sair");

            Console.SetCursorPosition(10, 12);
            Console.Write("Opção: ");
        }
    
        public static void HandleMenuOption(short option)
        {
            switch(option)
            {
                case 1: Editor.Show() ;break;
                case 2: Console.WriteLine("View"); break;
                case 0: 
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show();break;
            }
        }
    
    }
}
