using System;

namespace orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOrders = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for(int i=0; i<numberOrders;i++)
            {
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countCapsules = int.Parse(Console.ReadLine());
                double currentSum = (days * countCapsules) * priceCapsule;
                totalPrice += (days * countCapsules) * priceCapsule;
                Console.WriteLine($"The price for the coffee is: ${currentSum:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}

