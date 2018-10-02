using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> emps = new List<Person>();

            Student s = new Student();
            s.Name = "Kay";
            s.Age = 17;
            s.GradeLevel = 12;

            Employee e = new Employee();
            e.Name = "Kay";
            e.Age = 21;
            e.ID = "hhkfkfkf";


            emps.Add(s);
            emps.Add(e);

            foreach (Person p in emps)
            {
                if (p is Student)
                {
                    Student temp = p as Student;
                    Console.WriteLine(temp.GradeLevel);

                }
                else if (p is Employee)
                {
                    Employee temp = p as Employee;
                    Console.WriteLine(temp.ID);
                }
            }
            /*
             * Common to Lists/Collections
            emps.Add(new Employee());
            emps.Add(new Student());

            Person p = new Employee();
            //Take whatever [Person p] is and treat it as an employee
            Employee e = p as Employee; // if conversion is unsuccessful, it returns null
            //Now you can access employee data again with intellisence
            if (e != null)
            {
                
            }
            */



            Console.ReadLine();
        }
    }
}
