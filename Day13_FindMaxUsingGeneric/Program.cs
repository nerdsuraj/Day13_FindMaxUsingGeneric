﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_FindMaxUsingGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Find The Maximum Program");
            int output = FindMaxNumber.MaximumIntegerNumber(20,52,56);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
