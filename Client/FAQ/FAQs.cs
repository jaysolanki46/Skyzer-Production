using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyzer_Production.Client.FAQ
{
    public partial class FAQs : Form
    {
        public FAQs()
        {
            InitializeComponent();
        }

        private void FAQs_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {
            labelHeader.Left = (this.panelHeader.Width - labelHeader.Width) / 2;
            labelHeader.Top = (this.panelHeader.Height - labelHeader.Height) / 2;
        }

        private void LabelStage2labelStage1ForReActivation_Click(object sender, EventArgs e)
        {

        }
    }
}
