using System;

namespace MetersToKms
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int i=1; i<=number;i++)
            {
                int sum = 0;
                int n = i;
                while (n>0)
                {
                    sum += n % 10;
                    n = n / 10;
                }
                if(sum != 7 && sum != 5 && sum != 11)
                {
                    Console.WriteLine($"{i} -> False");
                }
                else if(sum == 7 || sum == 5 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
            }
        }
    }
}

