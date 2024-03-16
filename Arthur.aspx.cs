using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Devoir_final_Arthur
{
    public partial class Arthur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (IsConnectedToInternet())
                {
                    Panel1.BackColor = Color.Green;
                }
                else
                {

                    Panel1.BackColor = Color.Red;
                }
            }

        }

        private static bool IsConnectedToInternet()
        {
            string host = "www.google.com";
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }


    }
    
}