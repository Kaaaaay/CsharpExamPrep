using System;
using System.Threading;

namespace _1_5_Using_the_ThreadStaticAttribute
{
    class Program
    {
        [ThreadStatic] //This lets each thread have its own version of the data
        public static int _field;

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(() =>
            {
               for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}",_field);
                }
            }));
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }));
            t2.Start();

        }
    }
}
