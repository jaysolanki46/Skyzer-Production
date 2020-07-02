namespace Skyzer_Production.Admin
{
    partial class SkyzerProductionAdmin
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
            this.rangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rangesToolStripMenuItem,
            this.typesToolStripMenuItem,
            this.howToDoToolStripMenuItem,
            this.fAQToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rangesToolStripMenuItem
            // 
            this.rangesToolStripMenuItem.Name = "rangesToolStripMenuItem";
            this.rangesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.rangesToolStripMenuItem.Text = "Ranges";
            this.rangesToolStripMenuItem.Click += new System.EventHandler(this.RangesToolStripMenuItem_Click);
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.typesToolStripMenuItem.Text = "Types";
            // 
            // howToDoToolStripMenuItem
            // 
            this.howToDoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.productionToolStripMenuItem,
            this.dispatchToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.howToDoToolStripMenuItem.Name = "howToDoToolStripMenuItem";
            this.howToDoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.howToDoToolStripMenuItem.Text = "How to do?";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // dispatchToolStripMenuItem
            // 
            this.dispatchToolStripMenuItem.Name = "dispatchToolStripMenuItem";
            this.dispatchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dispatchToolStripMenuItem.Text = "Dispatch";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnToolStripMenuItem.Text = "Return";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // SkyzerProductionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SkyzerProductionAdmin";
            this.Text = "Skyzer Production Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
    }
}