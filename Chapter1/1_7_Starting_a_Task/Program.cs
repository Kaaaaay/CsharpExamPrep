using System;
using System.Threading;
using System.Threading.Tasks;

namespace _1_7_Starting_a_Task
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 100; i++)
                {
                    Console.Write('*');
                } 
        }
        static void Main(string[] args)
        {
            Task t = Task.Run(action: ThreadMethod);

            /*
            Task t = Task.Run(() =>
            {
                
                for (int i = 0; i < 100; i++)
                {
                    Console.Write('*');
                } 
            });
            */
            t.Wait();
        }
    }
}
