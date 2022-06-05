using System;

namespace ArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            string[] segments = nums.Split(" ");
            int[] numbers = new int[segments.Length];
            int sumEven = 0, sumOdds = 0;
            for(int i=0; i<numbers.Length;i++)
            {
                numbers[i] = int.Parse(segments[i]);
            }
            for(int i=0; i<numbers.Length;i++)
            {
                if(numbers[i]%2==0)
                {
                    sumEven += numbers[i];
                }
                else
                {
                    sumOdds += numbers[i];
                }
            }
            Console.WriteLine(sumEven-sumOdds);
        }
    }
}
