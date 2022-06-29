using System;

namespace ArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstArr = Console.ReadLine();
            string secondArr = Console.ReadLine();
            string[] first = firstArr.Split(" ");
            string[] second = secondArr.Split(" ");
            int sum=0;
            bool isSame = true;
            for(int i=0; i<first.Length;i++)
            {
                if(first[i]!=second[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isSame = false;
                    break;
                }
                sum += int.Parse(first[i]);
            }
            if(isSame)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
