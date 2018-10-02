using System;
using System.Threading;
using System.Threading.Tasks;

namespace _1_10_Adding_a_Continuation
{
     class Program
        {
            static void Main(string[] args)
            {
            Task<int> t = Task.Run(() =>
            {
                //throw new Exception();
                return 2;
            });

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");
            },TaskContinuationOptions.OnlyOnFaulted);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Successful");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);


             Console.WriteLine(t.Result); //We don't have to do a t.Wait, it will wait until function is done

            }
        }
}
