using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class TestLINQ : System.Web.UI.Page
    {
        companyEntities db=new companyEntities();
      

        protected void Page_Load(object sender, EventArgs e)
        {
            var MyList = from c in db.employees
                         select c;
            GridView2.DataSource = MyList.ToList();
            GridView2.DataBind();


        }



        protected void GridView2_SelectedIndexChanged1(object sender, EventArgs e)
        {
           

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            var MyList = from c in db.employees
                         where c.firest_name ==TextBox1.Text
                         select c; 
            GridView2.DataSource = MyList.ToList(); 
            GridView2.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var MyList = from c in db.employees
                         where c.last_name == TextBox1.Text
                         select new {c.firest_name};
            GridView2.DataSource = MyList.ToList();
            GridView2.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var MyList = from c in db.employees
                         where c.firest_name.ToLower().Contains(TextBox1.Text.ToLower())
                         select c;
            GridView2.DataSource = MyList.ToList();
            GridView2.DataBind();

        }
    }
}