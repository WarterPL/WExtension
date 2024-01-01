using System;
using System.Collections;
using System.Collections.Generic;
using W;
using W.Games;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string k = "1";
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Klucz1", k);
            d.Add("Klucz2", k);
            d.Add("Klucz3", k);
            d.Add("Klucz4", k);
            d.Add("Klucz5", k);
            d.Add("Klucz6", k);
            d.Add("Klucz7", k);
            d.Add("Klucz8", k);
            d.Add("Klucz9", k);
            d.Add("Klucz10", k);
            d.Print();

            WConsole.ReadLine();
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
            int[,,,,,] arg6 =
            {
                {
                    {
                        {
                            {
                                {1,2,3,4,5}
                            }
                        }
                    }
                }
            };
            int[,,,,,,] arg7 =
            {
                {
                    {
                        {
                            {
                                {
                                    {1,2,3,4,5}
                                }
                            }
                        }
                    }
                }
            };
            int[,,,,,,,] arg8 =
            {
                {
                    {
                        {
                            {
                                {
                                    {
                                        {1,2,3,4,5}
                                    }
                                }
                            }
                        }
                    }
                }
            };
            int[,,,,,,,,] arg9 =
            {
                {
                    {
                        {
                            {
                                {
                                    {
                                        {
                                            {1,2,3,4,5}
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            int[,,,,,,,,,] arg10 =
            {
                {
                    {
                        {
                            {
                                {
                                    {
                                        {
                                            {
                                                {1,2,3,4,5}
                                            }
                                        }
                                    }
                                },
                                {
                                    {
                                        {
                                            {
                                                {6,7,8,9,10 }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            int[,,,,,,,,,,] arg11 =
            {
                {
                    {
                        {
                            {
                                {
                                    {
                                        {
                                            {
                                                {
                                                    {1,2,3,4,5}
                                                }
                                            }
                                        }
                                    }
                                },
                                {
                                    {
                                        {
                                            {
                                                {
                                                    {6,7,8,9,10 }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            int[,,,,,,,,,,,] arg12 =
            {
                {
                    {
                        {
                            {
                                {
                                    {
                                        {
                                            {
                                                {
                                                    {
                                                        {1,2,3,4,5}
                                                    },
                                                    {
                                                        {6,7,8,9,10}
                                                    }
                                                }
                                            }
                                        }
                                    }
                                },
                                {
                                    {
                                        {
                                            {
                                                {
                                                    {
                                                        {11,12,13,14,15 }
                                                    },
                                                    {
                                                        {16,17,18,19,20 }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            /*arg1.Print();
            arg2.Print();
            arg3.Print();
            arg4.Print();
            arg5.Print();
            arg6.Print();
            arg7.Print();
            arg8.Print();
            arg9.Print();
            arg10.Print();
            arg11.Print();*/
            arg12.Print();

            /*List<string> list = new List<string>();
            list.Add("Bożydar");
            list.Add("Bożydar");
            list.Add("Bożydar");
            list.Add("Bożydar");
            list.Add("Bożydar");

            list.Print();*/
        }
        static void TTT(bool usrStart = true, bool experiment = false)
        {
            WTicTacToe ttt = new WTicTacToe(usrStart, experiment);
            ttt.StartGame();
        }
    }
}
