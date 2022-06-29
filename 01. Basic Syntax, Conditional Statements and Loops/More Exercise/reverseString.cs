using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = Console.ReadLine();
            char[] segments = new char[st.Length];
            for(int i=0; i<segments.Length;i++)
            {
                segments[i] = st[i];
            }
            Array.Reverse(segments);
            Console.Write(String.Join("",segments));
        }
    }
}

