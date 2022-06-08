using System;

namespace mathPower
{
    class Program
    {
        static double Power(double n, double times)
        {
            return Math.Pow(n, times);
        }
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double times = double.Parse(Console.ReadLine());
            Console.WriteLine(Power(n,times));
        }
    }
}

