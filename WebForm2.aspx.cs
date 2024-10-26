using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        companyEntities db=new companyEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                GridView1.DataSource = db.branches.ToList();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                // Log the exception details or display an error message
                // ex.Message will give you more information about the error
                // You can also check ex.InnerException for more details
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                // Close any resources if needed
                db.Dispose();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var Myemployee= db.employees.Where(c => c.firest_name == TextBox1.Text).ToList();
            GridView1.DataSource = Myemployee;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

                var myemployee = new employee() { emp_id=0 ,firest_name = TextBox1.Text, last_name = "tar" };
                db.employees.Add(myemployee);
                db.SaveChanges();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var myemployee = db.employees.Find(1);
          myemployee.firest_name= TextBox1.Text;
           
            db.SaveChanges();
        }

    }
}