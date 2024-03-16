using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Reflection.Emit;
using System.Web.Mvc.Html;
using System.Web.UI.WebControls;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using System.Security.Policy;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Net;
using System.Text.Json;

namespace Devoir_final_Arthur
{
    public class InfoFromAPI
    {

        public static List<News> GetNews()
        {

            List<News> listnews = new List<News>();

            using (WebClient client = new WebClient())
            {
                string jsonString = client.DownloadString("https://newsapi.org/v2/top-headlines?sources=techcrunch&apiKey=a48488323df048f0afe6279043eee27f");

                var jsonDocument = JsonDocument.Parse(jsonString);
                var root = jsonDocument.RootElement;

                if (root.TryGetProperty("articles", out JsonElement articlesElement) && articlesElement.ValueKind == JsonValueKind.Array)
                {
                    foreach (var article in articlesElement.EnumerateArray())
                    {
                        // Access properties of each article
                        string name = article.GetProperty("source").GetProperty("name").GetString();
                        string author = article.GetProperty("author").GetString();
                        string title = article.GetProperty("title").GetString();
                        string description = article.GetProperty("description").GetString();
                        string url = article.GetProperty("url").GetString();
                        string UrlToImage = article.GetProperty("urlToImage").GetString();
                        DateTime publishedAt = article.GetProperty("publishedAt").GetDateTime();
                        string content = article.GetProperty("content").GetString();

                        News news = new News(name, author, title, description, url, UrlToImage, publishedAt, content);

                        listnews.Add(news);
                       




                        }
                }
            }
            return listnews;
        }
      



    }
}