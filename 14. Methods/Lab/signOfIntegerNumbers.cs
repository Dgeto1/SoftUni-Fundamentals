using System;

namespace SignOfIntNums
{
    class Program
    {
        static void CheckNumber(int num)
        {
            
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            CheckNumber(num);
        }
    }
}

