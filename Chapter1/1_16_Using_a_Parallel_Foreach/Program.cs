using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_16_Using_a_Parallel_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /*
            foreach (int x in myArray)
            {
                Console.WriteLine(x);
                Thread.Sleep(1000);
            }
            */
            Thread.Sleep(2000);
            Console.WriteLine("Start");

            Parallel.ForEach(myArray, (i) =>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });
        }   
    }
}
