using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;



namespace WebApplication11
{
   
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=company;user=Baker;password=D5bBP(njHvQh7(ND ;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM employee", connection))
                {
                    DataTable employee = new DataTable();
                    adapter.Fill(employee);

                    GridView1.DataSource = employee;
                    GridView1.DataBind();
                }
            }


               

        }
    }
}