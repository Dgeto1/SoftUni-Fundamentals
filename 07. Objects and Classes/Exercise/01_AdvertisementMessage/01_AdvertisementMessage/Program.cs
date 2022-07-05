using System;

namespace _01_AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int count = int.Parse(Console.ReadLine());
            Random r = new Random();
            for(int i=1; i<=count; i++)
            {
                int indexPhrase = r.Next(0, phrases.Length);
                string phrase = phrases[indexPhrase];
                int indexEvents = r.Next(0, events.Length);
                string even = events[indexEvents];
                int indexAuthor = r.Next(0, authors.Length);
                string author = authors[indexAuthor];
                int indexCity = r.Next(0, cities.Length);
                string city = cities[indexCity];
                Console.WriteLine($"{phrase} {even} {author} - {city}.");

            }
        }
    }
}

