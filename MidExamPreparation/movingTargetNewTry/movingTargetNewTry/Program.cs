using System;
using System.Linq;
using System.Collections.Generic;

namespace movingTargetNewTry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            while((command=Console.ReadLine())!="End")
            {
                string[] segments = command.Split();
                if (segments[0]=="Shoot")
                {
                    int index = int.Parse(segments[1]);
                    int power = int.Parse(segments[2]);
                    for(int i=0; i<numbers.Count;i++)
                    {
                        if(index==i)
                        {
                            numbers[i] -= power;
                            if (numbers[i]<=0)
                            {
                                numbers.Remove(numbers[i]);
                            }
                        }
                    }
                }
                else if (segments[0]=="Add")
                {
                    int index = int.Parse(segments[1]);
                    int value = int.Parse(segments[2]);
                    bool isInvalid = false;
                    for(int i=0; i<numbers.Count;i++)
                    {
                        if(index==i)
                        {
                            numbers.Insert(i, value);
                        }
                        else
                        {
                            isInvalid = true;
                            
                        }
                    }
                    if(isInvalid)
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (segments[0]=="Strike")
                {
                    int index = int.Parse(segments[1]);
                    int radius = int.Parse(segments[2]);
                    int start = Math.Max(0, index - radius);
                    int end = Math.Min(numbers.Count-1, index + radius);
                    if(start > 0 && end<numbers.Count)
                    {
                        numbers.RemoveRange(start, end);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }
            Console.WriteLine(String.Join("|", numbers));
        }
    }
}

