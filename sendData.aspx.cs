using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class sendData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // Session["Name"] = TextBox1.Text;
            //Response.Redirect("getData.aspx");

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Response.Redirect("getData.aspx?name=" + TextBox1.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie Mycookie = new HttpCookie("username");
           Mycookie.Values.Add("name", TextBox1.Text);
            Response.Cookies.Add(Mycookie);
            Response.Redirect("getData.aspx");

                
        }
    }
}