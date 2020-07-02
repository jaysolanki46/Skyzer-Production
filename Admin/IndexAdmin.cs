using Skyzer_Production.Admin.General;
using Skyzer_Production.Admin.Production;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyzer_Production.Admin
{
    public partial class IndexAdmin : Form
    {
        public IndexAdmin()
        {
            InitializeComponent();
        }

        private void RangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TerminalRanges ranges = new TerminalRanges();
            ranges.MdiParent = this;
            ranges.Show();
        }

        private void IndexAdmin_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void BookingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReActivate reActivate = new ReActivate();
            reActivate.MdiParent = this;
            reActivate.Show();

        }
    }
}
