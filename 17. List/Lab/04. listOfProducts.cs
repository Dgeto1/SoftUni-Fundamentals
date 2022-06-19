using System;
using System.Linq;
using System.Collections.Generic;

namespace listOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> products = new();
            for(int i=0; i<count;i++)
            {
                products.Add(Console.ReadLine());
            }
            var sortedProducts = products.OrderBy(x => x).ToList();
            for(int i=0; i<sortedProducts.Count;i++)
            {
                Console.WriteLine($"{i + 1}.{sortedProducts[i]}");
            }
        }
    }
}

