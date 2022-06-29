using System;

namespace StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int years = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}, Age: {years}, Grade: {grade:f2}");
        }
    }
}

