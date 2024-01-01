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
        /*2D>1D*/
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
        /*3D>2D*/
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
        /*4D>3D*/
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
        /*5D>4D*/
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
        /*6D>5D*/
        public static T[,,,,] Extract<T>(this T[,,,,,] array, int index)
        {
            int _1stDimLength = array.GetLength(1);
            int _2ndDimLength = array.GetLength(2);
            int _3ndDimLength = array.GetLength(3);
            int _4thDimLength = array.GetLength(4);
            int _5thDimLength = array.GetLength(5);
            T[,,,,] output = new T[_1stDimLength, _2ndDimLength, _3ndDimLength, _4thDimLength, _5thDimLength];

            for (int i = 0; i < _1stDimLength; i++)
                for (int j = 0; j < _2ndDimLength; j++)
                    for (int k = 0; k < _3ndDimLength; k++)
                        for (int l = 0; l < _4thDimLength; l++)
                            for (int m = 0; m < _5thDimLength; m++)
                                output[i, j, k, l, m] = array[index, i, j, k, l, m];

            return output;
        }
        /*7D>6D*/
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
        /*8D>7D*/
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
        /*9D>8D*/
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
        /*10D>9D*/
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
        /*11D>10D*/
        public static T[,,,,,,,,,] Extract<T>(this T[,,,,,,,,,,] array, int index)
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
            int _10thDimLength = array.GetLength(10);
            T[,,,,,,,,,] output = new T[_1stDimLength, _2ndDimLength, _3ndDimLength, _4thDimLength, _5thDimLength, _6thDimLength,
                _7thDimLength, _8thDimLength, _9thDimLength, _10thDimLength];

            for (int i = 0; i < _1stDimLength; i++)
                for (int j = 0; j < _2ndDimLength; j++)
                    for (int k = 0; k < _3ndDimLength; k++)
                        for (int l = 0; l < _4thDimLength; l++)
                            for (int m = 0; m < _5thDimLength; m++)
                                for (int n = 0; n < _6thDimLength; n++)
                                    for (int o = 0; o < _7thDimLength; o++)
                                        for (int p = 0; p < _8thDimLength; p++)
                                            for (int q = 0; q < _9thDimLength; q++)
                                                for (int r = 0; r < _10thDimLength; r++)
                                                    output[i, j, k, l, m, n, o, p, q, r] = array[index, i, j, k, l, m, n, o, p, q, r];

            return output;
        }
        /*12D>11D*/
        public static T[,,,,,,,,,,] Extract<T>(this T[,,,,,,,,,,,] array, int index)
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
            int _10thDimLength = array.GetLength(10);
            int _11thDimLength = array.GetLength(11);
            T[,,,,,,,,,,] output = new T[_1stDimLength, _2ndDimLength, _3ndDimLength, _4thDimLength, _5thDimLength, _6thDimLength,
                _7thDimLength, _8thDimLength, _9thDimLength, _10thDimLength, _11thDimLength];

            for (int i = 0; i < _1stDimLength; i++)
                for (int j = 0; j < _2ndDimLength; j++)
                    for (int k = 0; k < _3ndDimLength; k++)
                        for (int l = 0; l < _4thDimLength; l++)
                            for (int m = 0; m < _5thDimLength; m++)
                                for (int n = 0; n < _6thDimLength; n++)
                                    for (int o = 0; o < _7thDimLength; o++)
                                        for (int p = 0; p < _8thDimLength; p++)
                                            for (int q = 0; q < _9thDimLength; q++)
                                                for (int r = 0; r < _10thDimLength; r++)
                                                    for (int s = 0; s < _11thDimLength; s++)
                                                        output[i, j, k, l, m, n, o, p, q, r, s] = array[index, i, j, k, l, m, n, o, p, q, r, s];

            return output;
        }

        public static void Print<T>(this List<T> lst) => lst.ToArray().Print();
        /*1D*/
        public static void Print<T>(this T[] array, string expand = null)
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

                WConsole.WriteLine(array[i].ToString(), ConsoleColor.DarkMagenta);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            if (expand == null)
                Console.ResetColor();
        }
        /*2D*/
        public static void Print<T>(this T[,] array, SecondDimMode sdm = SecondDimMode.List, string expand = null)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            if (sdm == SecondDimMode.List)
            {
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

                    WConsole.WriteLine($"Row number {i}", ConsoleColor.DarkBlue);
                    Console.ForegroundColor = ConsoleColor.DarkGray;

                    var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                    var _1Dim = array.Extract(i);
                    _1Dim.Print(expand + expander);
                }
            }
            if (sdm == SecondDimMode.Box || sdm == SecondDimMode.Plain)
            {
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
                    if(sdm == SecondDimMode.Box)
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            WConsole.Write($"\t<", ConsoleColor.DarkBlue);
                            WConsole.Write($"{array[i, j]}", ConsoleColor.DarkMagenta);
                            WConsole.Write($">", ConsoleColor.DarkBlue);
                        }
                    if(sdm == SecondDimMode.Plain)
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            WConsole.Write($"{array[i, j]}", ConsoleColor.White);
                        }

                    Console.WriteLine();
                }
            }

            if (expand == null)
                Console.ResetColor();
        }
        /*3D*/
        public static void Print<T>(this T[,,] array, SecondDimMode sdm = SecondDimMode.List, string expand = null)
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

                WConsole.WriteLine($"Thickness {i}", ConsoleColor.DarkCyan);
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _2Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _2Dim.Print(sdm, expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        /*4D*/
        public static void Print<T>(this T[,,,] array, SecondDimMode sdm = SecondDimMode.List, string expand = null)
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

                WConsole.WriteLine($"4th Dimension layer {i}", ConsoleColor.DarkGreen);
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _3Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _3Dim.Print(sdm, expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        /*5D*/
        public static void Print<T>(this T[,,,,] array, SecondDimMode sdm = SecondDimMode.List, string expand = null)
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

                WConsole.WriteLine($"5th Dimension layer {i}", ConsoleColor.DarkYellow);
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _4Dim = array.Extract(i);

                var expander = lastRow ? "    " : "│   ";
                _4Dim.Print(sdm, expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        /*6D*/
        public static void Print<T>(this T[,,,,,] array, SecondDimMode sdm = SecondDimMode.List, string expand = null)
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

                WConsole.WriteLine($"6th Dimension layer {i}", ConsoleColor.DarkRed);
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _5Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _5Dim.Print(sdm, expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        /*7D*/
        public static void Print<T>(this T[,,,,,,] array, SecondDimMode sdm = SecondDimMode.List, string expand = null)
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

                WConsole.WriteLine($"7th Dimension layer {i}", ConsoleColor.Magenta);
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _6Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _6Dim.Print(sdm, expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        /*8D*/
        public static void Print<T>(this T[,,,,,,,] array, SecondDimMode sdm = SecondDimMode.List, string expand = null)
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

                WConsole.WriteLine($"8th Dimension layer {i}", ConsoleColor.Blue);
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _7Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _7Dim.Print(sdm, expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        /*9D*/
        public static void Print<T>(this T[,,,,,,,,] array, SecondDimMode sdm = SecondDimMode.List, string expand = null)
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

                WConsole.WriteLine($"9th Dimension layer {i}", ConsoleColor.Cyan);
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _8Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _8Dim.Print(sdm, expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        /*10D*/
        public static void Print<T>(this T[,,,,,,,,,] array, SecondDimMode sdm = SecondDimMode.List, string expand = null)
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

                WConsole.WriteLine($"10th Dimension layer {i}", ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _9Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _9Dim.Print(sdm, expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        /*11D*/
        public static void Print<T>(this T[,,,,,,,,,,] array, SecondDimMode sdm = SecondDimMode.List, string expand = null)
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

                WConsole.WriteLine($"11th Dimension layer {i}", ConsoleColor.Yellow);
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _10Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _10Dim.Print(sdm, expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }
        /*12D*/
        public static void Print<T>(this T[,,,,,,,,,,,] array, SecondDimMode sdm = SecondDimMode.List, string expand = null)
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

                WConsole.WriteLine($"12th Dimension layer {i}", ConsoleColor.Red);
                Console.ForegroundColor = ConsoleColor.DarkGray;

                var _11Dim = array.Extract(i);

                var expander = i == array.GetLength(0) - 1 ? "    " : "│   ";
                _11Dim.Print(sdm, expand + expander);
            }
            if (expand == null)
                Console.ResetColor();
        }

        public static int[] Generate(this int[] array, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
                array[i] = rnd.Next(min, max + 1);
            return array;
        }
        public static int[,] Generate(this int[,] array, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = rnd.Next(min, max + 1);
            return array;
        }
        public static int[,,] Generate(this int[,,] array, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        array[i, j, k] = rnd.Next(min, max + 1);
            return array;
        }
        public static int[,,,] Generate(this int[,,,] array, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        for (int l = 0; l < array.GetLength(3); l++)
                            array[i, j, k, l] = rnd.Next(min, max + 1);
            return array;
        }
        public static int[,,,,] Generate(this int[,,,,] array, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        for (int l = 0; l < array.GetLength(3); l++)
                            for (int m = 0; m < array.GetLength(4); m++)
                                array[i, j, k, l, m] = rnd.Next(min, max + 1);
            return array;
        }

        public static float[] Generate(this float[] array, int min, int max, GenerateMode gm = GenerateMode.FloatingPoint)
        {
            WRandom rnd = new WRandom();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = gm == GenerateMode.Integer ?
                    rnd.Next(min, max)
                    :
                    (float)rnd.NextDouble(min, max);
            }
            return array;
        }
        public static float[,] Generate(this float[,] array, int min, int max, GenerateMode gm = GenerateMode.FloatingPoint)
        {
            WRandom rnd = new WRandom();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = gm == GenerateMode.Integer ?
                        rnd.Next(min, max)
                        :
                        (float)rnd.NextDouble(min, max);
                }
            return array;
        }
        public static float[,,] Generate(this float[,,] array, int min, int max, GenerateMode gm = GenerateMode.FloatingPoint)
        {
            WRandom rnd = new WRandom();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = gm == GenerateMode.Integer ?
                            rnd.Next(min, max)
                            :
                            (float)rnd.NextDouble(min, max);
                    }
            return array;
        }
        public static float[,,,] Generate(this float[,,,] array, int min, int max, GenerateMode gm = GenerateMode.FloatingPoint)
        {
            WRandom rnd = new WRandom();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        for (int l = 0; l < array.GetLength(3); l++)
                        {
                            array[i, j, k, l] = gm == GenerateMode.Integer ?
                                rnd.Next(min, max)
                                :
                                (float)rnd.NextDouble(min, max);
                        }
            return array;
        }
        public static float[,,,,] Generate(this float[,,,,] array, int min, int max, GenerateMode gm = GenerateMode.FloatingPoint)
        {
            WRandom rnd = new WRandom();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        for (int l = 0; l < array.GetLength(3); l++)
                            for (int m = 0; m < array.GetLength(4); m++)
                            {
                                array[i, j, k, l, m] = gm == GenerateMode.Integer ?
                                    rnd.Next(min, max)
                                    :
                                    (float)rnd.NextDouble(min, max);
                            }
            return array;
        }

        public static double[] Generate(this double[] array, int min, int max, GenerateMode gm = GenerateMode.FloatingPoint)
        {
            WRandom rnd = new WRandom();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = gm == GenerateMode.Integer ?
                    rnd.Next(min, max)
                    :
                    rnd.NextDouble(min, max);
            }
            return array;
        }
        public static double[,] Generate(this double[,] array, int min, int max, GenerateMode gm = GenerateMode.FloatingPoint)
        {
            WRandom rnd = new WRandom();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = gm == GenerateMode.Integer ?
                        rnd.Next(min, max)
                        :
                        rnd.NextDouble(min, max);
                }
            return array;
        }
        public static double[,,] Generate(this double[,,] array, int min, int max, GenerateMode gm = GenerateMode.FloatingPoint)
        {
            WRandom rnd = new WRandom();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = gm == GenerateMode.Integer ?
                            rnd.Next(min, max)
                            :
                            rnd.NextDouble(min, max);
                    }
            return array;
        }
        public static double[,,,] Generate(this double[,,,] array, int min, int max, GenerateMode gm = GenerateMode.FloatingPoint)
        {
            WRandom rnd = new WRandom();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        for (int l = 0; l < array.GetLength(3); l++)
                        {
                            array[i, j, k, l] = gm == GenerateMode.Integer ?
                                rnd.Next(min, max)
                                :
                                rnd.NextDouble(min, max);
                        }
            return array;
        }
        public static double[,,,,] Generate(this double[,,,,] array, int min, int max, GenerateMode gm = GenerateMode.FloatingPoint)
        {
            WRandom rnd = new WRandom();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        for (int l = 0; l < array.GetLength(3); l++)
                            for (int m = 0; m < array.GetLength(4); m++)
                            {
                                array[i, j, k, l, m] = gm == GenerateMode.Integer ?
                                    rnd.Next(min, max)
                                    :
                                    rnd.NextDouble(min, max);
                            }
            return array;
        }
    }
    public enum SecondDimMode
    {
        List,
        Box,
        Plain
    }
    public enum GenerateMode
    {
        Integer,
        FloatingPoint
    }
}