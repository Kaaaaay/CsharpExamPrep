using System;
using System.Diagnostics;
using System.Threading;
using System.   


namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeIt(SequentialChancesToWin);
            TimeIt(TaskBasedChancesToWin);
        }

        private static void TimeIt(Action action)
        {
            Stopwatch timer = Stopwatch.StartNew();
            action();
            Console.WriteLine(timer.Elapsed);
        }

        private static void SequentialChancesToWin()
        {
            BigInteger n = 49000;
            BigInteger r = 600;

            BigInteger part1 = Factorial(n);
            BigInteger part2 = Factorial(n - r);
            BigInteger part3 = Factorial(r);

        }
        static BigInteger Factorial(BigInteger factor)
        {
            BigInteger factorial = 1;
        }

        private static void TaskBasedChancesToWin()
        {
            BigInteger n = 49000;
            BigInteger r = 600;

            Task<BigInteger> part1 = Task <BigInteger>.StartNew(() => Factorial(n));
            Task<BigInteger> part2 = Task<BigInteger>.StartNew(() => Factorial(n - r));
            Task<BigInteger> part3 = Task<BigInteger>.StartNew(() => Factorial(r));

            BigInteger chances = part1.Result / (part2.Result * part3.Result);

            Console.WriteLine(chances);
        }

    }
}
