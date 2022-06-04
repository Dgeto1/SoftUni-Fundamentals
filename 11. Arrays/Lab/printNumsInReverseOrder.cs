using System;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                arr[i] = nums;
            }
            Array.Reverse(arr);
            foreach(int x in arr)
            {
                Console.Write(x + " ");
            }
        }
    }
}

