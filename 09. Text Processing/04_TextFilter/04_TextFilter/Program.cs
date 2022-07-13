using System;

namespace _04_TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach(var bannedWord in banList)
            {
                string replacemnet = new string('*', bannedWord.Length);
                text = text.Replace(bannedWord, replacemnet);
            }
            Console.WriteLine(text);
        }
    }
}

