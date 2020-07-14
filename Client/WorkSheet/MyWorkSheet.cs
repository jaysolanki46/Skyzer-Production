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

namespace Skyzer_Production.Client.WorkSheet
{
    public partial class MyWorkSheet : Form
    {
        private DBOperations db;
        private SqlConnection conn;
        private SqlCommand cmd;
        private String sql;
        private SqlDataAdapter adapter;
        private DataTable dbTable;
        private SqlDataReader reader;

        public MyWorkSheet()
        {
            InitializeComponent();
            db = new DBOperations();
            conn = new SqlConnection();
            conn = db.getConn();
            labelDate.Text = DateTime.Now.ToString("dd.MM.yyy");

        }

        private void MyWorkSheet_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {
            labelHeader.Left = (this.panelHeader.Width - labelHeader.Width) / 2;
            labelHeader.Top = (this.panelHeader.Height - labelHeader.Height) / 2;
        }

        private void ButtonBookedSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "insert into MyBooked (Department, [User], Total, Date, HR) values (@department, @user, @total, @date, @hr)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", Departments.BOOKING);
                cmd.Parameters.AddWithValue("@user", LoginInfo.UserID);
                cmd.Parameters.AddWithValue("@total", numericUpDownBookedTotal.Value);
                cmd.Parameters.AddWithValue("@date", monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd MMM yyyy"));
                cmd.Parameters.AddWithValue("@hr", timeHR.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Great! You booked "+ numericUpDownBookedTotal.Value +" machines in "+ timeHR.Value + " hour(s).");
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } finally
            {
                conn.Close();
                reset();
            }
        }

        private void MonthCalendarMyWorkSheet_DateSelected(object sender, DateRangeEventArgs e)
        {
            labelDate.Text = monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd MMM yyyy");
        }

        private void reset()
        {
            timeHR.Value = 1;
            numericUpDownBookedTotal.Value = 0;
        }
    }
}
