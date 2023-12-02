using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W
{
    public static class WArray
    {
        public static T[] Extract<T>(this T[,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            T[] output = new T[_1stDimLength];

            for (int i = 0; i < _1stDimLength; i++)
            {
                output[i] = array[index, i];
            }

            return output;
        }
        public static T[,] Extract<T>(this T[,,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            int _2ndDimLength = array.GetLength(2);
            T[,] output = new T[_1stDimLength, _2ndDimLength];

            for (int i = 0; i < _1stDimLength; i++)
            {
                for (int j = 0; j < _2ndDimLength; j++)
                {
                    output[i, j] = array[index, i, j];
                }
            }
            return output;
        }
        public static T[,,] Extract<T>(this T[,,,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            int _2ndDimLength = array.GetLength(2);
            int _3ndDimLength = array.GetLength(3);
            T[,,] output = new T[_1stDimLength, _2ndDimLength, _3ndDimLength];

            for (int i = 0; i < _1stDimLength; i++)
            {
                for (int j = 0; j < _2ndDimLength; j++)
                {
                    for (int k = 0; k < _3ndDimLength; k++)
                    {
                        output[i, j, k] = array[index, i, j, k];
                    }
                }
            }
            return output;
        }
        public static T[,,,] Extract<T>(this T[,,,,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            int _2ndDimLength = array.GetLength(2);
            int _3ndDimLength = array.GetLength(3);
            int _4thDimLength = array.GetLength(4);
            T[,,,] output = new T[_1stDimLength, _2ndDimLength, _3ndDimLength, _4thDimLength];

            for (int i = 0; i < _1stDimLength; i++)
                for (int j = 0; j < _2ndDimLength; j++)
                    for (int k = 0; k < _3ndDimLength; k++)
                        for (int l = 0; l < _4thDimLength; l++)
                            output[i, j, k, l] = array[index, i, j, k, l];

            return output;
        }


        public static void Printer<T>(this List<T> lst) => lst.ToArray().Printer();
        public static void Printer<T>(this T[] array, string expand = null)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            for (int i = 0; i < array.Length; i++)
            {
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;
                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(array[i]);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            if (expand == null)
                Console.ResetColor();
        }
        public static void Printer<T>(this T[,] array, string expand = null)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;
                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Row number {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                var _1Dim = array.Extract(i);
                _1Dim.Printer(expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        public static void Printer<T>(this T[,,] array, string expand = null)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;
                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Thickness {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _2Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _2Dim.Printer(expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        public static void Printer<T>(this T[,,,] array, string expand = null)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;
                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"4th Dimension layer {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _3Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _3Dim.Printer(expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        public static void Printer<T>(this T[,,,,] array, string expand = null)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;
                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"5th Dimension layer {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _4Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _4Dim.Printer(expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
    }
}