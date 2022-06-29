using System;
using System.Linq;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] first = new string[n];
            string[] second = new string[n];
            string[] pom1 = new string[n];
            string[] pom2 = new string[n];
            for(int i=0; i<n;i++)
            {
                string[] segments = Console.ReadLine().Split();
                first[i] = segments[0];
                second[i] = segments[1];
            }
            for(int i=0; i<n;i++)
            {
                if(i%2==0)
                {
                    pom1[i] = first[i];
                    pom2[i] = second[i];
                }
                else
                {
                    pom1[i] = second[i];
                    pom2[i] = first[i];
                }
            }
            foreach(string x in pom1)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            foreach(string x in pom2)
            {
                Console.Write(x + " ");
            }
        }
    }
}

