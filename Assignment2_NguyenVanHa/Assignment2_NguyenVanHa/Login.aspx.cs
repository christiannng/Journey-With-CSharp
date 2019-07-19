using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Assignment2_NguyenVanHa
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.UsersTableAdapter taUser
                = new DataSetTableAdapters.UsersTableAdapter();

            taUser.Fill(ds.Users);//Get the latest and put into ds.Users table

            DataRow[] dr = ds.Users.Select("Username = '" + tbUsername.Text + "'");

            if (dr.Length == 1 && dr[0]["password"].ToString() == tbPassword.Text)
            {
                Session["Discount"] = 20.0;
                if ((bool)dr[0]["IsAdmin"] == true)
                {
                    Session["AdminStatus"] = true;
                    Server.Transfer("AdminPage.aspx");
                }
            }
            else
            {
                lblLoginStatus.Visible = true;
                lblLoginStatus.Text = "Login failed. Username/Password is not correct";
            }

            taUser.Update(ds.Users);
        }

        protected void btnCountinueWithoutAcc_Click(object sender, EventArgs e)
        {
            Session["Discount"] = 0.0;
            Session["AdminStatus"] = false;
            Server.Transfer("MovieList.aspx");

        }

        protected void btnCreateAcc_Click(object sender, EventArgs e)
        {
            Session["AdminStatus"] = false;
            Server.Transfer("Registration.aspx");
        }

    }
}