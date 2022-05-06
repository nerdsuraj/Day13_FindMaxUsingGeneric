using System;
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
            int output = FindMaxNumber.MaximumIntegerNumber(20, 52, 56);
            Console.WriteLine(output);

           

            Console.WriteLine("Maximum float value");
            double doubleoutput = FindFlotMaxNumber.MaximumFloatNumber(22.11, 7.01, 29.02);
            Console.WriteLine(doubleoutput);

            Console.ReadKey();

        }
    }
}
