using System;

namespace greaterOf2Values
{
    class Program
    {
        static int GetMax(int a,int b)
        {
            return Math.Max(a, b);
        }
        static string GetMax(string a, string b)
        {
            int result = a.CompareTo(b);
            if(result < 0)
            {
                return b;
            }
            else if(result > 0)
            {
                return a;
            }
            return "";
        }
        static char GetMax(char a, char b)
        {
            int result = a.CompareTo(b);
            if (result < 0)
            {
                return b;
            }
            else if (result > 0)
            {
                return a;
            }
            return ' ';
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type=="int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if(type=="string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMax(a, b));
            }
            else
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            
        }
    }
}

