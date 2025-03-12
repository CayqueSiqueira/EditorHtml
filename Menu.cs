using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            //modo 1 usando for
            // Console.Write("+");
            // for (int i = 0; i <= 30; i++)
            // {
            //     Console.Write("-");
            // }
            // Console.Write("+");
            // Console.Write("\n");

            // for(int lines = 0; lines <= 10; lines++)
            // {
            //     Console.Write("|");
            //     for (int i = 0; i <= 30; i++)
            //     {
            //         Console.Write(" ");
            //     }
            //     Console.Write("|");
            //     Console.Write("\n");
            // }

            //modo 2 usando string 
            // Console.Write("+");
            // for (int i = 0; i <= 30; i++)
            // {
            //     Console.Write("-");
            // }
            // Console.Write("+");
            // Console.Write("\n");

            // string horizontalBorder = "+" + new string('-', 30) + "+";
            // string emptyLine = "|" + new string(' ', 30) + "|";

            // Console.WriteLine(horizontalBorder);
            
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(emptyLine);
            // }

            // Console.WriteLine(horizontalBorder);

        //modo 3 usando stringbuilder
        StringBuilder sb = new StringBuilder();
        
        string horizontalBorder = "+" + new string('-', 30) + "+";
        string emptyLine = "|" + new string(' ', 30) + "|";

        sb.AppendLine(horizontalBorder);
        
        for (int i = 0; i < 10; i++)
        {
            sb.AppendLine(emptyLine);
        }

        sb.AppendLine(horizontalBorder);

        Console.Write(sb.ToString()); // Uma única chamada de saída

        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Selecione uma opção: ");
        }
    
        public static void HandleMenuOption(short option)
        {
            switch(option){
                case 1:
                Editor.Show(); break;
                case 2:
                Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }


}