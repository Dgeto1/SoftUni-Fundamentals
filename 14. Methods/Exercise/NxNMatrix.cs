using System;

namespace NxNMatrix
{
    class Program
    {
        static void Matrix(int num)
        {
            int n = num;
            while (num>0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(n+" ");
                }
                Console.WriteLine();
                num--;
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Matrix(num);
        }
    }
}

