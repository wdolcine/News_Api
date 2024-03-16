using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Devoir_final_Arthur
{
    public partial class New_Clicked : System.Web.UI.Page
    {
        public static List<News> listNews = new List<News>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (listNews.Count >= 1)
            {
                image1.ImageUrl = listNews[0].UrlToImage;
                Label7.Text = listNews[0].PublishedAt.ToString();
                Label6.Text = listNews[0].Author.ToString();
                Label5.Text = listNews[0].Title.ToString();
                Label8.Text = listNews[0].Content.ToString();

            }
            else
            {
                return;
            }

        }

        protected void btnAllNews_Click(object sender, EventArgs e)
        {
            Response.Redirect("All_News.aspx");
        }
    }
}