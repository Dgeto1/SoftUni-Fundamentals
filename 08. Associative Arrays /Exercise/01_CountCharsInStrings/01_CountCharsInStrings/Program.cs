using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountCharsInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> letters = Console.ReadLine().ToList();
            for(int i=0; i<letters.Count;i++)
            {
                if (letters[i]==' ')
                {
                    letters.Remove(letters[i]);
                }
            }
            
            Dictionary<char, int> countLetters = new Dictionary<char, int>();
            foreach(var x in letters)
            {
                if(countLetters.ContainsKey(x))
                {
                    countLetters[x]++;
                }
                else
                {
                    countLetters[x] = 1;
                }
            }
            foreach(var x in countLetters)
            {
                Console.WriteLine($"{x.Key} -> {x.Value}");
            }
        }
    }
}

