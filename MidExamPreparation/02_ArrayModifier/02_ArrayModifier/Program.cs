using System;
using System.Linq;

namespace _02_ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command;
            while((command=Console.ReadLine())!="end")
            {
                string[] segmnets = command.Split();
                if (segmnets[0]=="swap")
                {
                    int index1 = int.Parse(segmnets[1]);
                    int index2 = int.Parse(segmnets[2]);
                    int a = numbers[index1];
                    numbers[index1] = numbers[index2];
                    numbers[index2] = a;
                }
                else if (segmnets[0]=="multiply")
                {
                    int index1 = int.Parse(segmnets[1]);
                    int index2 = int.Parse(segmnets[2]);
                    numbers[index1] *= numbers[index2];
                }
                else if (segmnets[0]=="decrease")
                {
                    for(int i=0;i<numbers.Length;i++)
                    {
                        numbers[i]--;
                    }
                }
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}

