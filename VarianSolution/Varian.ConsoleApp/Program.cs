﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varian.BusinessLogic;

namespace Varian.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine(Service.IntToRoman(n));
            }
        }
    }
}
