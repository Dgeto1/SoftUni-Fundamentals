using System;
using System.Collections.Generic;

namespace _02_Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            string[] segments = Console.ReadLine().Split(", ");
            Article article = new Article(segments[0], segments[1], segments[2]);
            articles.Add(article);
            int count = int.Parse(Console.ReadLine());
            for(int i=1; i<=count;i++)
            {
                string command = Console.ReadLine();
                string[] parts = command.Split(": ");
                switch (parts[0])
                {
                    case "Edit":
                        articles[0].Edit(parts[1]);
                        break;
                    case "ChangeAuthor":
                        articles[0].ChangeAuthor(parts[1]);
                        break;
                    case "Rename":
                        articles[0].Rename(parts[1]);
                        break;
                }
               
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
        public string Edit(string newContent)
        {
            this.Content = newContent;
            return this.Content;
        }
        public string ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
            return this.Author;
        }
        public string Rename(string newTitle)
        {
            this.Title = newTitle;
            return this.Title;

        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}

