using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_movingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            while((command=Console.ReadLine())!="End")
            {
                string[] segments = Console.ReadLine().Split();
                string order = segments[0];
                int index = int.Parse(segments[1]);
                int value = int.Parse(segments[2]);
                for(int i=0; i<targets.Count;i++)
                {
                    if (order == "Shoot")
                    {
                        if (index==i)
                        {
                            targets[i] -= value;
                            if (targets[i]<=0)
                            {
                                targets.Remove(targets[i]);
                            }
                        }
                    }
                    if(order=="Add")
                    {
                        if(index==i)
                        {
                            targets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                    }
                    if(order=="Strike")
                    {
                        if(index==i)
                        {
                            int start = Math.Max(0, i - value);
                            int end = Math.Min(targets.Count - 1, i + value);
                            for(int j=start;j<=end;j++)
                            {
                                targets[j] = 0;
                            }
                            for(int j=0; j<targets.Count;j++)
                            {
                                if (targets[j]==0)
                                {
                                    targets.Remove(targets[i]);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(String.Join("|", targets));
        }
    }
}

