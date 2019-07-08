using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Week8._2_Inclass2AttemptLogin
{
    public partial class Form1 : Form
    {
        int attempt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            checkLogin(textBox1.Text, textBox2.Text);
        }

        private void checkLogin(string username, string password)
        {
            if (username == "" || password == "")
            {
                MessageBox.Show("Username and/or password cannot be empty",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoginInfoDataSet ds1 = new LoginInfoDataSet();
                LoginInfoDataSetTableAdapters.LoginInfoTableAdapter taLogin
                    = new LoginInfoDataSetTableAdapters.LoginInfoTableAdapter();

                taLogin.Fill(ds1.LoginInfo);
                DataRow[] dr = ds1.LoginInfo.Select("username = '" + username + "'");

                if (dr[0]["password"].ToString() == password)
                {
                    MessageBox.Show("Login successfully", "Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed. Attempt #" + ++attempt, "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if(attempt == 3) { this.Close(); }

                taLogin.Fill(ds1.LoginInfo);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
        }
    }
}
