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
    public partial class Manage_Company : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["pp"] != null && Session["pp"].ToString() != "")
            {
                if (!IsPostBack)
                {
                    show();
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        private void show()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_show_company", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            grd.DataSource = ds;
            grd.DataBind();
        }

        protected void grd_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string p = grd.DataKeys[e.RowIndex].Value.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_company_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cid", p);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
        }

        protected void grd_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox T1 = grd.Rows[e.RowIndex].FindControl("txtcname1") as TextBox;
            TextBox T2 = grd.Rows[e.RowIndex].FindControl("txtcloc1") as TextBox;
            TextBox T3 = grd.Rows[e.RowIndex].FindControl("txtcurl") as TextBox;
            TextBox T4 = grd.Rows[e.RowIndex].FindControl("txtcperson1") as TextBox;
            TextBox T5 = grd.Rows[e.RowIndex].FindControl("txtcnumber1") as TextBox;
            TextBox T6 = grd.Rows[e.RowIndex].FindControl("txtcomments1") as TextBox;
            string p = grd.DataKeys[e.RowIndex].Value.ToString();

            con.Open();
            SqlCommand cmd = new SqlCommand("usp_company_update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cid", p);
            cmd.Parameters.AddWithValue("@cname", T1.Text);
            cmd.Parameters.AddWithValue("@cloc", T2.Text);
            cmd.Parameters.AddWithValue("@curl", T3.Text);
            cmd.Parameters.AddWithValue("@ccperson", T4.Text);
            cmd.Parameters.AddWithValue("@ccnumber", T5.Text);
            cmd.Parameters.AddWithValue("@comments", T6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            grd.EditIndex = -1;
            show();
        }

        protected void grd_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grd.EditIndex = e.NewEditIndex;
            show();
        }

        

        protected void grd_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grd.EditIndex = -1;
            show();
        }
    }
}