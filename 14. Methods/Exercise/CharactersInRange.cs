using System;

namespace charectersInRange
{
    class Program
    {
        static string CharactersInRange(char first, char second)
        {
            string output = string.Empty;
            int startChar = Math.Min(first, second);
            int endChar = Math.Max(first, second);
            for(int i=startChar+1; i<endChar; i++)
            {
                output += (char)i + " ";
            }
            return output;
        }
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            Console.WriteLine(CharactersInRange(a,b));
        }
    }
}

