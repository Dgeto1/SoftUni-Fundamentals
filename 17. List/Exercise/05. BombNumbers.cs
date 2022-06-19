using System;
using System.Linq;
using System.Collections.Generic;

namespace bombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int i=0; i<numbers.Count;i++)
            {
                if (numbers[i] == bomb[0])
                {
                    int start = Math.Max(0, i - bomb[1]);
                    int end = Math.Min(numbers.Count - 1, i + bomb[1]);
                    for(int j=start; j<=end; j++)
                    {
                        numbers[j] = 0;
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}

