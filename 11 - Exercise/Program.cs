using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            /*Build a simple calculator. Read in two integers from the user and add them together. Print the results
             * in a nice output statement
             */
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Total = {0} + ",firstNumber);
            int secondNumber = int.Parse(Console.ReadLine());

            int total = firstNumber + secondNumber;
            Console.Write("The two numbers added together equal: {0}",total);

            Console.ReadLine();
        }
    }
}
