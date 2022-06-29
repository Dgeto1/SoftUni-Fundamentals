using System;

namespace smallestOf3Numbers
{
    class Program
    {
        static int SmallestNumber(int num1,int num2,int num3)
        {
           int min = Math.Min(num1,num2);
            return Math.Min(min, num3);
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNumber(num1,num2,num3));
        }
    }
}

