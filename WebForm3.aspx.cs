using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack )
            {

                DropDownList1.Items.Add("Item 1");
                DropDownList1.Items.Add("Item 2");
                DropDownList1.Items.Add("Item 3");
                DropDownList1.Items.Add("Item 4");
            }



        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}