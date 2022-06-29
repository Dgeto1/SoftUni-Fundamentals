using System;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            Array.Reverse(arr);
            foreach(string x in arr)
            {
                Console.Write(x + " ");
            }
        }
    }
}

