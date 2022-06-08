using System;

namespace multiplyEvenOdds
{
    class Program
    {
        static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            while(num>0)
            {
                int lastDigit = num % 10;
                if(lastDigit%2==0)
                {
                    sum += lastDigit;
                }
                num = num / 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                num = num / 10;
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int num)
        {
            return GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if(number<0)
            {
                Console.WriteLine(GetMultipleOfEvenAndOdds(Math.Abs(number)));
            }
            else
            {
                Console.WriteLine(GetMultipleOfEvenAndOdds(number));
            }
        }
    }
}

