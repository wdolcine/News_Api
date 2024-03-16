using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Devoir_final_Arthur
{
    public partial class All_News : System.Web.UI.Page
    {
        public static int indice = 0;

        public static List<News> list ;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Fill the cards with the data selected from the database (List)

                DataLoad();
            }
            // First : Connect to my database
            //Mydatabase.Connect();

            // Second : Create the database with the tables
           //Mydatabase.CreateDatabase();

           // Third : Insert data into the database from the Api
           //Mydatabase.InsertIntoDatabase();

           // Fourth : Select the data from the database and add it to a List
           //Mydatabase.SelectFromDataBase();
           
        }
        
        protected void DataLoad()
        {
            Thread.Sleep(3000);

            list = Mydatabase.SelectFromDataBase();

            if (indice == 0)
            {
                BtnPrev.Enabled = false;
                BtnNext.Enabled = false;
            }
            else
            {
                BtnNext.Enabled = true;
                BtnPrev.Enabled = true;
            }

            if (indice == list.Count - 3)
            {
                btnfirst.Enabled = false;
                btnlast.Enabled = false;
            }
            else
            {
                btnlast.Enabled = true;
                btnfirst.Enabled = true;    
            }

            List<News> list_2 = new List<News>() 
            {
                list[indice],
                list[indice + 1],
                list[indice + 2],
            
            };

             News news0 = list_2.ElementAt(0);
             
             lbltitle0.Text = news0.Title;
             lblAuthor0.Text = news0.Author;
             lblDate0.Text = news0.PublishedAt.ToString();
             image0.ImageUrl = new Uri(news0.UrlToImage).AbsoluteUri;
             image0.Visible = true;
              
           


            News news1 = list_2.ElementAt(1);
            lbltitle1.Text = news1.Title;
            lblAuthor1.Text = news1.Author;
            lblDate1.Text = news1.PublishedAt.ToString();
            image1.ImageUrl = new Uri(news1.UrlToImage).AbsoluteUri;
            image1.Visible = true;


            News news2 = list_2.ElementAt(2);
            lbltitle2.Text = news2.Title;
            lblAuthor2.Text = news2.Author;
            lblDate2.Text = news2.PublishedAt.ToString();
            image2.ImageUrl = new Uri(news2.UrlToImage).AbsoluteUri;
            image2.Visible = true;
        }


        protected void image0_Click(object sender, ImageClickEventArgs e)
        {
            New_Clicked.listNews.Clear();
            News newsinfo = new News();
            ImageButton btnNew = (ImageButton) sender;

            int indexElement = list.FindIndex(news => news.UrlToImage.Contains(btnNew.ImageUrl));

            if (indexElement != -1)
            {
                newsinfo.UrlToImage = list[indexElement].UrlToImage;
                newsinfo.Title = list[indexElement].Title;
                newsinfo.Author = list[indexElement].Author;
                newsinfo.PublishedAt = list[indexElement].PublishedAt;
                newsinfo.Content = list[indexElement].Content;

            }
            New_Clicked.listNews.Add(newsinfo);
           Response.Redirect("New_Clicked.aspx");

        }

        protected void image1_Click(object sender, ImageClickEventArgs e)
        {
            New_Clicked.listNews.Clear();
            News newsinfo = new News();
            //ImageButton btnNew1 = (ImageButton)sender;


            int indexElement = list.FindIndex(news => news.Title.Contains(lbltitle1.Text));

            if (indexElement != -1)
            {
                newsinfo.UrlToImage = list[indexElement].UrlToImage;
                newsinfo.Title = list[indexElement].Title;
                newsinfo.Author = list[indexElement].Author;
                newsinfo.PublishedAt = list[indexElement].PublishedAt;
                newsinfo.Content = list[indexElement].Content;
                //newsinfo.Content = list[indexElement].Content;

            }
            New_Clicked.listNews.Add(newsinfo);
            Response.Redirect("New_Clicked.aspx");

        }

        protected void image2_Click(object sender, ImageClickEventArgs e)
        {
            New_Clicked.listNews.Clear();
            News newsinfo = new News();

            int indexElement = list.FindIndex(news => news.Title.Contains(lbltitle2.Text));

            if (indexElement != -1)
            {
                newsinfo.UrlToImage = list[indexElement].UrlToImage;
                newsinfo.Title = list[indexElement].Title;
                newsinfo.Author = list[indexElement].Author;
                newsinfo.PublishedAt = list[indexElement].PublishedAt;
                newsinfo.Content = list[indexElement].Content;
                //newsinfo.Content = list[indexElement].Content;

            }
            New_Clicked.listNews.Add(newsinfo);
            Response.Redirect("New_Clicked.aspx");

        }


        protected void BtnPrev_Click1(object sender, EventArgs e)
        {
            indice -= 3;
            DataLoad();
        }

        protected void BtnNext_Click1(object sender, EventArgs e)
        {
            indice += 3;
            DataLoad();
        }

        protected void btnfirst_Click(object sender, EventArgs e)
        {
            indice = 0;
            DataLoad();
        }

        protected void btnlast_Click(object sender, EventArgs e)
        {
            indice = list.Count - 3;
            DataLoad();
        }
    }

    
}