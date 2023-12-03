using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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
        public static T[,,,,] Extract<T>(this T[,,,,,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            int _2ndDimLength = array.GetLength(2);
            int _3ndDimLength = array.GetLength(3);
            int _4thDimLength = array.GetLength(4);
            int _5thDimLength = array.GetLength(5);
            T[,,,,] output = new T[_1stDimLength, _2ndDimLength, _3ndDimLength, _4thDimLength,_5thDimLength];

            for (int i = 0; i < _1stDimLength; i++)
                for (int j = 0; j < _2ndDimLength; j++)
                    for (int k = 0; k < _3ndDimLength; k++)
                        for (int l = 0; l < _4thDimLength; l++)
                            for (int m = 0; m < _5thDimLength; m++)
                            output[i, j, k, l, m] = array[index, i, j, k, l, m];

            return output;
        }
        public static T[,,,,,] Extract<T>(this T[,,,,,,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            int _2ndDimLength = array.GetLength(2);
            int _3ndDimLength = array.GetLength(3);
            int _4thDimLength = array.GetLength(4);
            int _5thDimLength = array.GetLength(5);
            int _6thDimLength = array.GetLength(6);
            T[,,,,,] output = new T[_1stDimLength, _2ndDimLength, _3ndDimLength, _4thDimLength, _5thDimLength, _6thDimLength];

            for (int i = 0; i < _1stDimLength; i++)
                for (int j = 0; j < _2ndDimLength; j++)
                    for (int k = 0; k < _3ndDimLength; k++)
                        for (int l = 0; l < _4thDimLength; l++)
                            for (int m = 0; m < _5thDimLength; m++)
                                for (int n = 0; n < _6thDimLength; n++)
                                    output[i, j, k, l, m, n] = array[index, i, j, k, l, m, n];

            return output;
        }
        public static T[,,,,,,] Extract<T>(this T[,,,,,,,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            int _2ndDimLength = array.GetLength(2);
            int _3ndDimLength = array.GetLength(3);
            int _4thDimLength = array.GetLength(4);
            int _5thDimLength = array.GetLength(5);
            int _6thDimLength = array.GetLength(6);
            int _7thDimLength = array.GetLength(7);
            T[,,,,,,] output = new T[_1stDimLength, _2ndDimLength, _3ndDimLength, _4thDimLength, _5thDimLength, _6thDimLength, 
                _7thDimLength];

            for (int i = 0; i < _1stDimLength; i++)
                for (int j = 0; j < _2ndDimLength; j++)
                    for (int k = 0; k < _3ndDimLength; k++)
                        for (int l = 0; l < _4thDimLength; l++)
                            for (int m = 0; m < _5thDimLength; m++)
                                for (int n = 0; n < _6thDimLength; n++)
                                    for (int o = 0; o < _7thDimLength; o++)
                                        output[i, j, k, l, m, n, o] = array[index, i, j, k, l, m, n, o];

            return output;
        }
        public static T[,,,,,,,] Extract<T>(this T[,,,,,,,,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            int _2ndDimLength = array.GetLength(2);
            int _3ndDimLength = array.GetLength(3);
            int _4thDimLength = array.GetLength(4);
            int _5thDimLength = array.GetLength(5);
            int _6thDimLength = array.GetLength(6);
            int _7thDimLength = array.GetLength(7);
            int _8thDimLength = array.GetLength(8);
            T[,,,,,,,] output = new T[_1stDimLength, _2ndDimLength, _3ndDimLength, _4thDimLength, _5thDimLength, _6thDimLength,
                _7thDimLength, _8thDimLength];

            for (int i = 0; i < _1stDimLength; i++)
                for (int j = 0; j < _2ndDimLength; j++)
                    for (int k = 0; k < _3ndDimLength; k++)
                        for (int l = 0; l < _4thDimLength; l++)
                            for (int m = 0; m < _5thDimLength; m++)
                                for (int n = 0; n < _6thDimLength; n++)
                                for (int o = 0; o < _7thDimLength; o++)
                                for (int p = 0; p < _8thDimLength; p++)
                                    output[i, j, k, l, m, n, o, p] = array[index, i, j, k, l, m, n, o, p];

            return output;
        }
        public static T[,,,,,,,,] Extract<T>(this T[,,,,,,,,,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            int _2ndDimLength = array.GetLength(2);
            int _3ndDimLength = array.GetLength(3);
            int _4thDimLength = array.GetLength(4);
            int _5thDimLength = array.GetLength(5);
            int _6thDimLength = array.GetLength(6);
            int _7thDimLength = array.GetLength(7);
            int _8thDimLength = array.GetLength(8);
            int _9thDimLength = array.GetLength(9);
            T[,,,,,,,,] output = new T[_1stDimLength, _2ndDimLength, _3ndDimLength, _4thDimLength, _5thDimLength, _6thDimLength,
                _7thDimLength, _8thDimLength, _9thDimLength];

            for (int i = 0; i < _1stDimLength; i++)
                for (int j = 0; j < _2ndDimLength; j++)
                    for (int k = 0; k < _3ndDimLength; k++)
                        for (int l = 0; l < _4thDimLength; l++)
                            for (int m = 0; m < _5thDimLength; m++)
                                for (int n = 0; n < _6thDimLength; n++)
                                    for (int o = 0; o < _7thDimLength; o++)
                                        for (int p = 0; p < _8thDimLength; p++)
                                            for (int q = 0; q < _9thDimLength; q++)
                                            output[i, j, k, l, m, n, o, p, q] = array[index, i, j, k, l, m, n, o, p, q];

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

                if (expand == null && array.GetLength(0) <= 1)
                    rowDisplay = lastRow ? "─── " : rowDisplay;
                else
                    rowDisplay = lastRow ? isLastRow : rowDisplay;

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

                if (expand == null && array.GetLength(0) <= 1)
                    rowDisplay = lastRow ? "─── " : rowDisplay;
                else
                    rowDisplay = lastRow ? isLastRow : rowDisplay;

                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
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

                if (expand == null && array.GetLength(0) <= 1)
                    rowDisplay = lastRow ? "─── " : rowDisplay;
                else
                    rowDisplay = lastRow ? isLastRow : rowDisplay;

                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
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

                if (expand == null && array.GetLength(0) <= 1)
                    rowDisplay = lastRow ? "─── " : rowDisplay;
                else
                    rowDisplay = lastRow ? isLastRow : rowDisplay;

                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
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

                if (expand == null && array.GetLength(0) <= 1)
                    rowDisplay = lastRow ? "─── " : rowDisplay;
                else
                    rowDisplay = lastRow ? isLastRow : rowDisplay;

                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"5th Dimension layer {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _4Dim = array.Extract(i);

                var expander = lastRow ? "    " : "│   ";
                _4Dim.Printer(expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        public static void Printer<T>(this T[,,,,,] array, string expand = null)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;

                if (expand == null && array.GetLength(0) <= 1)
                    rowDisplay = lastRow ? "─── " : rowDisplay;
                else
                    rowDisplay = lastRow ? isLastRow : rowDisplay;

                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"6th Dimension layer {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _5Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _5Dim.Printer(expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        public static void Printer<T>(this T[,,,,,,] array, string expand = null)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;

                if (expand == null && array.GetLength(0) <= 1)
                    rowDisplay = lastRow ? "─── " : rowDisplay;
                else
                    rowDisplay = lastRow ? isLastRow : rowDisplay;

                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"7th Dimension layer {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _6Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _6Dim.Printer(expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        public static void Printer<T>(this T[,,,,,,,] array, string expand = null)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;

                if (expand == null && array.GetLength(0) <= 1)
                    rowDisplay = lastRow ? "─── " : rowDisplay;
                else
                    rowDisplay = lastRow ? isLastRow : rowDisplay;

                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"8th Dimension layer {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _7Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _7Dim.Printer(expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        public static void Printer<T>(this T[,,,,,,,,] array, string expand = null)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;

                if (expand == null && array.GetLength(0) <= 1)
                    rowDisplay = lastRow ? "─── " : rowDisplay;
                else
                    rowDisplay = lastRow ? isLastRow : rowDisplay;

                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"9th Dimension layer {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _8Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _8Dim.Printer(expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        public static void Printer<T>(this T[,,,,,,,,,] array, string expand = null)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                bool lastRow = i == array.GetLength(0) - 1;
                var isLastRow = lastRow ? "└── " : "├── ";
                var rowDisplay = i == 0 ? (expand == null ? "┌── " : "├── ") : isLastRow;

                if (expand == null && array.GetLength(0) <= 1)
                    rowDisplay = lastRow ? "─── " : rowDisplay;
                else
                    rowDisplay = lastRow ? isLastRow : rowDisplay;

                Console.Write($"{expand}{rowDisplay}");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"10th Dimension layer {i}");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _9Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _9Dim.Printer(expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
    }
}