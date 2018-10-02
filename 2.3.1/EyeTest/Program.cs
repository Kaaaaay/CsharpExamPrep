using System;

namespace EyeTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            ITest s2 = s;
            s.HelloWorld();
        }
    }
}
