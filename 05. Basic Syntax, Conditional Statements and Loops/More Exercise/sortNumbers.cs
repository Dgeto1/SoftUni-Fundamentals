using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for(int i=0; i<3;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach(int x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
}

