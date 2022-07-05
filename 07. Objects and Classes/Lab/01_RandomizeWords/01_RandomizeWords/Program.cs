using System;

namespace _01_RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random r = new Random();
            for(int i=0; i<words.Length-1;i++)
            {
                words[i] = words[r.Next(words.Length - 1)];
            }
            foreach(string x in words)
            {
                Console.WriteLine(x);
            }
        }
    }
}

