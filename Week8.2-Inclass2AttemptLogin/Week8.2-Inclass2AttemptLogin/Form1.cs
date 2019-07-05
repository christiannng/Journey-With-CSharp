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
        SqlConnection conn = new SqlConnection();
        private string constring = "Server=localhost;Database=Login;User=chris;Password=123";
        private SqlCommand cmd;
        int attempt = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            checkLogin(textBox1.Text, textBox2.Text);
        }

        private void checkLogin(string lbluser, string lblPass)
        {
            conn.ConnectionString = constring;
            SqlCommand cmd = conn.CreateCommand();
            try
            {
                string query = "SELECT * FROM LOGINTABLE WHERE username LIKE '" + lbluser + "';";
                cmd.CommandText = query;

                conn.Open();

                //There is data in this reader.
                //This data must be converted to an object that our datagrid can read.
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(1).Equals(lblPass))
                    {
                        MessageBox.Show("Successfully login");
                    }
                    else
                    {
                        MessageBox.Show("Failed to login attempt " + attempt++);
                    }
                }
                    
                reader.Close();

                if (attempt == 3) this.Close();
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose(); //Clean up memory -> Dispose vs GC.Collect();
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
        }
    }
}
