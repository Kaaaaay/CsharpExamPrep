using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture
{
    class Employee: Person
    {
        public string ID { get; set; }
        
        public void IntroduceSelf()
        {
            Console.WriteLine($"Hello, My name is {Name}  and my ID is {ID}");
        }
    }
}
