using System;

namespace palindromeIntegers
{
    class Program
    {
        static void PalindromeIntegers(int num)
        {
            string numOpposite = string.Empty;
            int newNum = num;
            while(num>0)
            {
                numOpposite += num % 10;
                num = num / 10;
            }
            if(newNum == int.Parse(numOpposite))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                int num = int.Parse(input);
                PalindromeIntegers(num);  
            }

        }
    }
}

