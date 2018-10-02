using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit cast, not losing any data
            int x = 10;
            double y = x;

            //Explicit cast
            double myDouble = 5.5;
            int myInt = (int)myDouble; // (int)myDouble will forcefully convert to int, it's called casting
        }
    }
}
