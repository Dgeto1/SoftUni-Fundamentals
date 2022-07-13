using System;

namespace _02_RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string output = string.Empty;
            for(int i=0; i<words.Length;i++)
            {
                int count = words[i].Length;
                for(int j=1; j<=count;j++)
                {
                    output += words[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}

