using System;

namespace _18___Implementing_a_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] array = { };
            decimal maximum = Program.Maximum(null);
        }

        static decimal Maximum(decimal[] values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values), "Argument Null Exception");
            if (values.Length == 0)
                throw new ArgumentException("Array cannot be empty", nameof(values));
            decimal biggestSoFar = 0.0m;
            foreach (decimal value in values)
            {
                if (value > biggestSoFar)
                {
                    biggestSoFar = value;
                }
                return biggestSoFar;
            }
        }
    }
}
