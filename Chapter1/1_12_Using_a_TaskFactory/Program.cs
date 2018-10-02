using System;
using System.Threading.Tasks;

namespace _1_12_Using_a_TaskFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
            var results = new Int32[3];

            TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
                                             TaskContinuationOptions.ExecuteSynchronously);
            tf.StartNew(() => results[0] = 0);
            tf.StartNew(() => results[1] = 1);
            tf.StartNew(() => results[2] = 2);
            return results;

            });




            var finalTask = parent.ContinueWith(parentTask =>
            {
                foreach (int i in parentTask.Result)
                {
                    Console.WriteLine(i);
                }
            });

            finalTask.Wait(); // runs only after parent Task is finished, 
                              //  and the parent Task finishes when all 3 children are finished
        }
    }
}
