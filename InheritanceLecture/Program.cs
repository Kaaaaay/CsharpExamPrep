using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Name = "Kay";
            e.Age = 21;
            e.ID = "hhkfkfkf";

            e.IntroduceSelf();
            Console.ReadLine();
        }
    }
}
