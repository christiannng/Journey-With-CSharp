using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment2_NguyenVanHa
{
    public partial class AdminPage : System.Web.UI.Page
    {
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {

            DataSetTableAdapters.UsersTableAdapter taUser
                = new DataSetTableAdapters.UsersTableAdapter();

            taUser.Fill(ds.Users);//Get the latest and put into ds.Users table

            DataRow[] dr = ds.Users.Select("Username = '" + tbUsername.Text + "'");

            if (dr.Length == 1)
            {
                lblStatusUser.Visible = true;
                lblStatusUser.Text = "Account is already existed. Please choose another username!";
                lblStatusUser.ForeColor = System.Drawing.Color.Red;
                lblStatusUser.Visible = true;
            }
            else
            {
                DataSet.UsersRow fRow = ds.Users.NewUsersRow();
                fRow.Username = tbUsername.Text;
                fRow.Password = tbPass.Text;
                fRow.Full_Name = tbName.Text;
                fRow.Email = tbEmail.Text;
                fRow.Country = drdCountry.SelectedItem.ToString();
                if (rbtnAdmin.Checked) fRow.IsAdmin = true;
                else fRow.IsAdmin = false;

                //In the offline database
                ds.Users.Rows.Add(fRow);
                //Get it back to the real database
                taUser.Update(ds.Users);

                //Get the latest database
                taUser.Fill(ds.Users);

                gvUsers.DataSourceID = "SqlDataSource1";//Update Grid View

                lblStatusUser.Text = "Successfully Added New Account";
                lblStatusUser.ForeColor = System.Drawing.Color.Green;
                lblStatusUser.Visible = true;
            }
        }

        protected void btnUpdateUser_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.UsersTableAdapter taUser
                = new DataSetTableAdapters.UsersTableAdapter();

            taUser.Fill(ds.Users);//Get the latest and put into ds.Users table

            int selected = Convert.ToInt32(drdUserID.SelectedValue);


            DataRow[] dr = ds.Users.Select("UserID=" + selected);//Inside is where clause

            if (dr.Length == 1)
            {
                if (tbUsername.Text != "") dr[0]["Username"] = tbUsername.Text;
                if (tbPass.Text != "") dr[0]["Password"] = tbPass.Text;
                if (tbEmail.Text != "") dr[0]["Email"] = tbEmail.Text;
                if (tbName.Text != "") dr[0]["Full Name"] = tbName.Text;
                if (drdCountry.SelectedValue != "-1") dr[0]["Country"] = drdCountry.SelectedItem.Text;
                if (rbtnAdmin.Checked) dr[0]["IsAdmin"] = true;
                else dr[0]["IsAdmin"] = false;

                taUser.Update(ds.Users);//Update to real db

                taUser.Fill(ds.Users);//Get the latest and put into ds.Users table
                gvUsers.DataSourceID = "SqlDataSource1";//Update Grid View

                lblStatusUser.Text = "Successfully updated";
                lblStatusUser.ForeColor = System.Drawing.Color.Green;
                lblStatusUser.Visible = true;
            }
            else
            {
                lblStatusUser.Text = "Unsuccessfully updated";
                lblStatusUser.ForeColor = System.Drawing.Color.Red;
                lblStatusUser.Visible = true;
            }

        }

        protected void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DataSetTableAdapters.UsersTableAdapter taUser
                = new DataSetTableAdapters.UsersTableAdapter();

            taUser.Fill(ds.Users);
            int selected = Convert.ToInt32(drdUserID.SelectedValue);

            DataRow[] dr = ds.Users.Select("UserID=" + selected);

            if (dr.Length == 1)
            {
                dr[0].Delete();
                lblStatusUser.Text = "Successfully deleted";
                lblStatusUser.ForeColor = System.Drawing.Color.Green;
                lblStatusUser.Visible = true;

                taUser.Update(ds.Users);//Update to real db
                taUser.Fill(ds.Users);//Get the latest and put into ds.Users table
                gvUsers.DataSourceID = "SqlDataSource1";//Update Grid View
                drdUserID.DataSourceID = "SqlDataSource1";//Update Dropdownlist
            }
        }

        protected void btnMovieList_Click(object sender, EventArgs e)
        {
            Server.Transfer("MovieList.aspx");
        }
    } 
}