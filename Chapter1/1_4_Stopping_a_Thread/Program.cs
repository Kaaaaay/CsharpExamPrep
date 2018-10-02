using System;
using System.Threading;

namespace _1_4_Stopping_a_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopped = false;
            Thread t = new Thread(new ThreadStart (()=>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Thread is about to close...");
            }));

            t.Start();
            Console.WriteLine("Press any key to continue");

            Console.ReadKey();
            stopped = true;
            t.Join();
        }
    }
}
