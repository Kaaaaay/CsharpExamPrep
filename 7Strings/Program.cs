using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "One Love";

            string name1 = "Rocco";
            string name2 = "Morocco";

            //bool namesEqual = name1 == name2;
            //bool namesEqual = string.Equals(name1, name2);


            //int namesEqual = string.Compare(name1, name2); //Names equal 0, which means true. If false it will check which comes first alphabetically

            int namesEqual = name1.CompareTo(name2);


            Console.WriteLine("{0} has {1} characters", name1,name1.Length);
            
            //The Substring Method returns the index of the string and the number of charecters
            string firstCharOfName = name2.Substring(0, 1);
            Console.WriteLine(firstCharOfName);

            string middleSectionOfName = name1.Substring(1, 3);
            Console.WriteLine(middleSectionOfName);

            bool startsWith = myString.StartsWith("On");
            Console.WriteLine(startsWith);

            Console.ReadLine();
        }
    }
}