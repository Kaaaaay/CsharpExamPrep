using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Access Modifiers
             * Allows us to control access to a member or class 
             * All situations have defaut access modifiers
             * public - accessible to everyone or everything
             * private - only accessible by the containing type / class
             * protected - 
             */

            Student student = new Student(10,77);
            Student student1 = new Student(15, 3);
            Student student3 = new Student(45, 90);
            Student student4 = new Student(50, 0);



            int ageOfStudent = student.age; // WE can access student.age because it is public

            student3.Grade = 50;
            Console.WriteLine("Student: " + student3.Grade);
            //Console.WriteLine("Student: " + student1.Grade);
            //Console.WriteLine("Student: " + student3.Grade);
            //Console.WriteLine("Student: " + student4.Grade);


        }
    }
}