using Skyzer_Production.Init;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyzer_Production.Admin.User
{
    public partial class Users : Form
    {
        private DBOperations db;
        private SqlConnection conn;
        private SqlCommand cmd;
        private String sql;
        private SqlDataAdapter adapter;
        private DataTable dbTable;
        private SqlDataReader reader;

        public Users()
        {
            InitializeComponent();
            db = new DBOperations();
            conn = new SqlConnection();
            conn = db.getConn();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "insert into Users" +
                " values (@username, @pass)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
            cmd.Parameters.AddWithValue("@pass", textBoxPassword.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Saved Successfully !");
            clear();
        }

        private void clear()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
