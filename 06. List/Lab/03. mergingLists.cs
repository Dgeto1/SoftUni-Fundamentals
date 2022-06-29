using System;
using System.Collections.Generic;
using System.Linq;

namespace mergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int biggestCount = Math.Max(firstNumbers.Count, secondNumbers.Count);
            for(int i=0; i<biggestCount;i++)
            {
                if(firstNumbers.Count>i)
                {
                    result.Add(firstNumbers[i]);
                }
                if (secondNumbers.Count > i)
                {
                    result.Add(secondNumbers[i]);
                }

            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}

