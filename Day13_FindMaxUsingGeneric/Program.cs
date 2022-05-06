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
            double doubleoutput = FindFlotMaxNumber.MaximumFloatNumber(56.25, 99.56, 88.46);
            Console.WriteLine(doubleoutput);


            Console.WriteLine("Maximum String value");
            string stringoutput = FindStringMax.MaximumString("suraj", "azad", "rajesh");
            Console.WriteLine(stringoutput);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
