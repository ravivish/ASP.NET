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
    public partial class Home : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["pp"] != null && Session["pp"].ToString() != "")
            {
                if (!IsPostBack)
                {
                    FillGrid();
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        private void FillGrid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_Registration_get_by_id", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@regid", Session["pp"]);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            grd.DataSource = ds;
            grd.DataBind();
        }
    }
}