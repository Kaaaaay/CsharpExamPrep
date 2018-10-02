using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_15_Using_the_ParallelClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This loop sleeps every second
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            */


            Thread.Sleep(2000);
            Console.WriteLine("Start");

            Parallel.For(0,10,(i)=>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });
        }
    }
}
