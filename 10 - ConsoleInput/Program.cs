using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___ConsoleInput
{
    class Program
    {
        //Parse - Convert a String Into Something Else

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("What is your name?");
            string firstName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What's your Last name?");
            string lastName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hello {0} {1}",firstName, lastName);
            */

            Console.WriteLine("Enter a number...");
            int number = int.Parse(Console.ReadLine());

            number += 1000;
            Console.WriteLine("Total = {0}",number);


            Console.ReadLine();
        }
    }
}
