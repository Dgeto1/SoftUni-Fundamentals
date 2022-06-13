using System;

namespace factorialDivision
{
    class Program
    {
        static int FactorialFirstNum(int num1)
        {
            if(num1==1)
            {
                return 1;
            }
            return num1* FactorialFirstNum(num1-1);
        }
        static int FactorialSecondNum(int num2)
        {
            if (num2 == 1)
            {
                return 1;
            }
            return num2 * FactorialSecondNum(num2 - 1);
        }
        static string Division(int num1,int num2)
        {
            return $"{FactorialFirstNum(num1) / FactorialSecondNum(num2):f2}";
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Division(num1,num2));
        }
    }
}

