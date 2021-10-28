using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split( ',');
            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split( ':');
                string commandAction = command[0];
                string commandValue = command[1];

                if (commandAction=="Edit")
                {
                    article.Edit(commandValue);
                }
                if (commandAction == "ChangeAuthor")
                {
                    article.ChangeAuthor(commandValue);
                }
                if (commandAction == "Rename")
                {
                    article.Rename(commandValue);
                }
            }

            Console.WriteLine(article);

        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} -{Content}:{Author}";
        }
    }
}
//2.Articles
//Create a class Article with the following properties:
//•	Title – a string
//•	Content – a string
//•	Author – a string
//The class should have a constructor and the following methods:
//•	Edit(new content) – change the old content with the new one
//•	ChangeAuthor(new author) – change the author
//•	Rename (new title) – change the title of the article
//•	Override the ToString method – print the article in the following format: 
//"{title} - {content}: {author}"
//Create a program that reads an article in the following format "{title}, {content}, {author}". On the next line, you will receive a number n, representing the number of commands, which will follow after it. On the next n lines, you will be receiving the following commands: "Edit: {new content}"; "ChangeAuthor: {new author}"; "Rename: {new title}".In the end, print the final state of the article.
//Example

//Input	Output
//some title, some content, some author
//3
//Edit: better content
//ChangeAuthor:  better author
//Rename: better title	better title - better content: better author
