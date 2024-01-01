using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W
{
    public static class WConsole
    { 
        public static ConsoleColor colorB { get; private set; } = ConsoleColor.Black;
        public static ConsoleColor colorF { get; private set; } = ConsoleColor.White;

        public static string ReadLine(string text = "",
            ConsoleColor foreground = ConsoleColor.White,
            ConsoleColor background = ConsoleColor.Black, bool clearColorAfterInput = false)
        {
            colorB = Console.BackgroundColor; colorF = Console.ForegroundColor;
            Write(text, foreground, background);
            if(!clearColorAfterInput)
                unRecolor();
            string input = Console.ReadLine();
            unRecolor();
            return input;
        }

        public static void RainbowWrite(string text = "", string end = "")
        {
            colorB = Console.BackgroundColor; colorF = Console.ForegroundColor;
            for (int i = 0; i < text.Length; i++)
            {
                switch(i%10)
                {
                    case 0: WConsole.Write(text[i].ToString(), ConsoleColor.DarkRed); break;
                    case 1: WConsole.Write(text[i].ToString(), ConsoleColor.DarkYellow); break;
                    case 2: WConsole.Write(text[i].ToString(), ConsoleColor.DarkGreen); break;
                    case 3: WConsole.Write(text[i].ToString(), ConsoleColor.Green); break;
                    case 4: WConsole.Write(text[i].ToString(), ConsoleColor.Cyan); break;
                    case 5: WConsole.Write(text[i].ToString(), ConsoleColor.DarkCyan); break;
                    case 6: WConsole.Write(text[i].ToString(), ConsoleColor.Blue); break;
                    case 7: WConsole.Write(text[i].ToString(), ConsoleColor.DarkBlue); break;
                    case 8: WConsole.Write(text[i].ToString(), ConsoleColor.DarkMagenta); break;
                    case 9: WConsole.Write(text[i].ToString(), ConsoleColor.Magenta); break;
                }
            }
            Console.Write(end);
            unRecolor();
        }

        public static void WriteLine(string text ="",
            ConsoleColor foreground = ConsoleColor.White,
            ConsoleColor background = ConsoleColor.Black)
        {
            colorB = Console.BackgroundColor; colorF = Console.ForegroundColor;
            Recolor(foreground ,background);
            Console.WriteLine(text);
            unRecolor();
        }

        public static void Write(string text, 
            ConsoleColor foreground = ConsoleColor.White, 
            ConsoleColor background = ConsoleColor.Black) 
        {
            SetColors();
            Recolor(foreground, background);
            Console.Write(text);
            unRecolor();
        }
        public static void Recolor(ConsoleColor foreground = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        { Console.ForegroundColor = foreground; Console.BackgroundColor = background; }
        private static void unRecolor()
        {  Console.ForegroundColor = colorF; Console.BackgroundColor = colorB; }
        private static void SetColors()
        {
            colorB = Console.BackgroundColor;
            colorF = Console.ForegroundColor;
        }
    }
}