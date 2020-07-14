using Skyzer_Production.Init;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyzer_Production.Client
{
    public partial class Login : Form
    {
        private DBOperations db;
        private SqlConnection conn;
        private SqlCommand cmd;
        private String sql;
        private SqlDataReader reader;

        public Login()
        {
            InitializeComponent();
            db = new DBOperations();
            conn = new SqlConnection();
            conn = db.getConn();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please provide username & password!");
            } else
            {
                try
                {
                    conn.Open();
                    sql = "Select * from Users where Username = @username and Pass = @pass";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", textBoxUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", textBoxPassword.Text.Trim());
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        //MessageBox.Show(reader["Username"].ToString());
                        LoginInfo.UserID = reader["Id"].ToString();
                        LoginInfo.UserName = reader["Username"].ToString();


                        this.Hide();
                        IndexClient client = new IndexClient();
                        client.buttonLogout.Text = "   Hi, " + LoginInfo.UserName;
                        client.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
           
        }
    }
}
