using System;

namespace repeatString
{
    class Program
    {
        static string Repeat(string st, int n)
        {
            string output = string.Empty;
            for(int i=1; i<=n;i++)
            {
               output += st;
            }
            return output;
        }
        static void Main(string[] args)
        {
            string st = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Repeat(st,n));
        }
    }
}

