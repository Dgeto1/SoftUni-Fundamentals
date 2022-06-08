using System;

namespace mathOperations
{
    class Program
    {
        static double Calculate(int number1, string @operator, int number2)
        {
            double result = 0;
            switch (@operator)
            {
                case "+":
                    result =  number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(number1,@operator,number2));
        }
    }
}

