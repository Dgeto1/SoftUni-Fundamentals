using System;
using System.Linq;
using System.Collections.Generic;

namespace houseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            int numberCommands = int.Parse(Console.ReadLine());
            for(int i=1; i<=numberCommands;i++)
            {
                string command = Console.ReadLine();
                string[] segments = command.Split();
                if(segments.Length==3)
                {
                    string name = segments[0];
                    if(!names.Contains(name))
                    {
                        names.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else
                {
                    string name = segments[0];
                    if(names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{segments[0]} is not in the list!");
                    }
                }
            }
            foreach(string x in names)
            {
                Console.WriteLine(x);
            }
        }
    }
}

