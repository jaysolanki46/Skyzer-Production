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

namespace Skyzer_Production.Admin.General
{
    public partial class TerminalRanges : Form
    {
        private DBOperations db;
        private SqlConnection conn;
        private SqlCommand cmd;
        private String sql;
        private SqlDataAdapter adapter;
        private DataTable dbTable;
        private SqlDataReader reader;


        public TerminalRanges()
        {
            InitializeComponent();
            db = new DBOperations();
            conn = new SqlConnection();
            conn = db.getConn();
            Ranges();
            Serials();
            FillComboBoxRanges();
        }

        private void Ranges_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            menuTabs.Left = (this.ClientSize.Width - menuTabs.Width) / 2;
            menuTabs.Top = (this.ClientSize.Height - menuTabs.Height) / 2;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            sql = "insert into Ranges (name) values (@name)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", textBoxRangeName.Text.ToUpper());
            cmd.ExecuteNonQuery();
            conn.Close();

            Ranges();
        }

        private void Ranges()
        {
            conn.Open();
            sql = "select * from Ranges";
            adapter = new SqlDataAdapter(sql, conn);
            dbTable = new DataTable();
            adapter.Fill(dbTable);
            dataGridViewRanges.AutoGenerateColumns = false;
            dataGridViewRanges.DataSource = dbTable;
            conn.Close();
        }

        private void Serials()
        {
            conn.Open();
            sql = "select r.Name as Range, s.Name as Name from Ranges r, Series s where r.Id = s.Range";
            adapter = new SqlDataAdapter(sql, conn);
            dbTable = new DataTable();
            adapter.Fill(dbTable);
            dataGridViewSeries.AutoGenerateColumns = false;
            dataGridViewSeries.DataSource = dbTable;
            conn.Close();
        }

        private void FillComboBoxRanges()
        {
            comboBoxRange.DataSource = null;
            conn.Open();
            sql = "select * from Ranges";
            cmd = new SqlCommand(sql, conn);
            dbTable = new DataTable();
            dbTable.Load(cmd.ExecuteReader());
            comboBoxRange.DataSource = dbTable;
            comboBoxRange.ValueMember = "Id";
            comboBoxRange.DisplayMember = "Name";
            
            conn.Close();
        }

        private void ButtonSeriesAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "insert into Series (Range, Name) values (@range, @name)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@range", comboBoxRange.SelectedValue);
            cmd.Parameters.AddWithValue("@name", textBoxSeriesName.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            Serials();
        }

    }
}
