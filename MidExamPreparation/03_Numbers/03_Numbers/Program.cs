using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int average = 0;
            List<int> greaterNumbers = new List<int>();
            for(int i=0; i<numbers.Count;i++)
            {
                average += numbers[i];
            }
            average /= numbers.Count;
            int counter = 0;
            numbers.Sort();
            numbers.Reverse();
            for(int i=0; i<numbers.Count;i++)
            {
                if (numbers[i]>average)
                {
                    counter++;
                    greaterNumbers.Add(numbers[i]);
                }
                if(counter==5)
                {
                    break;
                }
            }
            if(greaterNumbers.Count==0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(String.Join(" ", greaterNumbers));
            }
        }
    }
}

