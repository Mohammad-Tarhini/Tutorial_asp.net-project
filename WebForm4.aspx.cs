using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        companyEntities db = new companyEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            employee p = new employee()
            {
              
             
                firest_name = TextBox1.Text,
                last_name= TextBox2.Text,   

            };

            db.employees.Add(p);
            db.SaveChanges();





        }

         
        
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox0_TextChanged(object sender, EventArgs e)
        {

        }
    }
}