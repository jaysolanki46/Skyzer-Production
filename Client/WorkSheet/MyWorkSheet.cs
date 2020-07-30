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

        private int myTotalBooked = 0;
        private int myTotalServiced = 0;
        private int myTotalProduction = 0;
        private int myTotalDispatched = 0;
        private int myTotalRetured = 0;

        public MyWorkSheet()
        {
            InitializeComponent();
            db = new DBOperations();
            conn = new SqlConnection();
            conn = db.getConn();
            labelDate.Text = DateTime.Now.ToString("dd.MM.yyy");

            myTotalBooked = 0;
            myTotalServiced = 0;
            myTotalProduction = 0;
            myTotalDispatched = 0;
            myTotalRetured = 0;
            chart();

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
                chart();
            }
        }

        private void MonthCalendarMyWorkSheet_DateSelected(object sender, DateRangeEventArgs e)
        {
            labelDate.Text = monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd MMM yyyy");
        }

        private void ButtonServicedSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "insert into MyServiced (Department, [User], Quot, Repaired, Date, HR) values (@department, @user, @quot, @repaired, @date, @hr)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", Departments.SERVICE);
                cmd.Parameters.AddWithValue("@user", LoginInfo.UserID);
                cmd.Parameters.AddWithValue("@quot", numericUpDownServicedQuot.Value);
                cmd.Parameters.AddWithValue("@repaired", numericUpDownServicedRepaired.Value);
                cmd.Parameters.AddWithValue("@date", monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd MMM yyyy"));
                cmd.Parameters.AddWithValue("@hr", timeHR.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Great! You quot " + numericUpDownServicedQuot.Value + " & repaired "+ numericUpDownServicedRepaired.Value + " machines in " + timeHR.Value + " hour(s).");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                reset();
                chart();
            }
        }

        private void ButtonProductionSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "insert into MyProduction (Department, [User], [Re-act], Test, SWLoad, PaperWork, KeyLoad, LogOn, Date, HR) " +
                    "values (@department, @user, @react, @test, @swLoad, @paperWork, @keyLoad, @logOn, @date, @hr)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", Departments.PRODUCTION);
                cmd.Parameters.AddWithValue("@user", LoginInfo.UserID);
                cmd.Parameters.AddWithValue("@react", numericUpDownProductionReAct.Value);
                cmd.Parameters.AddWithValue("@test", numericUpDownProductionTest.Value);
                cmd.Parameters.AddWithValue("@swLoad", numericUpDownProductionSWLoad.Value);
                cmd.Parameters.AddWithValue("@paperWork", numericUpDownProductionPaperWork.Value);
                cmd.Parameters.AddWithValue("@keyLoad", numericUpDownProductionKeyLoad.Value);
                cmd.Parameters.AddWithValue("@logOn", numericUpDownProductionLogOn.Value);
                cmd.Parameters.AddWithValue("@date", monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd MMM yyyy"));
                cmd.Parameters.AddWithValue("@hr", timeHR.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Great! You re-activated " + numericUpDownProductionReAct.Value + 
                    ", test " + numericUpDownProductionTest.Value +
                    ", sw load " + numericUpDownProductionSWLoad.Value +
                    ", paper work " + numericUpDownProductionPaperWork.Value +
                    ", keyload " + numericUpDownProductionKeyLoad.Value +
                    ", logon " + numericUpDownProductionLogOn.Value +
                    " machines in " + timeHR.Value + " hour(s).");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                reset();
                chart();
            }
        }

        private void ButtonDispatchedSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "insert into MyDispatched (Department, [User], Dispatched, Sold, Date, HR) " +
                    "values (@department, @user, @dispatched, @returned, @sold, @date, @hr)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", Departments.DISPATCH);
                cmd.Parameters.AddWithValue("@user", LoginInfo.UserID);
                cmd.Parameters.AddWithValue("@dispatched", numericUpDownDispatchedDispatched.Value);
                cmd.Parameters.AddWithValue("@sold", numericUpDownDispatchedSold.Value);
                cmd.Parameters.AddWithValue("@date", monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd MMM yyyy"));
                cmd.Parameters.AddWithValue("@hr", timeHR.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Great! You dispatched " + numericUpDownDispatchedDispatched.Value + 
                    ", sold " + numericUpDownDispatchedSold.Value +
                    " machines in " + timeHR.Value + " hour(s).");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                reset();
                chart();
            }
        }

        private void ButtonReturedSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "insert into MyReturned (Department, [User], Total, Date, HR) values (@department, @user, @total, @date, @hr)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", Departments.RETURN);
                cmd.Parameters.AddWithValue("@user", LoginInfo.UserID);
                cmd.Parameters.AddWithValue("@total", numericUpDownReturedTotal.Value);
                cmd.Parameters.AddWithValue("@date", monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd MMM yyyy"));
                cmd.Parameters.AddWithValue("@hr", timeHR.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Great! You returned " + numericUpDownReturedTotal.Value + " machines in " + timeHR.Value + " hour(s).");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                reset();
                chart();
            }
        }

        private void reset()
        {
            timeHR.Value = 1;
            numericUpDownBookedTotal.Value = 0;
            numericUpDownServicedQuot.Value = 0;
            numericUpDownServicedRepaired.Value = 0;
            numericUpDownProductionReAct.Value = 0;
            numericUpDownProductionTest.Value = 0;
            numericUpDownProductionSWLoad.Value = 0;
            numericUpDownProductionPaperWork.Value = 0;
            numericUpDownProductionKeyLoad.Value = 0;
            numericUpDownProductionLogOn.Value = 0;
            numericUpDownDispatchedDispatched.Value = 0;
            numericUpDownDispatchedSold.Value = 0;
            numericUpDownReturedTotal.Value = 0;
        }

        private void chart()
        {
            // Get from db
            chartMyWorkSheet.Series["My work"].Points.Clear();
            chartMyWorkSheet.Series["My work"].Points.AddXY("Booking", getMyTotalBooked());
            chartMyWorkSheet.Series["My work"].Points[0].Color = Color.FromArgb(84, 187, 78);
                       
            chartMyWorkSheet.Series["My work"].Points.AddXY("Service", getMyTotalServiced());
            chartMyWorkSheet.Series["My work"].Points[1].Color = Color.FromArgb(172, 89, 207);

            chartMyWorkSheet.Series["My work"].Points.AddXY("Production", getMyTotalProduction());
            chartMyWorkSheet.Series["My work"].Points[2].Color = Color.FromArgb(112, 175, 228);

            chartMyWorkSheet.Series["My work"].Points.AddXY("Dispatch", getMyTotalDispatched());
            chartMyWorkSheet.Series["My work"].Points[3].Color = Color.FromArgb(186, 86, 88);

            chartMyWorkSheet.Series["My work"].Points.AddXY("Return", getMyTotalRetured());
            chartMyWorkSheet.Series["My work"].Points[4].Color = Color.FromArgb(191, 123, 162);
        }

        private int getMyTotalBooked()
        {
            try
            {
                myTotalBooked = 0;
                conn.Open();
                sql = "Select * from MyBooked where Department = @department and [User] = @usr";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", Departments.BOOKING);
                cmd.Parameters.AddWithValue("@usr", LoginInfo.UserID);
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    myTotalBooked += int.Parse(reader["Total"].ToString());
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

            return myTotalBooked;
        }

        private int getMyTotalServiced()
        {
            try
            {
                myTotalServiced = 0;
                conn.Open();
                sql = "Select * from MyServiced where Department = @department and [User] = @usr";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", Departments.SERVICE);
                cmd.Parameters.AddWithValue("@usr", LoginInfo.UserID);
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    myTotalServiced += int.Parse(reader["Quot"].ToString()) 
                        + int.Parse(reader["Repaired"].ToString());
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

            return myTotalServiced;
        }

        private int getMyTotalProduction()
        {
            try
            {
                myTotalProduction = 0;
                conn.Open();
                sql = "Select * from MyProduction where Department = @department and [User] = @usr";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", Departments.PRODUCTION);
                cmd.Parameters.AddWithValue("@usr", LoginInfo.UserID);
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    myTotalProduction += int.Parse(reader["Re-act"].ToString())
                        + int.Parse(reader["Test"].ToString())
                        + int.Parse(reader["SWLoad"].ToString())
                        + int.Parse(reader["PaperWork"].ToString())
                        + int.Parse(reader["KeyLoad"].ToString())
                        + int.Parse(reader["LogOn"].ToString())
                        + int.Parse(reader["LogOn"].ToString())
                        + int.Parse(reader["LogOn"].ToString());
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

            return myTotalProduction;
        }

        private int getMyTotalDispatched()
        {
            try
            {
                myTotalDispatched = 0;
                conn.Open();
                sql = "Select * from MyDispatched where Department = @department and [User] = @usr";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", Departments.DISPATCH);
                cmd.Parameters.AddWithValue("@usr", LoginInfo.UserID);
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    myTotalDispatched += int.Parse(reader["Dispatched"].ToString())
                        + int.Parse(reader["Sold"].ToString());
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

            return myTotalDispatched;
        }

        private int getMyTotalRetured()
        {
            try
            {
                myTotalRetured = 0;
                conn.Open();
                sql = "Select * from MyReturned where Department = @department and [User] = @usr";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", Departments.RETURN);
                cmd.Parameters.AddWithValue("@usr", LoginInfo.UserID);
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    myTotalRetured += int.Parse(reader["Total"].ToString());
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

            return myTotalRetured;
        }

    }
}
