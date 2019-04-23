using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Homework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["pp"] != null && Session["pp"].ToString() != "")
            {
                if (!IsPostBack)
                {
                    //
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        private void empty()
        {
            txtcname.Text = txtcnumber.Text = txtcomments.Text = txtcperson.Text = txtemail.Text = txtloc.Text = txturl.Text = "";
        }
        protected void savebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_insert_company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cname", txtcname.Text);
            cmd.Parameters.AddWithValue("@cloc", txtloc.Text); 
            cmd.Parameters.AddWithValue("@curl", txturl.Text); 
            cmd.Parameters.AddWithValue("@ccperson", txtcperson.Text); 
            cmd.Parameters.AddWithValue("@ccnumber", txtcnumber.Text);
            cmd.Parameters.AddWithValue("@comments", txtcomments.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            empty();
        }
    }
}