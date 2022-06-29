using System;
using System.Linq;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumLeft = 0, sumRight = 0;
            for(int i=0; i<arr.Length;i++)
            {
                if(arr.Length==1)
                {
                    Console.WriteLine(0);
                    return;
                }
                sumLeft = 0;
                for(int left=i; left>0; left--)
                {
                    int leftElement = left - 1;
                    if(left>0)
                    {
                        sumLeft += arr[leftElement];
                    }
                }
                sumRight = 0;
                for(int right = i; right<arr.Length; right++)
                {
                    int rightElement = right + 1;
                    if(right<arr.Length-1)
                    {
                        sumRight += arr[rightElement];
                    }
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
                Console.WriteLine("no");
        }
    }
}

