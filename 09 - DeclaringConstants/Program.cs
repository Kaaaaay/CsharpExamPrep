using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___DeclaringConstants
{
    class Program
    {
             /* Enum
             * A group of constants
             */
        enum DaysofWeek
        {                   //Default Indexing
            Sunday,         // 0
            Monday,         // 1
            Tuesday,        // 2
            Wednesday,      // 3
            Thursday,       // 4
            Friday,         // 5
            Saturday        // 6
        }
        static void Main(string[] args)
        {
            const int myIntConst = 10;

            // myIntConst = 7; - will give an error

            // PI constant by Microsoft - Math.PI = 6;

            Console.WriteLine(Math.PI);


            DayOfWeek today = DayOfWeek.Sunday;
            Console.WriteLine(today);
            int numberOfToday = (int)today; // Casting number of today to an 
            Console.WriteLine(numberOfToday);


            Console.ReadLine();
        }
    }
}
