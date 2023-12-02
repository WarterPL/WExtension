using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W;

namespace W
{
    public class WConsole
    {
        public static string ReadLine(string text = "")
        { Console.Write(text); return Console.ReadLine(); }
        
        public static void Write(string text, string end="\n") => Console.Write(text + end);

        public static void Recolor(ConsoleColor foreground = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        { Console.ForegroundColor = foreground; Console.BackgroundColor = background; }
    }
}
