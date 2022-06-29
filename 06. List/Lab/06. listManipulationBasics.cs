using System;
using System.Linq;
using System.Collections.Generic;

namespace listManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            while((command= Console.ReadLine()) != "end")
            {
                string[] segments = command.Split().ToArray();
                int number = int.Parse(segments[1]);
                if (segments[0]=="Add")
                {
                    numbers.Add(number);
                }
                else if (segments[0]=="Remove")
                {
                    numbers.Remove(number);
                }
                else if (segments[0]=="RemoveAt")
                {
                    numbers.RemoveAt(number);
                }
                else
                {
                    int index = int.Parse(segments[2]);
                    numbers.Insert(index, number);
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}

