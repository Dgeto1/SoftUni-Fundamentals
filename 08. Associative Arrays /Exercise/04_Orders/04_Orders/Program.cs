using System;
using System.Collections.Generic;

namespace _04_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productsPrices = new Dictionary<string, double>();
            Dictionary<string, int> productsQuantity = new Dictionary<string, int>();
            Dictionary<string, double> productsFinalPrices = new Dictionary<string, double>();
            string command;
            while((command=Console.ReadLine())!="buy")
            {
                string[] segments = command.Split();
                string name = segments[0];
                double price = double.Parse(segments[1]);
                int quantity = int.Parse(segments[2]);
                if(!productsPrices.ContainsKey(name))
                {
                    productsPrices[name] = price;
                    productsQuantity[name] = quantity;
                    productsFinalPrices[name] = price * quantity;
                }
                else
                {
                    productsPrices[name] = price;
                    productsQuantity[name] += quantity;
                    productsFinalPrices[name] = productsPrices[name] * productsQuantity[name];
                    
                }
            }
            foreach(var x in productsFinalPrices)
            {
                Console.WriteLine($"{x.Key} -> {x.Value:f2}");
            }
        }
    }
}

