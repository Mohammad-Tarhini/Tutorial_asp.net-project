using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        companyEntities db=new companyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var Myemp = db.employees.Where(c => c.firest_name == TextBox1.Text && c.last_name == TextBox2.Text);
            if (Myemp.Count() > 0)
            {
                Label1.Text = "exist";
            }
            else 
            { Label1.Text = "not exist"; }
        }



    }
}