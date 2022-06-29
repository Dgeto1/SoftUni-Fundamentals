using System;

namespace vowelsCount
{
    class Program
    {
        static int CountVowels(string word)
        {
            int count = 0;
            word = word.ToLower();
            for(int i=0; i<word.Length;i++)
            {
                if(word[i]=='a' || word[i] == 'e' || word[i] == 'i' || word[i] =='o' || word[i] == 'u' || word[i] == 'y')
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(CountVowels(word));
        }
    }
}

