using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAClass
{
    class Student
    {
        public string Name;
        public int Age;
        public double finalGrade;

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}",Name);
        }
    }
}
