using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03.Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Articles> articles = new List<Articles>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split( ',');
                string title = input[0];
                string content = input[1];
                string author = input[2];

                articles.Add(new Articles(title, content, author));
            }

            

            string sortCriteria = Console.ReadLine();

            if (sortCriteria=="title")
            {
                articles = articles.OrderBy(a => a.Title).ToList();
            }

            if (sortCriteria == "content")
            {
                articles = articles.OrderBy(a => a.Content).ToList();
            }
            if (sortCriteria == "author")
            {
                articles = articles.OrderBy(a => a.Author).ToList();
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
        class Articles
        {
            public Articles(string title, string content, string author)
            {
                Title = title;
                Author = author;
                Content = content;
            }
            public string Title { get; set; }

            public string Author { get; set; }

            public string Content { get; set; }

            public override string ToString()
            {
                {
                    return $"{Title} -{Content}:{Author}";
                }
            }
        }
    }
}
//3.Articles 2.0
//Change the program in such a way, that you will be able to store a list of articles. You will not need to use the previous methods anymore (except the ToString method). On the first line, you will receive the number of articles. On the next lines, you will receive the articles in the same format as in the previous problem: "{title}, {content}, {author}".Finally, you will receive a string: "title", "content" or an "author". You need to order the articles alphabetically, based on the given criteria. 
//Example
//Input	Output
//2
//Science, planets, Bill
//Article, content, Johnny
//title	Article - content: Johnny
//Science - planets: Bill
