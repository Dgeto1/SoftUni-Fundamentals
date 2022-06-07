using System;
using System.Linq;

namespace maxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0, maxCounter = 0, index = 0;
            string number = string.Empty;

            for(int i=0; i<arr.Length-1;i++)
            {
                if(arr[i]==arr[i+1])
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }
                if (counter > maxCounter)
                {
                    number = arr[i].ToString();
                    maxCounter = counter;
                }
            }
            for(int i=0;i<=maxCounter;i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}

