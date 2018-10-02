using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AGE -- APP");
            Console.Write("Please enter your age: \t");
            int age = int.Parse(Console.ReadLine());

            if (age >= 21)
            {
                Console.WriteLine("You can enter the club");
            }
            else
            {
                Console.WriteLine("Go home pikinin");
            }
            Console.ReadLine();

        }
    }
}
