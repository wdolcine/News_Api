using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Devoir_final_Arthur
{
    public class Mydatabase
    {
       static List<News> newsList = new List<News>();

        public static void Connect()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnexionDB"].ConnectionString;
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
            }

        }
        public static void CreateDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnexionDB"].ConnectionString;

            // Create the database
            string sqlCreate = @" CREATE TABLE TableofNews (id INT PRIMARY KEY IDENTITY(1,1), Name TEXT, Author TEXT, Title TEXT, Description TEXT, Url TEXT, UrlToImage VARCHAR(max), PublishedAt datetime, Content VARCHAR(max))";
            
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlCreate,conn);
                cmd.ExecuteNonQuery();
            }

        }
        public static void InsertIntoDatabase() 
        {
            List<News> list = InfoFromAPI.GetNews();
            string connectionString = ConfigurationManager.ConnectionStrings["ConnexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (News item in list)
                {
                    string sqlInsertQuery = "INSERT INTO TableofNews (Name, Author, Title, Description, Url, UrlToImage, PublishedAt, Content) VALUES (@Name, @Author, @Title, @Description, @Url, @UrlToImage, @PublishedAt, @Content)";
                    SqlCommand command = new SqlCommand(sqlInsertQuery, connection);

                    command.Parameters.AddWithValue("@Name", item.Name);
                    command.Parameters.AddWithValue("@Author", item.Author);
                    command.Parameters.AddWithValue("@Title", item.Title);
                    command.Parameters.AddWithValue("@Description", item.Description);
                    command.Parameters.AddWithValue("@Url", item.Url);
                    command.Parameters.AddWithValue("@UrlToImage", item.UrlToImage);
                    command.Parameters.AddWithValue("@PublishedAt", item.PublishedAt);
                    command.Parameters.AddWithValue("@Content", item.Content);

                    command.ExecuteNonQuery();
                }

            }
        }
        
        public static List<News> SelectFromDataBase()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["ConnexionDB"].ConnectionString;

            string sqlSelectQuery = "SELECT Name, Author, Title, Description, Url, UrlToImage, PublishedAt,Content FROM TableofNews";

            
            using(SqlConnection connection = new SqlConnection( connectionString))
            {
                connection.Open();

                using(SqlCommand command = new SqlCommand( sqlSelectQuery, connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string Name = reader.GetString(0);
                            string Author = reader.GetString(1);
                            string Title = reader.GetString(2);
                            string Description = reader.GetString(3);
                            string Url = reader.GetString(4);
                            string UrlToImage = reader.GetString(5);
                            DateTime PublishedAt = reader.GetDateTime(6);
                            string Content = reader.GetString(7);

                            newsList.Add(new News(Name,Author,Title,Description,Url, UrlToImage, PublishedAt,Content));
                        }
                    }
                }
            }
            return newsList;

        }
        

    }
}