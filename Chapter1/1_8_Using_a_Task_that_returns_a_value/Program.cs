using System;
using System.Threading;
using System.Threading.Tasks;

namespace _1_8_Using_a_Task_that_returns_a_value
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 2;
            }).ContinueWith((i)=>
            {
                return i.Result * 3;
            });

            //Without t = it wil not work
            t = t.ContinueWith((i) =>
            {
                return i.Result / 3;
            });

            Console.WriteLine(t.Result); //We don't have to do a t.Wait, it will wait until function is done

        }
    }
}
