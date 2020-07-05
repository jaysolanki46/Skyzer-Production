using Skyzer_Production.Init;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            Departments();
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
            sql = "select r.Name as Range, s.Name as Name from Ranges r, Terminals s where r.Id = s.Range";
            adapter = new SqlDataAdapter(sql, conn);
            dbTable = new DataTable();
            adapter.Fill(dbTable);
            dataGridViewSeries.AutoGenerateColumns = false;
            dataGridViewSeries.DataSource = dbTable;
            conn.Close();
        }

        private void FillComboBoxRanges()
        {
            conn.Open();
            sql = "select * from Ranges";
            cmd = new SqlCommand(sql, conn);
            dbTable = new DataTable();
            dbTable.Load(cmd.ExecuteReader());
            DataRow row = dbTable.NewRow();
            row["Id"] = -1;
            row["Name"] = "--Select--";
            dbTable.Rows.InsertAt(row, 0);

            comboBoxRange.DataSource = dbTable;
            comboBoxRange.ValueMember = "Id";
            comboBoxRange.DisplayMember = "Name";
            conn.Close();
        }

        private void ButtonSeriesAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string image = pictureBoxTerminal.ImageLocation;
                Bitmap bmp = new Bitmap(image);
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                byte[] bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                fs.Close();

                conn.Open();
                sql = "insert into Terminals (Range, Name, ImagePath) values (@range, @name, @imagePath)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@range", comboBoxRange.SelectedValue);
                cmd.Parameters.AddWithValue("@name", textBoxSeriesName.Text);
                cmd.Parameters.AddWithValue("@imagePath", SqlDbType.Image).Value = bimage;
                cmd.ExecuteNonQuery();
                conn.Close();
                Serials();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Ranges_Click(object sender, EventArgs e)
        {

        }

        private void ButtonImageUpload_Click(object sender, EventArgs e)
        {
            String imageLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBoxTerminal.ImageLocation = imageLocation;

                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void Terminals_Click(object sender, EventArgs e)
        {
            comboBoxRange.Text = "--Select--";
        }

        private void ComboBoxRange_DropDown(object sender, EventArgs e)
        {
            FillComboBoxRanges();
        }

        private void ButtonAddDepartment_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "insert into FAQDepartments (name) values (@name)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", textBoxDepartmentName.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            Departments();
        }

        private void Departments()
        {
            conn.Open();
            sql = "select * from FAQDepartments";
            adapter = new SqlDataAdapter(sql, conn);
            dbTable = new DataTable();
            adapter.Fill(dbTable);
            dataGridViewFAQDepartment.AutoGenerateColumns = false;
            dataGridViewFAQDepartment.DataSource = dbTable;
            conn.Close();
        }
    }
}
