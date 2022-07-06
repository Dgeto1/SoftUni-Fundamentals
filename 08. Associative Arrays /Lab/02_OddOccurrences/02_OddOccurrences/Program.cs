using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> oddWords = new Dictionary<string, int>();
            for(int i=0; i<words.Length;i++)
            {
                words[i].ToLower();
            }
            foreach(var x in words)
            {
                if(oddWords.ContainsKey(x))
                {
                    oddWords[x]++;
                }
                else
                {
                    oddWords[x] = 1;
                }
            }
            foreach(var x in oddWords)
            {
                if(x.Value%2!=0)
                {
                    Console.Write(x.Key + " ");
                }
            }
        }
    }
}

