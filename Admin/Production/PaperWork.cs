﻿using Skyzer_Production.Init;
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

namespace Skyzer_Production.Admin.Production
{
    public partial class PaperWork : Form
    {
        private DBOperations db;
        private SqlConnection conn;
        private SqlCommand cmd;
        private String sql;
        private SqlDataAdapter adapter;
        private DataTable dbTable;
        private SqlDataReader reader;
        DataSet ds;
        private String fileLocation = "";

        public PaperWork()
        {
            InitializeComponent();
            db = new DBOperations();
            conn = new SqlConnection();
            conn = db.getConn();
            FillComboBoxRanges();
        }

        private void PaperWork_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            labelDivider.AutoSize = false;
            labelDivider.Height = 2;
            labelDivider.BorderStyle = BorderStyle.Fixed3D;
            labelDivider.Text = "------------------------------------------------------------------------------------------------------------------";

            comboBoxRange.Text = "--Select--";
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

        private void FillComboBoxTerminal(object range)
        {
            comboBoxTerminal.DataSource = null;
            conn.Open();

            sql = "select * from Terminals where Range = @range";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@range", range);
            dbTable = new DataTable();
            dbTable.Load(cmd.ExecuteReader());
            comboBoxTerminal.DataSource = dbTable;
            comboBoxTerminal.ValueMember = "Id";
            comboBoxTerminal.DisplayMember = "Name";
            conn.Close();
        }

        private void ComboBoxTerminal_Leave(object sender, EventArgs e)
        {
            byte[] getImg = new byte[0];
            conn.Open();
            sql = "select * from Terminals where Id = @id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", comboBoxTerminal.SelectedValue);
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                getImg = (byte[])dr["ImagePath"];
            }

            byte[] imgData = getImg;
            MemoryStream stream = new MemoryStream(imgData);
            pictureBoxTerminal.Image = Image.FromStream(stream);
            conn.Close();
        }

        private void ComboBoxTerminal_DropDown(object sender, EventArgs e)
        {
            FillComboBoxTerminal(comboBoxRange.SelectedValue);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            comboBoxRange.SelectedIndex = 0;
            comboBoxTerminal.SelectedIndex = -1;
            if (pictureBoxTerminal.Image != null)
            {
                pictureBoxTerminal.Image.Dispose();
                pictureBoxTerminal.Image = null;
            }

            richTextBoxInitNote.Text = "";
            richTextBoxTaskTime.Text = "";
            richTextBoxCall.Text = "";
            richTextBoxHistory.Text = "";
            richTextBoxParts.Text = "";
            richTextBoxNitro.Text = "";
            richTextBoxEndNote.Text = "";
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
                    sql = "insert into ProductionPaperWork values (@termial, @initNote, @taskTime, @call, @history, @parts, @nitro, @endNote, @fileName, @fileUploadPath)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@termial", comboBoxTerminal.SelectedValue);
                    cmd.Parameters.AddWithValue("@initNote", richTextBoxInitNote.Text);
                    cmd.Parameters.AddWithValue("@taskTime", richTextBoxTaskTime.Text);
                    cmd.Parameters.AddWithValue("@call", richTextBoxCall.Text);
                    cmd.Parameters.AddWithValue("@history", richTextBoxHistory.Text);
                    cmd.Parameters.AddWithValue("@parts", richTextBoxParts.Text);
                    cmd.Parameters.AddWithValue("@nitro", richTextBoxNitro.Text);
                    cmd.Parameters.AddWithValue("@endNote", richTextBoxEndNote.Text);
                    cmd.Parameters.AddWithValue("@fileName", Path.GetFileName(fileLocation));
                    cmd.Parameters.Add("@fileUploadPath", SqlDbType.Binary, file.Length).Value = file;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    conn.Open();
                    sql = "insert into ProductionPaperWork (Terminal, InitNote, TaskTime, Call, History, Parts, Nitro, EndNote)" +
                        " values (@termial, @initNote, @taskTime, @call, @history, @parts, @nitro, @endNote)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@termial", comboBoxTerminal.SelectedValue);
                    cmd.Parameters.AddWithValue("@initNote", richTextBoxInitNote.Text);
                    cmd.Parameters.AddWithValue("@taskTime", richTextBoxTaskTime.Text);
                    cmd.Parameters.AddWithValue("@call", richTextBoxCall.Text);
                    cmd.Parameters.AddWithValue("@history", richTextBoxHistory.Text);
                    cmd.Parameters.AddWithValue("@parts", richTextBoxParts.Text);
                    cmd.Parameters.AddWithValue("@nitro", richTextBoxNitro.Text);
                    cmd.Parameters.AddWithValue("@endNote", richTextBoxEndNote.Text);
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
