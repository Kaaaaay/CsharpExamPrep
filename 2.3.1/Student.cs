using System;
namespace Application
{
    class Student
    {
        public int age { get; private set; } // read-only property
        private double grade;
        //private string name;

        public double Grade
        {
            get
            {
                if (age >= 15)
                {
                    return grade;
                }
                else
                {
                    Console.WriteLine("Young lad bud");
                    return 0;
                }
            }
            set
            {
                if (value <=0)
                {
                    Console.WriteLine("Invalid value");
                    return;
                }
                else
                {
                    grade = value;
                }
            }
        }



        public Student(int a, int g)
        {
            this.age = a;
            this.grade = g;
        }

        public void Test()
        {
            //this.name = "OK";
        }
    }
}