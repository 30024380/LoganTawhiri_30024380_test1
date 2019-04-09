//Name: Logan Tawhiri

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            // display intro
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("-------This program can give the result of base^exponent-------");
            Console.WriteLine("---------------------------------------------------------------");

            // Asks the user for the value of base
            Console.Write("Enter the value of the base: ");
            double base1 = double.Parse(Console.ReadLine());

            // Asks the user for the value of exponent
            Console.Write("Enter the value of the exponent: ");
            int exponent1 = int.Parse(Console.ReadLine());

            //Can't remember how to do power of
            double result = base1 * base1;

            // Displays the result
            Console.WriteLine($"{base1}^{exponent1} = {result}");
            Console.ReadLine();
          


        }
    }
}
