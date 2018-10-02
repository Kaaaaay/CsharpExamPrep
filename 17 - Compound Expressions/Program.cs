using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Compound_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            // The &&(AND) Operator
            //True  && True     = True
            //True  && False    = False
            //False && True     = False
            //False && False    = False
            //AND is only TRUE when both conditions are TRUE


            //The || (OR) operator
            //True  || True     = True
            //True  || False    = True
            //False || True     = True
            //False || False    = False
            //OR is only FALSE when both conditions are FALSE

            Console.WriteLine("Parking Space App");
            const int allSpace = 50;

            Console.WriteLine("Please enter the number of parking spaces allocated."
                +"\n Please note that this number cannot be greater than 50.");

            int parkingSpaceAlloc = int.Parse(Console.ReadLine());





        }
    }
}
