using System;

namespace MetersToKms
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {city} has population of {population} and area {area} square km.");
        }
    }
}

