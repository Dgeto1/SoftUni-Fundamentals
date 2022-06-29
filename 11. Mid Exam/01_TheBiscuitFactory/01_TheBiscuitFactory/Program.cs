using System;

namespace _01_TheBiscuitFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberBiscuits = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int numberBiscuitsSecondFactory = int.Parse(Console.ReadLine());
            double producedBiscuits = 0;
            for(int i=1; i<=30;i++)
            {
                if(i%3==0)
                {
                    double prodBisc = numberBiscuits * workers;
                    prodBisc *= 0.75;
                    producedBiscuits += Math.Floor(prodBisc); 
                }
                else
                {
                    producedBiscuits += numberBiscuits * workers;
                }
            }
            Console.WriteLine($"You have produced {producedBiscuits} biscuits for the past month.");
            if(producedBiscuits>numberBiscuitsSecondFactory)
            {
                double more = producedBiscuits - numberBiscuitsSecondFactory;
                Console.WriteLine($"You produce {more/numberBiscuitsSecondFactory*100:f2} percent more biscuits.");
            }
            else
            {
                double less = numberBiscuitsSecondFactory-producedBiscuits;
                Console.WriteLine($"You produce {less /numberBiscuitsSecondFactory * 100:f2} percent less biscuits.");
            }
        }
    }
}

