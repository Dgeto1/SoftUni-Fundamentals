using System;

namespace Orders
{
    class Program
    {
        static void PriceOrder(string product, double quantity)
        {
            switch(product)
            {
                case "coffee":
                    Console.WriteLine($"{quantity*1.5:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{quantity * 1:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{quantity * 1.4:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{quantity * 2:f2}");
                    break;
            }
        }
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            PriceOrder(product, quantity);
        }
    }
}

