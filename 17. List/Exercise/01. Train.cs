using System;
using System.Collections.Generic;
using System.Linq;

namespace train
{
    class Program
    {
        static void FindWagon(List<int> wagons, int maxCapacity, int countPeople)
        {
            for(int i=0; i<wagons.Count;i++)
            {
                if (wagons[i] + countPeople <= maxCapacity)
                {
                    wagons[i] += countPeople;
                    break;
                }
                
            }
        }
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command;
            while((command = Console.ReadLine()) != "end")
            {
                string[] segments = command.Split();
                if (segments[0]=="Add")
                {
                    wagons.Add(int.Parse(segments[1]));
                }
                else
                {
                    int countPeople = int.Parse(segments[0]);
                    FindWagon(wagons, maxCapacity, countPeople);
                }
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}

