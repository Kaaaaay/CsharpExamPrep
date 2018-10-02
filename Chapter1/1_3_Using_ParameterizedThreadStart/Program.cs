using System;
using System.Threading;

namespace _1_3_Using_ParameterizedThreadStart
{
    class Program
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int) o; i++)
            {
                Console.WriteLine("ThreadProc: {0}",i);
                Thread.Sleep(0);
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(15); //It will parse in this value and print 15 times
            t.Join();
        }
    }
}
