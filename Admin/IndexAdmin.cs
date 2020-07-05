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

        private void TestingServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testing testing = new Testing();
            testing.MdiParent = this;
            testing.Show();
        }

        private void ToolStripMenuItemSWLoading_Click(object sender, EventArgs e)
        {
            SWLoading swLoading = new SWLoading();
            swLoading.MdiParent = this;
            swLoading.Show();
        }

        private void ToolStripMenuItemPaperWork_Click(object sender, EventArgs e)
        {
            PaperWork paperWork = new PaperWork();
            paperWork.MdiParent = this;
            paperWork.Show();
        }

        private void ToolStripMenuItemKeyLoading_Click(object sender, EventArgs e)
        {
            KeyLoading keyload = new KeyLoading();
            keyload.MdiParent = this;
            keyload.Show();
        }

        private void ToolStripMenuItemLogonTest_Click(object sender, EventArgs e)
        {
            LogOnTesting logOn = new LogOnTesting();
            logOn.MdiParent = this;
            logOn.Show();
        }

        private void FAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAQ fAQ = new FAQ();
            fAQ.MdiParent = this;
            fAQ.Show();
        }
    }
}
