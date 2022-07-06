using System;
using System.Collections.Generic;

namespace _03_WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();
            for(int i=1; i<=number;i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }
                synonyms[word].Add(synonym);
            }
            foreach(var x in synonyms)
            {
                Console.WriteLine($"{x.Key} -> {string.Join(", ", x.Value)}");
            }
        }
    }
}

