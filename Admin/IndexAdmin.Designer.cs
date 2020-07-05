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
            this.ToolStripMenuItemReActrivation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTestingService = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSWLoading = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPaperWork = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemKeyLoading = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLogonTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemServiceIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalConfigurarionsFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminalRangesToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.productionToolStripMenuItem,
            this.dispatchToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.fAQToolStripMenuItem});
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
            this.ToolStripMenuItemServiceIssue,
            this.terminalConfigurarionsFunctionsToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // howToDoToolStripMenuItem
            // 
            this.howToDoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemReActrivation,
            this.ToolStripMenuItemTestingService,
            this.ToolStripMenuItemSWLoading,
            this.ToolStripMenuItemPaperWork,
            this.ToolStripMenuItemKeyLoading,
            this.ToolStripMenuItemLogonTest});
            this.howToDoToolStripMenuItem.Name = "howToDoToolStripMenuItem";
            this.howToDoToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.howToDoToolStripMenuItem.Text = "How to do?";
            // 
            // ToolStripMenuItemReActrivation
            // 
            this.ToolStripMenuItemReActrivation.Name = "ToolStripMenuItemReActrivation";
            this.ToolStripMenuItemReActrivation.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMenuItemReActrivation.Text = "Re-activate";
            this.ToolStripMenuItemReActrivation.Click += new System.EventHandler(this.BookingToolStripMenuItem1_Click);
            // 
            // ToolStripMenuItemTestingService
            // 
            this.ToolStripMenuItemTestingService.Name = "ToolStripMenuItemTestingService";
            this.ToolStripMenuItemTestingService.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMenuItemTestingService.Text = "Testing (Service)";
            this.ToolStripMenuItemTestingService.Click += new System.EventHandler(this.TestingServiceToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemSWLoading
            // 
            this.ToolStripMenuItemSWLoading.Name = "ToolStripMenuItemSWLoading";
            this.ToolStripMenuItemSWLoading.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMenuItemSWLoading.Text = "S/W Loading";
            this.ToolStripMenuItemSWLoading.Click += new System.EventHandler(this.ToolStripMenuItemSWLoading_Click);
            // 
            // ToolStripMenuItemPaperWork
            // 
            this.ToolStripMenuItemPaperWork.Name = "ToolStripMenuItemPaperWork";
            this.ToolStripMenuItemPaperWork.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMenuItemPaperWork.Text = "Paper Work";
            this.ToolStripMenuItemPaperWork.Click += new System.EventHandler(this.ToolStripMenuItemPaperWork_Click);
            // 
            // ToolStripMenuItemKeyLoading
            // 
            this.ToolStripMenuItemKeyLoading.Name = "ToolStripMenuItemKeyLoading";
            this.ToolStripMenuItemKeyLoading.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMenuItemKeyLoading.Text = "Key Loading";
            this.ToolStripMenuItemKeyLoading.Click += new System.EventHandler(this.ToolStripMenuItemKeyLoading_Click);
            // 
            // ToolStripMenuItemLogonTest
            // 
            this.ToolStripMenuItemLogonTest.Name = "ToolStripMenuItemLogonTest";
            this.ToolStripMenuItemLogonTest.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMenuItemLogonTest.Text = "Log-on Test";
            this.ToolStripMenuItemLogonTest.Click += new System.EventHandler(this.ToolStripMenuItemLogonTest_Click);
            // 
            // ToolStripMenuItemServiceIssue
            // 
            this.ToolStripMenuItemServiceIssue.Name = "ToolStripMenuItemServiceIssue";
            this.ToolStripMenuItemServiceIssue.Size = new System.Drawing.Size(258, 22);
            this.ToolStripMenuItemServiceIssue.Text = "Service Issues";
            // 
            // terminalConfigurarionsFunctionsToolStripMenuItem
            // 
            this.terminalConfigurarionsFunctionsToolStripMenuItem.Name = "terminalConfigurarionsFunctionsToolStripMenuItem";
            this.terminalConfigurarionsFunctionsToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.terminalConfigurarionsFunctionsToolStripMenuItem.Text = "Terminal Configurations/Functions";
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
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fAQToolStripMenuItem.Text = "FAQ";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.FAQToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemReActrivation;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTestingService;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSWLoading;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPaperWork;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemKeyLoading;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLogonTest;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemServiceIssue;
        private System.Windows.Forms.ToolStripMenuItem terminalConfigurarionsFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
    }
}