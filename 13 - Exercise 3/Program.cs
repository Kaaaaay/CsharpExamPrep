using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Exercise_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            Console.WriteLine("Guess the number between 1 and 10 ");
            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber > randomNumber)
            {
                Console.WriteLine("That was a tad too high :(. The correct number was {0}", randomNumber);
            }
            else if (guessedNumber < randomNumber)
            {
                Console.WriteLine("{0} is the correct number.Yours was a bit too low :(", randomNumber);
            }
            else
            {
                Console.WriteLine("{0}, is the correct number. You killed it!", randomNumber);
            }

            Console.ReadLine();
        }
    }
}
