using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Assignment2_NguyenVanHa
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.UsersTableAdapter taUser
                = new DataSetTableAdapters.UsersTableAdapter();

            taUser.Fill(ds.Users);//Get the latest and put into ds.Users table

            DataRow[] dr = ds.Users.Select("Username = '" + tbUsername.Text + "'");

            if (dr.Length == 1)
            {
                lblCreateStatus.Visible = true;
                lblCreateStatus.Text = "Account is already existed. Please choose another username!";
            }
            else
            {
                DataSet.UsersRow fRow = ds.Users.NewUsersRow();
                fRow.Username = tbUsername.Text;
                fRow.Password = tbPass.Text;
                fRow.Full_Name = tbName.Text;
                fRow.Email = tbEmail.Text;
                fRow.Country = drdCountry.SelectedItem.ToString();
                fRow.IsAdmin = false;

                //In the offline database
                ds.Users.Rows.Add(fRow);
                //Get it back to the real database
                taUser.Update(ds.Users);

                Response.Write("<script LANGUAGE='JavaScript' >alert('Successfully Registrated!!!')</script>");
                Server.Transfer("Login.aspx");
            }
        }
    }
}