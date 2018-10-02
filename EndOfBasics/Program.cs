
//Comments
/* Comments
*/

//Namespaces
using System;

namespace EndOfBasics
{

    //Classes
    class Program
    {
        //Main method
        static void Main(string[] args)
        {
            //Variables
            //Numeric data types
            decimal principal;
            decimal interestRate;
            decimal monthlyPayment;


            //Statements
            //Loops
            //Booleans

            while (true)
            {
                //String literals
                //User defined static methods
                //Assignment to variables with

                principal = ReadPositiveDecimal("Please enter principal amount");
                interestRate = ReadPositiveDecimal("Please enter interest rate");
                monthlyPayment = ReadPositiveDecimal("Please enter monthly payment");

                //Complex expressions
                //if statements
                if (principal * interestRate / 1200 < monthlyPayment)
                {
                    break;
                }
                Console.WriteLine("The monthly payment does not cover the interest");
            }

            decimal totalInterest = TotalInterest(principal, interestRate, monthlyPayment);

            // Currency formatting
            Console.WriteLine("Your total interest is {0:C2}", totalInterest);

            // String interpolation -- new for C# 6
            Console.WriteLine($"Your total interest is {totalInterest:C2}.");

            // Date formatting
            // Date arithmetic
            int months = PayoffMonths(principal, interestRate, monthlyPayment);
            Console.WriteLine("Payoff date is {0:MMM yyyy}",DateTime.Now.AddMonths(months));

            //Arrays
            //Array initializers

            decimal[] extraPayments = { 100.00m, 300.0m, 1000.0m };

            //foreach loop
            //Implicitly-typed local variables

            foreach (var extraPayment in extraPayments)
            {
                var newInterest = TotalInterest(principal, interestRate, monthlyPayment + extraPayment);
                var newMonths = PayoffMonths(principal, interestRate, monthlyPayment + extraPayment);

                Console.WriteLine("Extra payment of {0:C2} reduces interest by {1:C2}, months:{2}",extraPayment,
                                  totalInterest-newInterest,months-newMonths);
            }
        }

        private static decimal ReadPositiveDecimal(string prompt)
        {
            //Reading and checking user input
            decimal result;
            while (true)
            {
                Console.WriteLine(prompt);
                string principalText = Console.ReadLine();
                bool success = decimal.TryParse(principalText, out result);

                //logical operations on Booleans
                if (!success)
                {
                    Console.WriteLine("Please enter a decimal value");
                }
                else if (result<0.0m)
                {
                    Console.WriteLine("Please enter a positive value");
                }
                else
                {
                    return result;
                }
            }

        }

        static decimal TotalInterest(decimal principal, decimal interestRate)
        {

        }
    }
}
