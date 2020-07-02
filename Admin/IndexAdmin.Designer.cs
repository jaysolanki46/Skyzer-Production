namespace Skyzer_Production.Admin
{
    partial class IndexAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.terminalRangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testingServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sWLoadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paperWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyLoadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logonTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminalRangesToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.productionToolStripMenuItem,
            this.dispatchToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // terminalRangesToolStripMenuItem
            // 
            this.terminalRangesToolStripMenuItem.Name = "terminalRangesToolStripMenuItem";
            this.terminalRangesToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.terminalRangesToolStripMenuItem.Text = "Terminal Ranges";
            this.terminalRangesToolStripMenuItem.Click += new System.EventHandler(this.RangesToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToDoToolStripMenuItem,
            this.serviceIssuesToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // howToDoToolStripMenuItem
            // 
            this.howToDoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingToolStripMenuItem1,
            this.testingServiceToolStripMenuItem,
            this.sWLoadingToolStripMenuItem,
            this.paperWorkToolStripMenuItem,
            this.keyLoadingToolStripMenuItem,
            this.logonTestToolStripMenuItem});
            this.howToDoToolStripMenuItem.Name = "howToDoToolStripMenuItem";
            this.howToDoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.howToDoToolStripMenuItem.Text = "How to do?";
            // 
            // bookingToolStripMenuItem1
            // 
            this.bookingToolStripMenuItem1.Name = "bookingToolStripMenuItem1";
            this.bookingToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bookingToolStripMenuItem1.Text = "Re-activate";
            this.bookingToolStripMenuItem1.Click += new System.EventHandler(this.BookingToolStripMenuItem1_Click);
            // 
            // testingServiceToolStripMenuItem
            // 
            this.testingServiceToolStripMenuItem.Name = "testingServiceToolStripMenuItem";
            this.testingServiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testingServiceToolStripMenuItem.Text = "Testing (Service)";
            // 
            // sWLoadingToolStripMenuItem
            // 
            this.sWLoadingToolStripMenuItem.Name = "sWLoadingToolStripMenuItem";
            this.sWLoadingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sWLoadingToolStripMenuItem.Text = "S/W Loading";
            // 
            // paperWorkToolStripMenuItem
            // 
            this.paperWorkToolStripMenuItem.Name = "paperWorkToolStripMenuItem";
            this.paperWorkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paperWorkToolStripMenuItem.Text = "Paper Work";
            // 
            // keyLoadingToolStripMenuItem
            // 
            this.keyLoadingToolStripMenuItem.Name = "keyLoadingToolStripMenuItem";
            this.keyLoadingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.keyLoadingToolStripMenuItem.Text = "Key Loading";
            // 
            // logonTestToolStripMenuItem
            // 
            this.logonTestToolStripMenuItem.Name = "logonTestToolStripMenuItem";
            this.logonTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logonTestToolStripMenuItem.Text = "Log-on Test";
            // 
            // dispatchToolStripMenuItem
            // 
            this.dispatchToolStripMenuItem.Name = "dispatchToolStripMenuItem";
            this.dispatchToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.dispatchToolStripMenuItem.Text = "Dispatch";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.returnToolStripMenuItem.Text = "Return";
            // 
            // serviceIssuesToolStripMenuItem
            // 
            this.serviceIssuesToolStripMenuItem.Name = "serviceIssuesToolStripMenuItem";
            this.serviceIssuesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviceIssuesToolStripMenuItem.Text = "Service Issues";
            // 
            // IndexAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IndexAdmin";
            this.Text = "Skyzer Production Admin";
            this.Load += new System.EventHandler(this.IndexAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem terminalRangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testingServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sWLoadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paperWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyLoadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logonTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceIssuesToolStripMenuItem;
    }
}