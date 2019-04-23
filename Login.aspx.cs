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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_user_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uname", txtuname.Text);
            cmd.Parameters.AddWithValue("@psd", txtpsd.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["pp"] = ds.Tables[0].Rows[0]["regid"].ToString();
                Response.Redirect("Home.aspx"); //?regid=" + ds.Tables[0].Rows[0]["regid"].ToString());
            }
            else
            {
                lblmsg.Text = "Login Failed !!!";
            }
        }
    }
}