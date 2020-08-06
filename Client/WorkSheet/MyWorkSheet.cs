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

        private int myTotalBooked;
        private int myTotalQuot;
        private int myTotalRepaired;
        private int myTotalReActivated;
        private int myTotalTested;
        private int myTotalSWLoaded;
        private int myTotalPaperWorked;
        private int myTotalKeyLoaded;
        private int myTotalLogOn;
        private int myTotalDispatched;
        private int myTotalSold;
        private int myTotalReturned;

        public MyWorkSheet()
        {
            InitializeComponent();
            db = new DBOperations();
            conn = new SqlConnection();
            conn = db.getConn();
            labelDate.Text = DateTime.Now.ToString("dd.MM.yyy");
            myTotalBooked = 0;
            myTotalQuot = 0;
            myTotalRepaired = 0;
            myTotalReActivated = 0;
            myTotalTested = 0;
            myTotalSWLoaded = 0;
            myTotalPaperWorked = 0;
            myTotalKeyLoaded = 0;
            myTotalLogOn = 0;
            myTotalDispatched = 0;
            myTotalSold = 0;
            myTotalReturned = 0;
            chart(false, false, true, false);

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
                cmd.Parameters.AddWithValue("@date", monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd/MM/yyyy"));
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
                chart(false, false, true, false);
            }
        }

        private void MonthCalendarMyWorkSheet_DateSelected(object sender, DateRangeEventArgs e)
        {
            labelDate.Text = monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd/MM/yyyy");
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
                cmd.Parameters.AddWithValue("@date", monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd/MM/yyyy"));
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
                chart(false, false, true, false);
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
                cmd.Parameters.AddWithValue("@date", monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd/MM/yyyy"));
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
               chart(false, false, true, false);
            }
        }

        private void ButtonDispatchedSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "insert into MyDispatched (Department, [User], Dispatched, Sold, Date, HR) " +
                    "values (@department, @user, @dispatched, @sold, @date, @hr)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@department", Departments.DISPATCH);
                cmd.Parameters.AddWithValue("@user", LoginInfo.UserID);
                cmd.Parameters.AddWithValue("@dispatched", numericUpDownDispatchedDispatched.Value);
                cmd.Parameters.AddWithValue("@sold", numericUpDownDispatchedSold.Value);
                cmd.Parameters.AddWithValue("@date", monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd/MM/yyyy"));
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
               chart(false, false, true, false);
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
                cmd.Parameters.AddWithValue("@date", monthCalendarMyWorkSheet.SelectionRange.Start.ToString("dd/MM/yyyy"));
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
               chart(false, false, true, false);
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

        private void chart(bool isThisMonth, bool isThisWeek, bool isToday, bool isFilter)
        {
            // set values to varibales
            getMyTotalBooked(isThisMonth, isThisWeek, isToday, isFilter);
            getMyTotalServiced(isThisMonth, isThisWeek, isToday, isFilter);
            getMyTotalProduction(isThisMonth, isThisWeek, isToday, isFilter);
            getMyTotalDispatched(isThisMonth, isThisWeek, isToday, isFilter);
            getMyTotalRetured(isThisMonth, isThisWeek, isToday, isFilter);

            // Set XY for all
            chartMyWorkSheet.Series["Booked"].Points.Clear();
            chartMyWorkSheet.Series["Quot"].Points.Clear();
            chartMyWorkSheet.Series["Repaired"].Points.Clear();
            chartMyWorkSheet.Series["Re-activated"].Points.Clear();
            chartMyWorkSheet.Series["Tested"].Points.Clear();
            chartMyWorkSheet.Series["S/W Loaded"].Points.Clear();
            chartMyWorkSheet.Series["Paper Work"].Points.Clear();
            chartMyWorkSheet.Series["Key Loaded"].Points.Clear();
            chartMyWorkSheet.Series["Log On"].Points.Clear();
            chartMyWorkSheet.Series["Dispatched"].Points.Clear();
            chartMyWorkSheet.Series["Sold"].Points.Clear();
            chartMyWorkSheet.Series["Returned"].Points.Clear();

            chartMyWorkSheet.Series["Booked"].Points.AddXY("Booking", myTotalBooked);
            chartMyWorkSheet.Series["Booked"].Points.AddXY("Service", 0);
            chartMyWorkSheet.Series["Booked"].Points.AddXY("Production", 0);
            chartMyWorkSheet.Series["Booked"].Points.AddXY("Dispatch", 0);
            chartMyWorkSheet.Series["Booked"].Points.AddXY("Return", 0);

            chartMyWorkSheet.Series["Quot"].Points.AddXY("Booking", 0);
            chartMyWorkSheet.Series["Quot"].Points.AddXY("Service", myTotalQuot);
            chartMyWorkSheet.Series["Quot"].Points.AddXY("Production", 0);
            chartMyWorkSheet.Series["Quot"].Points.AddXY("Dispatch", 0);
            chartMyWorkSheet.Series["Quot"].Points.AddXY("Return", 0);

            chartMyWorkSheet.Series["Repaired"].Points.AddXY("Booking", 0);
            chartMyWorkSheet.Series["Repaired"].Points.AddXY("Service", myTotalRepaired); //
            chartMyWorkSheet.Series["Repaired"].Points.AddXY("Production", 0);
            chartMyWorkSheet.Series["Repaired"].Points.AddXY("Dispatch", 0);
            chartMyWorkSheet.Series["Repaired"].Points.AddXY("Return", 0);

            chartMyWorkSheet.Series["Re-activated"].Points.AddXY("Booking", 0);
            chartMyWorkSheet.Series["Re-activated"].Points.AddXY("Service", 0);
            chartMyWorkSheet.Series["Re-activated"].Points.AddXY("Production", myTotalReActivated);//
            chartMyWorkSheet.Series["Re-activated"].Points.AddXY("Dispatch", 0);
            chartMyWorkSheet.Series["Re-activated"].Points.AddXY("Return", 0);

            chartMyWorkSheet.Series["Tested"].Points.AddXY("Booking", 0);
            chartMyWorkSheet.Series["Tested"].Points.AddXY("Service", 0);
            chartMyWorkSheet.Series["Tested"].Points.AddXY("Production", myTotalTested);//
            chartMyWorkSheet.Series["Tested"].Points.AddXY("Dispatch", 0);
            chartMyWorkSheet.Series["Tested"].Points.AddXY("Return", 0);

            chartMyWorkSheet.Series["S/W Loaded"].Points.AddXY("Booking", 0);
            chartMyWorkSheet.Series["S/W Loaded"].Points.AddXY("Service", 0);
            chartMyWorkSheet.Series["S/W Loaded"].Points.AddXY("Production", myTotalSWLoaded);//
            chartMyWorkSheet.Series["S/W Loaded"].Points.AddXY("Dispatch", 0);
            chartMyWorkSheet.Series["S/W Loaded"].Points.AddXY("Return", 0);

            chartMyWorkSheet.Series["Paper Work"].Points.AddXY("Booking", 0);
            chartMyWorkSheet.Series["Paper Work"].Points.AddXY("Service", 0);
            chartMyWorkSheet.Series["Paper Work"].Points.AddXY("Production", myTotalPaperWorked);//
            chartMyWorkSheet.Series["Paper Work"].Points.AddXY("Dispatch", 0);
            chartMyWorkSheet.Series["Paper Work"].Points.AddXY("Return", 0);

            chartMyWorkSheet.Series["Key Loaded"].Points.AddXY("Booking", 0);
            chartMyWorkSheet.Series["Key Loaded"].Points.AddXY("Service", 0);
            chartMyWorkSheet.Series["Key Loaded"].Points.AddXY("Production", myTotalKeyLoaded);//
            chartMyWorkSheet.Series["Key Loaded"].Points.AddXY("Dispatch", 0);
            chartMyWorkSheet.Series["Key Loaded"].Points.AddXY("Return", 0);

            chartMyWorkSheet.Series["Log On"].Points.AddXY("Booking", 0);
            chartMyWorkSheet.Series["Log On"].Points.AddXY("Service", 0);
            chartMyWorkSheet.Series["Log On"].Points.AddXY("Production", myTotalLogOn);//
            chartMyWorkSheet.Series["Log On"].Points.AddXY("Dispatch", 0);
            chartMyWorkSheet.Series["Log On"].Points.AddXY("Return", 0);

            chartMyWorkSheet.Series["Dispatched"].Points.AddXY("Booking", 0);
            chartMyWorkSheet.Series["Dispatched"].Points.AddXY("Service", 0);
            chartMyWorkSheet.Series["Dispatched"].Points.AddXY("Production", 0);
            chartMyWorkSheet.Series["Dispatched"].Points.AddXY("Dispatch", myTotalDispatched);//
            chartMyWorkSheet.Series["Dispatched"].Points.AddXY("Return", 0);

            chartMyWorkSheet.Series["Sold"].Points.AddXY("Booking", 0);
            chartMyWorkSheet.Series["Sold"].Points.AddXY("Service", 0);
            chartMyWorkSheet.Series["Sold"].Points.AddXY("Production", 0);
            chartMyWorkSheet.Series["Sold"].Points.AddXY("Dispatch", myTotalSold);//
            chartMyWorkSheet.Series["Sold"].Points.AddXY("Return", 0);

            chartMyWorkSheet.Series["Returned"].Points.AddXY("Booking", 0);
            chartMyWorkSheet.Series["Returned"].Points.AddXY("Service", 0);
            chartMyWorkSheet.Series["Returned"].Points.AddXY("Production", 0);
            chartMyWorkSheet.Series["Returned"].Points.AddXY("Dispatch", 0);
            chartMyWorkSheet.Series["Returned"].Points.AddXY("Return", myTotalReturned);//
            /*
            chartMyWorkSheet.Series["My work"].Points.AddXY("Production", getMyTotalProduction());
            chartMyWorkSheet.Series["My work"].Points[2].Color = Color.FromArgb(112, 175, 228);

            chartMyWorkSheet.Series["My work"].Points.AddXY("Dispatch", getMyTotalDispatched());
            chartMyWorkSheet.Series["My work"].Points[3].Color = Color.FromArgb(186, 86, 88);

            chartMyWorkSheet.Series["My work"].Points.AddXY("Return", getMyTotalRetured());
            chartMyWorkSheet.Series["My work"].Points[4].Color = Color.FromArgb(191, 123, 162);
            */
        }

        private void getMyTotalBooked(bool isThisMonth, bool isThisWeek, bool isToday, bool isFilter)
        {
            try
            {
                myTotalBooked = 0;

                conn.Open();

                if (isThisMonth)
                {

                }
                else if (isThisWeek)
                {
                }
                else if (isToday)
                {
                    
                    sql = "Select * from MyBooked where Department = @department and [User] = @usr  and Date = @date";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("dd-MM-yyyy"));

                } else if (isFilter)
                {

                }

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
        }

        private void getMyTotalServiced(bool isThisMonth, bool isThisWeek, bool isToday, bool isFilter)
        {
            try
            {
                myTotalQuot = 0;
                myTotalRepaired = 0;
                conn.Open();

                if (isThisMonth)
                {

                }
                else if (isThisWeek)
                {
                }
                else if (isToday)
                {

                    sql = "Select * from MyServiced where Department = @department and [User] = @usr  and Date = @date";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("dd-MM-yyyy"));

                }
                else if (isFilter)
                {

                }
                
                cmd.Parameters.AddWithValue("@department", Departments.SERVICE);
                cmd.Parameters.AddWithValue("@usr", LoginInfo.UserID);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    myTotalQuot += int.Parse(reader["Quot"].ToString());
                    myTotalRepaired += int.Parse(reader["Repaired"].ToString());
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

        private void getMyTotalProduction(bool isThisMonth, bool isThisWeek, bool isToday, bool isFilter)
        {
            try
            {
                myTotalReActivated = 0;
                myTotalTested = 0;
                myTotalSWLoaded = 0;
                myTotalPaperWorked = 0;
                myTotalKeyLoaded = 0;
                myTotalLogOn = 0;

                conn.Open();
                if (isThisMonth)
                {

                }
                else if (isThisWeek)
                {
                }
                else if (isToday)
                {

                    sql = "Select * from MyProduction where Department = @department and [User] = @usr  and Date = @date";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("dd-MM-yyyy"));

                }
                else if (isFilter)
                {

                }

                cmd.Parameters.AddWithValue("@department", Departments.PRODUCTION);
                cmd.Parameters.AddWithValue("@usr", LoginInfo.UserID);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    myTotalReActivated += int.Parse(reader["Re-act"].ToString());
                    myTotalTested += int.Parse(reader["Test"].ToString());
                    myTotalSWLoaded += int.Parse(reader["SWLoad"].ToString());
                    myTotalPaperWorked += int.Parse(reader["PaperWork"].ToString());
                    myTotalKeyLoaded += int.Parse(reader["KeyLoad"].ToString());
                    myTotalLogOn += int.Parse(reader["LogOn"].ToString());

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
        
        private void getMyTotalDispatched(bool isThisMonth, bool isThisWeek, bool isToday, bool isFilter)
        {
            try
            {
                myTotalDispatched = 0;
                myTotalSold = 0;
                conn.Open();
                if (isThisMonth)
                {

                }
                else if (isThisWeek)
                {
                }
                else if (isToday)
                {

                    sql = "Select * from MyDispatched where Department = @department and [User] = @usr  and Date = @date";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("dd-MM-yyyy"));

                }
                else if (isFilter)
                {

                }
               
                cmd.Parameters.AddWithValue("@department", Departments.DISPATCH);
                cmd.Parameters.AddWithValue("@usr", LoginInfo.UserID);
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    myTotalDispatched += int.Parse(reader["Dispatched"].ToString());
                    myTotalSold += int.Parse(reader["Sold"].ToString());
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

        private void getMyTotalRetured(bool isThisMonth, bool isThisWeek, bool isToday, bool isFilter)
        {
            try
            {
                myTotalReturned = 0;
                conn.Open();
                if (isThisMonth)
                {

                }
                else if (isThisWeek)
                {
                }
                else if (isToday)
                {

                    sql = "Select * from MyReturned where Department = @department and [User] = @usr  and Date = @date";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("dd-MM-yyyy"));

                }
                else if (isFilter)
                {

                }
               
                cmd.Parameters.AddWithValue("@department", Departments.RETURN);
                cmd.Parameters.AddWithValue("@usr", LoginInfo.UserID);
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    myTotalReturned += int.Parse(reader["Total"].ToString());
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

        private void RadioButtonToday_CheckedChanged(object sender, EventArgs e)
        {
            chart(false, false, true, false);
        }
    }
}
