﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WClasses;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string showme = WConsole.ReadString("nword? : ");
            Console.WriteLine(showme);

            Console.ReadLine();
        }
    }
}
