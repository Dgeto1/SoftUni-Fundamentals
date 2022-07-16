using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> companyIds = new Dictionary<string, string>();
            string command;
            while((command = Console.ReadLine())!="End")
            {
                string[] segments = Console.ReadLine().Split(" -> ");
                string companyName = segments[0];
                string id = segments[1];
                if(!companyIds.ContainsKey(id))
                {
                    companyIds[id] = companyName;
                }
            }
            foreach(var x in companyIds)
            {
                Console.WriteLine(x.Value);
                Console.WriteLine($"-- {x.Key}");
            }
        }
    }
}

