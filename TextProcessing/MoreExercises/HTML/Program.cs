using System;
using System.Linq;
using System.Collections.Generic;

namespace HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titleInput = Console.ReadLine();
            string articleInput = Console.ReadLine();
            List<string> comments = new List<string>();

            string comment = Console.ReadLine();

            while(comment!="end of comments")
            {
                comments.Add(comment);

                comment = Console.ReadLine();
            }

            Console.Write($"<h1>\n  {titleInput}\n</h1>\n");
            Console.Write($"<article>\n {articleInput}\n</article>\n");
            foreach(string item in comments)
            {
                Console.Write($"<div>\n {item}\n</div>\n");
            }
        }
    }
}
