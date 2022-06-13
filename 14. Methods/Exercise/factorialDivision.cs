using System;

namespace factorialDivision
{
    class Program
    {
        static decimal FactorialFirstNum(decimal num1)
        {
            if(num1==1)
            {
                return 1;
            }
            return num1* FactorialFirstNum(num1-1);
        }
        static decimal FactorialSecondNum(decimal num2)
        {
            if (num2 == 1)
            {
                return 1;
            }
            return num2 * FactorialSecondNum(num2 - 1);
        }
        static string Division(decimal num1,decimal num2)
        {
            return (FactorialFirstNum(num1) / FactorialSecondNum(num2)).ToString("f2");
        }
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine(Division(num1,num2));
        }
    }
}


