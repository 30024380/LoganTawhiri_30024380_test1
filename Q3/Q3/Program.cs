//Name: Logan Tawhiri

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            //display intro
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("-----Can you solve the following algebraic expression:-----");
            Console.WriteLine("---------------------2(x - 3) + x = 12---------------------");
            Console.WriteLine("-----------------------------------------------------------");
            Console.ReadLine();

            // the value of x
            int x = 6;

            // the users guess
            int guess;

            // asking the user to guess x
            Console.Write("Enter your guess for the value of x: ");
            guess = int.Parse(Console.ReadLine());

            // If users guess is = to the answer display that they were correct
            if (guess == x)
            {
                Console.WriteLine(" ");
                Console.WriteLine("That guess was correct");
            }
            // If users guess was incorrect display that they were incorrect
            else
            {
                Console.WriteLine(" ");              
                Console.WriteLine("That guess was incorrect");
            }
            Console.ReadLine();
            
            /*  
                2(x-3) + x = 12
                2 * x + 2 * -3 + x = 12
                2x - 6 + x = 12
                3x - 6 = 12
                3x - 6 + 6 = 12 + 6
                3x = 18
                x = 6 
            */
        }
    }
}
