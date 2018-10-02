using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace _1_35_AccesingSharedData
{
    // Accessing Shared Data in a MultiThreaded Application
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Task myTask = Task.Run(() => 
            {
                for (int i = 0; i < 1000000; i++)
                {
                    n++;
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                n--;
            }

            myTask.Wait(); // Without this, it will print n without all tasks being done
            Console.WriteLine(n);
        }
    }
}
