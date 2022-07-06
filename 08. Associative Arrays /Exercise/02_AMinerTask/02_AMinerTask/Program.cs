using System;
using System.Collections.Generic;

namespace _02_AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string command;
            while((command=Console.ReadLine())!="stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if(resources.ContainsKey(command))
                {
                    resources[command] += quantity; 
                }
                else
                {
                    resources.Add(command, quantity);
                }
            }
            foreach(var x in resources)
            {
                Console.WriteLine($"{x.Key} -> {x.Value}");
            }
        }
    }
}

