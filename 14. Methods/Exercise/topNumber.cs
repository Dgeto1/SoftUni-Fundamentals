using System;

namespace topNumber
{
    class Program
    {
        static void TopNumber(int num)
        {
            int num1 = num;
            int num2 = num;
            bool isDivisible = false, hasOddDigit = false;
            int sumNumber = 0;
            while(num1>0)
            {
                sumNumber += num1 % 10;
                num1 = num1 / 10;
            }
            if(sumNumber%8==0)
            {
                isDivisible = true;
            }
            
            while (num2 > 0)
            {
                int isOdd = num2 % 10;
                if(isOdd%2!=0)
                {
                    hasOddDigit = true;
                    
                }
                num2 = num2 / 10;
            }
            if(isDivisible && hasOddDigit)
            {
                Console.WriteLine(num);
            }
        }
        static void Main(string[] args)
        {
            int endInterval = int.Parse(Console.ReadLine());
            for(int i=17; i<=endInterval;i++)
            {
                TopNumber(i);
            }
        }
    }
}

