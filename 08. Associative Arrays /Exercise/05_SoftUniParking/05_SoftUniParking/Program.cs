using System;
using System.Collections.Generic;

namespace _05_SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> clientsParkings = new Dictionary<string, string>();
            for(int i=1; i<=numberCommands;i++)
            {
                string[] segments = Console.ReadLine().Split();
                string command = segments[0];
                if(command=="register")
                {
                    string name = segments[1];
                    string license = segments[2];
                    if(clientsParkings.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }
                    else
                    {
                        clientsParkings[name] = license;
                        Console.WriteLine($"{name} registered {license} successfully");
                    }
                }
                else
                {
                    string name = segments[1];
                    if(!clientsParkings.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        clientsParkings.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }
            foreach(var x in clientsParkings)
            {
                Console.WriteLine($"{x.Key} => {x.Value}");
            }
        }
    }
}

