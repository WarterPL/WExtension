using System;
using System.Collections.Generic;
using System.Linq;

namespace W
{
    public static class WDictionary
    {
        public static void Print<TKey, TValue>(this Dictionary<TKey, TValue> dict)
        {
            TKey[] k = dict.Keys.ToArray();

            foreach (TKey key in k)
            {
                WConsole.WriteLine(key.ToString(), ConsoleColor.Cyan);
                WConsole.Write("└── ", ConsoleColor.DarkGray);
                WConsole.WriteLine(dict[key].ToString(), ConsoleColor.Green);
            }
        }
    }
}