using System;

namespace MetersToKms
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimer = Console.ReadLine();
            Console.WriteLine($"{firstName}{delimer}{lastName}");
        }
    }
}

