using System;

namespace sumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=1; i<=n;i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += (int)symbol;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}

