using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Database d = new Database();
            int? userAge = d.GetUsersAge("Karabo");

            if (userAge.HasValue)
            {
                Console.WriteLine(userAge.Value);
            }
            else
            {
                Console.WriteLine("No valid age");
            }

            Console.ReadLine();
        }
    }
}
