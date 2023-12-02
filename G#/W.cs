using System;
using System.Linq;
using System.Runtime.InteropServices.Expando;
using WClasses.Helpers;

namespace WClasses
{
    public class W
    {
        public static bool IsEvenNumber(int x) => x % 2 == 0;

        public static double Average(int[] array)
        {
            double avg = array.Sum();
            avg /= array.Length;
            return avg;
        }
        public static double Average(float[] array)
        {
            double avg = array.Sum();
            avg /= array.Length;
            return avg;
        }
        public static double Average(double[] array)
        {
            double avg = array.Sum();
            avg /= array.Length;
            return avg;
        }

        public static void ArrayPrinter<T>(T[] array, string expand = null)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            for (int i = 0; i < array.Length; i++)
            {
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;
                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(array[i]);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            if(expand == null)
                Console.ResetColor();
        }
        public static void Array2DPrinter<T>(T[,] array,string expand = null)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;
                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Row number {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                var _1Dim = array.Extract(i);
                ArrayPrinter(_1Dim, expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        public static void Array3DPrinter<T>(T[,,] array, string expand = null)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;
                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Thickness {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _2Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                Array2DPrinter(_2Dim, expand + expander);
            }
            if(expand == null)
                Console.ResetColor();
        }
        public static void Array4DPrinter<T>(T[,,,] array, string expand = null)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;
                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"4th Dimension layer {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _3Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                Array3DPrinter(_3Dim, expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
    }
    public enum ArrayOperation
    {
        None = 0,
        Reverse = 1,
        Sorted = 2,
        SortedAndReversed = 3
    }
}
