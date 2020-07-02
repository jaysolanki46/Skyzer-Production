using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyzer_Production.Admin.Production
{
    public partial class ReActivate : Form
    {
        public ReActivate()
        {
            InitializeComponent();
        }

        private void ReActivate_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            labelDivider.AutoSize = false;
            labelDivider.Height = 2;
            labelDivider.BorderStyle = BorderStyle.Fixed3D;
            labelDivider.Text = "------------------------------------------------------------------------------------------------------------------";
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
           

        }
    }
}
