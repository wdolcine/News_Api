using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Devoir_final_Arthur
{
    public class News
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }

        public News() { }
        public News(string name, string author, string title, string description, string url, string urlToImage, DateTime publishedAt, string content)
        {
            Name = name;
            Author = author;
            Title = title;
            Description = description;
            Url = url;
            UrlToImage = urlToImage;
            PublishedAt = publishedAt;
            Content = content;
        }
    }
  
}