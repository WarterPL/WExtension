using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WClasses
{
    public class WConsole
    {
        public static string ReadString(string text = "")
        { Console.Write(text); return Console.ReadLine(); }
        public static float ReadFloat(string text = "")
        { Console.Write(text); return float.Parse(Console.ReadLine()); }
        public static double ReadDouble(string text = "")
        { Console.Write(text); return double.Parse(Console.ReadLine()); }
        public static int ReadInt(string text = "")
        { Console.Write(text); return int.Parse(Console.ReadLine()); }
        
        public static void Write(string text, string end="\n") => Console.Write(text + end);

        public static void Recolor(ConsoleColor foreground = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        { Console.ForegroundColor = foreground; Console.BackgroundColor = background; }
    }
}
