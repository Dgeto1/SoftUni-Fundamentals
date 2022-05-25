using System;

namespace MetersToKms
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double km = meters / 1000.00;
            Console.WriteLine($"{km:f2}");
        }
    }
}

