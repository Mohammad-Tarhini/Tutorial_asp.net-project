using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class getData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Label1.Text = Session["Name"].ToString();

            //abel2.Text = Request.QueryString["name"].ToString();
            HttpCookie Mycookie = Request.Cookies["username"];
            if (Mycookie == null)
            {
                Label3.Text = "no cookie sent";
            }
            else
            {
                Label3.Text = Mycookie["name"];
            }
        }
        

    }
}