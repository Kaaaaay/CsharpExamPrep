using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___IfElse
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Vending Machine App");
            Console.Write("\nInsert Cash $");
            double machankura = double.Parse(Console.ReadLine());
            Console.WriteLine("What would you like to have?");
            Console.WriteLine();
            Console.WriteLine("1) Snacks \n2) Juice \n3) Chocolate ");
            int userSelection = int.Parse(Console.ReadLine());

            double[] products = new double[3];
            products[0] = 7.50;
            products[1] = 10.50;
            products[2] = 15.90;


            double change;
            double insertMore;

            if (userSelection == 1)
            {
                if (machankura > products[0])
                {
                    change = machankura - products[0];
                    Console.WriteLine("Snacks huh, here you go. Your change is {0:C}", change);
                }
                else
                {
                    insertMore = products[0] - machankura;
                    Console.WriteLine("Nope, you can't have that with the amount you inserted. " +
                        "You need to insert {0:C} more.", insertMore);
                }
            }
            else if (userSelection == 2)
            {
                if (machankura > products[1])
                {
                    change = machankura - products[1];
                    Console.WriteLine("iJuice, here you go. Your change is {0:C}", change);
                }
                else
                {
                    insertMore = products[1] - machankura;
                    Console.WriteLine("Nope, you can't have that with the amount you inserted. " +
                        "You need to insert {0:C} more.", insertMore);
                }

            }
            else
            {
                if (machankura > products[2])
                {
                    change = machankura - products[2];
                    Console.WriteLine("Choco-Choco, here you go. Your change is {0:C}", change);
                }
                else
                {
                    insertMore = products[2] - machankura;
                    Console.WriteLine("Not possible, You need to insert {0:C} more.", insertMore);
                }
            }

            Console.ReadLine();
        }
    }
}
