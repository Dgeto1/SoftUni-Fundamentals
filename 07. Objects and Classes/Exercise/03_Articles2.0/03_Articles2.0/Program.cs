using System;
using System.Collections.Generic;

namespace _02_Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                string[] segments = Console.ReadLine().Split(", ");
                Article article = new Article(segments[0], segments[1], segments[2]);
                articles.Add(article);

            }
            foreach (Article x in articles)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}

