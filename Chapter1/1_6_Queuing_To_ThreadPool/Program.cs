using System;
using System.Threading;

namespace _1_6_Queuing_To_ThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s)=>
            {
              Console.WriteLine("Working on a thread from the ThreadPool");
            });
            Console.ReadLine();
        }
    }
}
