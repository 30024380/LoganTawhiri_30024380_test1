//Name: Logan Tawhiri

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            // display intro
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------This Program will give the sum total of 5 prices------");
            Console.WriteLine("------------------------------------------------------------");
            Console.ReadLine();
           
            // the variable used later for total price
            double total = 0;

            // to display item number
            int counter = 1;

            // loops 5 times
            for (int start = 1; start <= 5; start++)
            {
                
                // asks the user for the price of items
                Console.Write($"Enter the price of item {counter}: ");
                total += double.Parse(Console.ReadLine());
                counter++;
            }
            Console.WriteLine(" ");
            // displays the total with a $
            Console.WriteLine("The total of those items is " + "$" + total);
            Console.ReadLine();
        }
    }
}
