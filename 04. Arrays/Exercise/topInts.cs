using System;
using System.Linq;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i=0; i<arr.Length;i++)
            {
                bool isTrue = true;
                for (int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]<=arr[j])
                    {
                        isTrue = false;
                        break;
                    }
                }
                if(isTrue)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
    }
}

