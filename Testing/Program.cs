using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W;
using W.Games;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WTicTacToe ttt = new WTicTacToe(false, true);
            ttt.StartGame();
            Console.ReadLine();
        }
        static void ArrayPrinterTest()
        {
            int[] arg1 = { 1, 2, 3, 4, 5, 6 };
            int[,] arg2 =
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10}
            };
            int[,,] arg3 =
            {
                {
                    { 1, 2, 3, 4, 5 },
                    { 6, 7, 8, 9, 10}
                },
                {
                    {11, 12, 13, 14, 15 },
                    {16, 17, 18, 19, 20 }
                }
            };
            int[,,,] arg4 =
            {
                {
                {
                    { 1, 2, 3, 4, 5 },
                    { 6, 7, 8, 9, 10}
                },
                {
                    {11, 12, 13, 14, 15 },
                    {16, 17, 18, 19, 20 }
                }
                },
                {
                {
                    { 21, 22, 23, 24, 25},
                    { 26, 27, 28, 29, 30}
                },
                {
                    {31, 32, 33, 34, 35 },
                    {36, 37, 38, 39, 40 }
                }
                }
            };
            int[,,,,] arg5 =
            {
                {
                    {
                        {
                            {1, 2, 3 },
                            { 4, 5, 6 }
                        },
                        {
                            {6, 7, 8},
                            { 9, 10, 11}
                        }
                    },
                    {
                        {
                            {12,13,14 },
                            {15,16,17}
                        },
                        {
                            {18,19,20 },
                            {21,22,23}
                        }
                    }
                },
                {
                    {
                        {
                            {24,25, 26 },
                            {27,28,29 }
                        },
                        {
                            {30,31,32 },
                            {33,34,35 }
                        }
                    },
                    {
                        {
                            {36,37,38 },
                            {39,40,41 }
                        },
                        {
                            {42,43,44 },
                            {45,46,47 }
                        }
                    }
                }
            };
            arg1.Printer();
            arg2.Printer();
            arg3.Printer();
            arg4.Printer();
            arg5.Printer();

            List<string> list = new List<string>();
            list.Add("Bożydar");
            list.Add("Bożydar");
            list.Add("Bożydar");
            list.Add("Bożydar");
            list.Add("Bożydar");

            list.Printer();
        }
    }
}
