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
    public partial class Security_Question : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("usp_show_sec", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            grd.DataSource = ds;
            grd.DataBind();
        }
        private void empty()
        {
            txtsque.Text = "";
        }
        protected void savebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_insert_security", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@squestion", txtsque.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            empty();
            show();
        }

        protected void grd_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grd.EditIndex = e.NewEditIndex;
            show();
        }

        protected void grd_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string p = grd.DataKeys[e.RowIndex].Value.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_sec_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sqid", p);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
        }

        protected void grd_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grd.EditIndex = -1;
            show();
        }

        protected void grd_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox T1 = grd.Rows[e.RowIndex].FindControl("txtsque1") as TextBox;
            string p = grd.DataKeys[e.RowIndex].Value.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_sec_update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sqid", p);
            cmd.Parameters.AddWithValue("@squestion", T1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            grd.EditIndex = -1;
            show();
        }

    }
}