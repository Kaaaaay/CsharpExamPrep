using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carpenting Cost Calculator - CCC");
            const double pricePerSquareFoot = 14.50;
            Console.WriteLine("Please enter the length");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width");
            int width = int.Parse(Console.ReadLine());

            double total = (length * width) / pricePerSquareFoot;

            Console.WriteLine("The total cost of carperting for a {0} x {1} room is R{2}",length,width,total);
            Console.ReadLine();
        }
    }
}
