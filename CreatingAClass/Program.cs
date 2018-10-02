using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "One";
            s1.Age = 21;
            s1.finalGrade = 98;
            s1.SayHello();

            Student s2 = new Student();
            s2.Name = "Two";
            s2.Age = 11;
            s2.finalGrade = 100;
            s2.SayHello();

            Student s3 = new Student();
            s3.Name = "John";
            s3.Age = 55;
            s3.finalGrade = 10;
            s3.SayHello();

            Random r = new Random();
            r.Next();

            Console.ReadLine();
        }
    }
}
