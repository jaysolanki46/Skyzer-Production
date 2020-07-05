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
    public partial class FAQ : Form
    {
        private DBOperations db;
        private SqlConnection conn;
        private SqlCommand cmd;
        private String sql;
        private SqlDataAdapter adapter;
        private DataTable dbTable;
        private SqlDataReader reader;
        private String fileLocation = "";

        public FAQ()
        {
            InitializeComponent();
            db = new DBOperations();
            conn = new SqlConnection();
            conn = db.getConn();
        }

        private void ButtonFileUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileLocation = dialog.FileName;
                    labelFileName.Text = Path.GetFileName(fileLocation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FAQ_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            labelDivider.AutoSize = false;
            labelDivider.Height = 2;
            labelDivider.BorderStyle = BorderStyle.Fixed3D;
            labelDivider.Text = "------------------------------------------------------------------------------------------------------------------";

        }

        private void ComboBoxDepartment_DropDown(object sender, EventArgs e)
        {
            FillComboBoxDepartments();
        }

        private void FillComboBoxDepartments()
        {
            comboBoxDepartment.DataSource = null;
            conn.Open();

            sql = "select * from FAQDepartments";
            cmd = new SqlCommand(sql, conn);
            dbTable = new DataTable();
            dbTable.Load(cmd.ExecuteReader());
            comboBoxDepartment.DataSource = dbTable;
            comboBoxDepartment.ValueMember = "Id";
            comboBoxDepartment.DisplayMember = "Name";
            conn.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            comboBoxDepartment.SelectedIndex = 0;          
            textBoxQuestion.Text = "";
            richTextBoxAnswer.Text = "";
            labelFileName.Text = "";
            fileLocation = "";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileLocation != "")
                {
                    string filePath = fileLocation;
                    FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(stream);
                    byte[] file = reader.ReadBytes((int)stream.Length);
                    reader.Close();
                    stream.Close();

                    conn.Open();
                    sql = "insert into FAQs values (@department, @ques, @ans, @fileName, @fileUploadPath)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@department", comboBoxDepartment.SelectedValue);
                    cmd.Parameters.AddWithValue("@ques", textBoxQuestion.Text);
                    cmd.Parameters.AddWithValue("@ans", richTextBoxAnswer.Text);
                    cmd.Parameters.AddWithValue("@fileName", Path.GetFileName(fileLocation));
                    cmd.Parameters.Add("@fileUploadPath", SqlDbType.Binary, file.Length).Value = file;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    sql = "insert into FAQs (FAQDepartment, Ques, Ans)" +
                        " values (@department, @ques, @ans)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@department", comboBoxDepartment.SelectedValue);
                    cmd.Parameters.AddWithValue("@ques", textBoxQuestion.Text);
                    cmd.Parameters.AddWithValue("@ans", richTextBoxAnswer.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Saved Successfully !");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
