using System;

namespace _01_guineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityOfFood = double.Parse(Console.ReadLine());
            double quantityHay = double.Parse(Console.ReadLine());
            double quantityCover = double.Parse(Console.ReadLine());
            double guineaWeight = double.Parse(Console.ReadLine());
            quantityOfFood *= 1000;
            quantityHay *= 1000;
            quantityCover *= 1000;
            guineaWeight *= 1000;
            double halfFood = quantityOfFood / 2;
            double hayAte = 0;
            bool isEnough = true;
            for (int i=1;i<=30; i++)
            {
                quantityOfFood -= 300;
                if(quantityOfFood<=0)
                {
                    isEnough = false;
                    break;
                }
                if(i%2==0)
                {
                    hayAte = 0.05 * quantityOfFood;
                    quantityHay -= hayAte;
                }
                if(quantityHay<=0)
                {
                    isEnough = false;
                    break;
                }
                if(i%3==0)
                {
                    double cover = guineaWeight / 3;
                    quantityCover -= cover;
                }
                if(quantityCover<=0)
                {
                    isEnough = false;
                    break;
                }
                
            }
            
            if(!isEnough)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityOfFood/1000:f2}, Hay: {quantityHay/1000:f2}, Cover: {quantityCover/1000:f2}.");
            }
        }
    }
}

