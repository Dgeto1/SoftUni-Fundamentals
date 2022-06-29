using System;

namespace calculations
{
    class Program
    {
        static void Add(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum+secondNum);
        }
        static void Substract(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }
        static void Multiply(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }
        static void Divide(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            if(command=="add")
            {
                Add(firstNum, secondNum);
            }
            else if (command == "subtract")
            {
                Substract(firstNum, secondNum);
            }
            else if (command == "multiply")
            {
                Multiply(firstNum, secondNum);
            }
            else if (command == "divide")
            {
                Divide(firstNum, secondNum);
            }
        }
    }
}

