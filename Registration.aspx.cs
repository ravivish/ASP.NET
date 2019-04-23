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
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                show();
                bindcountry();
                bindcompany();
                bindjobProfile();
                bindqualifiaction();
            }
        }

        private void bindqualifiaction()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_get_registration_data_for_all_Bind", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "qualification");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlqualifiaction.DataValueField = "qid";
                ddlqualifiaction.DataTextField = "qname";
                ddlqualifiaction.DataSource = ds;
                ddlqualifiaction.DataBind();
            }
            else
            {
                ddlqualifiaction.DataSource = null;
                ddlqualifiaction.DataBind();
            }
            ddlqualifiaction.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void bindjobProfile()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_get_registration_data_for_all_Bind", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "jprofile");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddljob.DataValueField = "jid";
                ddljob.DataTextField = "jname";
                ddljob.DataSource = ds;
                ddljob.DataBind();
            }
            else
            {
                ddljob.DataSource = null;
                ddljob.DataBind();
            }
            ddljob.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        private void bindcompany()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_get_registration_data_for_all_Bind", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "company");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlcompany.DataValueField = "cid";
                ddlcompany.DataTextField = "cname";
                ddlcompany.DataSource = ds;
                ddlcompany.DataBind();
            }
            else
            {
                ddlcompany.DataSource = null;
                ddlcompany.DataBind();
            }
            ddlcompany.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        private void bindcountry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_get_registration_data_for_all_Bind", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "country");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlcountry.DataValueField = "cid";
                ddlcountry.DataTextField = "cname";
                ddlcountry.DataSource = ds;
                ddlcountry.DataBind();
            }
            else
            {
                ddlcountry.DataSource = null;
                ddlcountry.DataBind();
            }
            ddlcountry.Items.Insert(0, new ListItem("--Select--", "0"));

        }
        private void show()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_get_registration_data_for_all_Bind", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "registration");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                grd.DataSource = ds;
                grd.DataBind();
            }
            else
            {

                grd.DataSource = null;
                grd.DataBind();
            }
        }
        private void empty()
        {
            txtname.Text = txtpsd.Text = txtuname.Text = "";
            ddlqualifiaction.SelectedValue = "0";
            ddljob.SelectedValue = "0";
            ddlcountry.SelectedValue = "0";
            ddlcompany.SelectedValue = "0";
        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_get_registration_data_for_all_Bind", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "insert");
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@uname", txtuname.Text);
            cmd.Parameters.AddWithValue("@psd", txtpsd.Text);
            cmd.Parameters.AddWithValue("@country", ddlcountry.SelectedValue);
            cmd.Parameters.AddWithValue("@company", ddlcountry.SelectedValue);
            cmd.Parameters.AddWithValue("@jobProfile", ddljob.SelectedValue);
            cmd.Parameters.AddWithValue("@qualification", ddlqualifiaction.SelectedValue);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
            empty();
        }
    }
}