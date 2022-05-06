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

            Console.WriteLine("......................................................");

            Console.WriteLine("Maximum float value");
            double doubleoutput = FindFlotMaxNumber.MaximumFloatNumber(56.25, 99.56, 88.46);
            Console.WriteLine(doubleoutput);

            Console.WriteLine("......................................................");

            Console.WriteLine("Maximum String value");
            string stringoutput = FindStringMax.MaximumString("suraj", "azad", "rajesh");
            Console.WriteLine(stringoutput);
            Console.WriteLine();

            Console.WriteLine("......................................................");

            int[] intArray = { 5230, 1534, 4568, 4522 };
            FindMaxUsingGeneric<int> generic = new FindMaxUsingGeneric<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 56.90, 9.871, 56.49, 30.12 };
            FindMaxUsingGeneric<double> genericDouble = new FindMaxUsingGeneric<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "karan", "raju", "bibek", "indal" };
            FindMaxUsingGeneric<string> genericString = new FindMaxUsingGeneric<string>(stringArray);
            genericString.PrintMaxValue();

            Console.ReadKey();

        }
    }
}
