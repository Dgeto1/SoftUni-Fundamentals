using System;
using System.Linq;
using System.Collections.Generic;

namespace changeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            while((command=Console.ReadLine())!="end")
            {
                string[] segments = command.Split();
                if (segments[0]=="Delete")
                {
                    int element = int.Parse(segments[1]);
                    for(int i=0; i<numbers.Count;i++)
                    {
                        if (numbers[i]==element)
                        {
                            numbers.Remove(numbers[i]);
                        }
                    }
                }
                else
                {
                    int element = int.Parse(segments[1]);
                    int index = int.Parse(segments[2]);
                    numbers.Insert(index, element);
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}

