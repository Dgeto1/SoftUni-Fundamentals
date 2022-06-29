using System;
using System.Numerics;

namespace _02_BigFactorial
{
    class Program
    {
        public static long Factorial(long n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
    }
}

