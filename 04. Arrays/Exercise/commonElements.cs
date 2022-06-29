using System;
using System.Linq;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();
            string output = "";
            for(int i=0;i<first.Length;i++)
            {
                for(int j=0;  j<second.Length;j++)
                {
                    if(second[j]==first[i])
                    {
                        output += second[j] + " ";
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}

