using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<double, int> sortedNumbersWithCount = new SortedDictionary<double, int>();
            foreach(var number in numbers)
            {
                if(sortedNumbersWithCount.ContainsKey(number))
                {
                    sortedNumbersWithCount[number]++;
                }
                else
                {
                    sortedNumbersWithCount.Add(number, 1);
                }
            }
            foreach(var nums in sortedNumbersWithCount)
            {
                Console.WriteLine($"{nums.Key} -> {nums.Value}");
            }
        }
    }
}

