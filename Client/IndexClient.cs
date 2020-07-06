using Skyzer_Production.Admin.General;
using Skyzer_Production.Client.Production;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyzer_Production.Client
{
    public partial class IndexClient : Form
    {
        public IndexClient()
        {
            InitializeComponent();
        }

        private void IndexClient_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void hideSubMenu()
        {
            if(panelBookingSubMenu.Visible == true)
            {
                panelBookingSubMenu.Visible = false;
            }
            if (panelService.Visible == true)
            {
                panelService.Visible = false;
            }
            if (panelProduction.Visible == true)
            {
                panelProduction.Visible = false;
            }
            if (panelDispatch.Visible == true)
            {
                panelDispatch.Visible = false;
            }
            if (panelWorkSheet.Visible == true)
            {
                panelWorkSheet.Visible = false;
            }
        }

        private void showSubMenu(Panel SubMenu)
        {
            if(SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            } else
            {
                SubMenu.Visible = false;
            }
        }

        private void ButtonBooking_Click(object sender, EventArgs e)
        {

            showSubMenu(panelBookingSubMenu);
        }

        private void ButtonBookingHow_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void ButtonBookingIssues_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void ButtonService_Click(object sender, EventArgs e)
        {
            showSubMenu(panelService);
        }

        private void ButtonServiceHow_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void ButtonProduction_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProduction);
        }

        private void ButtonProductionHow_Click(object sender, EventArgs e)
        {
            bool found = false;
            try
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    //Checks if the window is already open, and brings it to the front if it is
                    Form n = Application.OpenForms[i];
                    if (n.Name == "ProductionHow")
                    {
                        n.BringToFront();
                        found = true;
                    }
                }
                if (!found)
                {
                    ProductionHow pHow = new ProductionHow();
                    pHow.Name = "ProductionHow";
                    pHow.MdiParent = this;
                    pHow.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            hideSubMenu();
        }

        private void ButtonServiceFaulty_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void ButtonDispatch_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDispatch);
        }

        private void ButtonDispatcHow_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void ButtonWorkSheet_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWorkSheet);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void ButtonMyWorkSheet_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void ButtonFAQs_Click(object sender, EventArgs e)
        {
            /*
            bool found = false;
            try
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    //Checks if the window is already open, and brings it to the front if it is
                    Form n = Application.OpenForms[i];
                    if (n.Name == "FAQ")
                    {
                        n.BringToFront();
                        found = true;
                    }
                }
                if (!found)
                {
                    FAQ faq = new FAQ();
                    faq.Name = "FAQ";
                    faq.MdiParent = this;
                    faq.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }

        private void IconButtonBooking_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBookingSubMenu);
        }
    }
}
