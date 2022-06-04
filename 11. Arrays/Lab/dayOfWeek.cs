using System;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int n = int.Parse(Console.ReadLine());
            if(n>7 || n<=0)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(arr[n-1]);
            }
        }
    }
}

