namespace Skyzer_Production.Admin.Production
{
    partial class PaperWork
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
            this.comboBoxTerminal = new System.Windows.Forms.ComboBox();
            this.labelRange = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
            this.comboBoxRange = new System.Windows.Forms.ComboBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxEndNote = new System.Windows.Forms.RichTextBox();
            this.labelEndNote = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonFileUpload = new System.Windows.Forms.Button();
            this.richTextBoxParts = new System.Windows.Forms.RichTextBox();
            this.richTextBoxHistory = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCall = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTaskTime = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInitNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTerminal = new System.Windows.Forms.PictureBox();
            this.labelParts = new System.Windows.Forms.Label();
            this.labelHistory = new System.Windows.Forms.Label();
            this.labelCall = new System.Windows.Forms.Label();
            this.labelTaskTime = new System.Windows.Forms.Label();
            this.labelinItNote = new System.Windows.Forms.Label();
            this.labelIfNitro = new System.Windows.Forms.Label();
            this.richTextBoxNitro = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTerminal
            // 
            this.comboBoxTerminal.FormattingEnabled = true;
            this.comboBoxTerminal.Items.AddRange(new object[] {
            "Select the range first.."});
            this.comboBoxTerminal.Location = new System.Drawing.Point(377, 92);
            this.comboBoxTerminal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTerminal.Name = "comboBoxTerminal";
            this.comboBoxTerminal.Size = new System.Drawing.Size(239, 24);
            this.comboBoxTerminal.TabIndex = 9;
            this.comboBoxTerminal.DropDown += new System.EventHandler(this.ComboBoxTerminal_DropDown);
            this.comboBoxTerminal.Leave += new System.EventHandler(this.ComboBoxTerminal_Leave);
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(23, 96);
            this.labelRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(58, 17);
            this.labelRange.TabIndex = 8;
            this.labelRange.Text = "Range: ";
            // 
            // labelDivider
            // 
            this.labelDivider.Location = new System.Drawing.Point(16, 59);
            this.labelDivider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(951, 16);
            this.labelDivider.TabIndex = 7;
            // 
            // comboBoxRange
            // 
            this.comboBoxRange.FormattingEnabled = true;
            this.comboBoxRange.Items.AddRange(new object[] {
            "Select the range..."});
            this.comboBoxRange.Location = new System.Drawing.Point(84, 92);
            this.comboBoxRange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxRange.Name = "comboBoxRange";
            this.comboBoxRange.Size = new System.Drawing.Size(239, 24);
            this.comboBoxRange.TabIndex = 5;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(16, 28);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(130, 17);
            this.labelHeader.TabIndex = 6;
            this.labelHeader.Text = "Skyzer Paper Work";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.richTextBoxNitro);
            this.panel1.Controls.Add(this.labelIfNitro);
            this.panel1.Controls.Add(this.richTextBoxEndNote);
            this.panel1.Controls.Add(this.labelEndNote);
            this.panel1.Controls.Add(this.labelFileName);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonFileUpload);
            this.panel1.Controls.Add(this.richTextBoxParts);
            this.panel1.Controls.Add(this.richTextBoxHistory);
            this.panel1.Controls.Add(this.richTextBoxCall);
            this.panel1.Controls.Add(this.richTextBoxTaskTime);
            this.panel1.Controls.Add(this.richTextBoxInitNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxTerminal);
            this.panel1.Controls.Add(this.labelParts);
            this.panel1.Controls.Add(this.labelHistory);
            this.panel1.Controls.Add(this.labelCall);
            this.panel1.Controls.Add(this.labelTaskTime);
            this.panel1.Controls.Add(this.labelinItNote);
            this.panel1.Location = new System.Drawing.Point(20, 140);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1624, 685);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // richTextBoxEndNote
            // 
            this.richTextBoxEndNote.Location = new System.Drawing.Point(112, 398);
            this.richTextBoxEndNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxEndNote.Name = "richTextBoxEndNote";
            this.richTextBoxEndNote.Size = new System.Drawing.Size(892, 66);
            this.richTextBoxEndNote.TabIndex = 33;
            this.richTextBoxEndNote.Text = "";
            // 
            // labelEndNote
            // 
            this.labelEndNote.AutoSize = true;
            this.labelEndNote.Location = new System.Drawing.Point(24, 400);
            this.labelEndNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndNote.Name = "labelEndNote";
            this.labelEndNote.Size = new System.Drawing.Size(71, 17);
            this.labelEndNote.TabIndex = 32;
            this.labelEndNote.Text = "End Note:";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(387, 505);
            this.labelFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 17);
            this.labelFileName.TabIndex = 31;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(385, 609);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(267, 54);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(112, 609);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(267, 54);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonFileUpload
            // 
            this.buttonFileUpload.Location = new System.Drawing.Point(112, 468);
            this.buttonFileUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFileUpload.Name = "buttonFileUpload";
            this.buttonFileUpload.Size = new System.Drawing.Size(267, 54);
            this.buttonFileUpload.TabIndex = 28;
            this.buttonFileUpload.Text = "Upload... (Optional)";
            this.buttonFileUpload.UseVisualStyleBackColor = true;
            this.buttonFileUpload.Click += new System.EventHandler(this.ButtonFileUpload_Click);
            // 
            // richTextBoxParts
            // 
            this.richTextBoxParts.Location = new System.Drawing.Point(570, 258);
            this.richTextBoxParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxParts.Name = "richTextBoxParts";
            this.richTextBoxParts.Size = new System.Drawing.Size(434, 66);
            this.richTextBoxParts.TabIndex = 27;
            this.richTextBoxParts.Text = "";
            // 
            // richTextBoxHistory
            // 
            this.richTextBoxHistory.Location = new System.Drawing.Point(112, 258);
            this.richTextBoxHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxHistory.Name = "richTextBoxHistory";
            this.richTextBoxHistory.Size = new System.Drawing.Size(362, 66);
            this.richTextBoxHistory.TabIndex = 26;
            this.richTextBoxHistory.Text = "";
            // 
            // richTextBoxCall
            // 
            this.richTextBoxCall.Location = new System.Drawing.Point(570, 188);
            this.richTextBoxCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxCall.Name = "richTextBoxCall";
            this.richTextBoxCall.Size = new System.Drawing.Size(434, 66);
            this.richTextBoxCall.TabIndex = 25;
            this.richTextBoxCall.Text = "";
            // 
            // richTextBoxTaskTime
            // 
            this.richTextBoxTaskTime.Location = new System.Drawing.Point(112, 188);
            this.richTextBoxTaskTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxTaskTime.Name = "richTextBoxTaskTime";
            this.richTextBoxTaskTime.Size = new System.Drawing.Size(362, 66);
            this.richTextBoxTaskTime.TabIndex = 24;
            this.richTextBoxTaskTime.Text = "";
            // 
            // richTextBoxInitNote
            // 
            this.richTextBoxInitNote.Location = new System.Drawing.Point(112, 60);
            this.richTextBoxInitNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxInitNote.Name = "richTextBoxInitNote";
            this.richTextBoxInitNote.Size = new System.Drawing.Size(892, 96);
            this.richTextBoxInitNote.TabIndex = 23;
            this.richTextBoxInitNote.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 488);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "File: ";
            // 
            // pictureBoxTerminal
            // 
            this.pictureBoxTerminal.Enabled = false;
            this.pictureBoxTerminal.Location = new System.Drawing.Point(1064, 37);
            this.pictureBoxTerminal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxTerminal.Name = "pictureBoxTerminal";
            this.pictureBoxTerminal.Size = new System.Drawing.Size(517, 597);
            this.pictureBoxTerminal.TabIndex = 20;
            this.pictureBoxTerminal.TabStop = false;
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Location = new System.Drawing.Point(514, 261);
            this.labelParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(49, 17);
            this.labelParts.TabIndex = 16;
            this.labelParts.Text = "Parts: ";
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Location = new System.Drawing.Point(24, 261);
            this.labelHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(60, 17);
            this.labelHistory.TabIndex = 10;
            this.labelHistory.Text = "History: ";
            // 
            // labelCall
            // 
            this.labelCall.AutoSize = true;
            this.labelCall.Location = new System.Drawing.Point(528, 191);
            this.labelCall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCall.Name = "labelCall";
            this.labelCall.Size = new System.Drawing.Size(35, 17);
            this.labelCall.TabIndex = 9;
            this.labelCall.Text = "Call:";
            // 
            // labelTaskTime
            // 
            this.labelTaskTime.AutoSize = true;
            this.labelTaskTime.Location = new System.Drawing.Point(24, 191);
            this.labelTaskTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskTime.Name = "labelTaskTime";
            this.labelTaskTime.Size = new System.Drawing.Size(82, 17);
            this.labelTaskTime.TabIndex = 8;
            this.labelTaskTime.Text = "Task Time: ";
            // 
            // labelinItNote
            // 
            this.labelinItNote.AutoSize = true;
            this.labelinItNote.Location = new System.Drawing.Point(24, 63);
            this.labelinItNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelinItNote.Name = "labelinItNote";
            this.labelinItNote.Size = new System.Drawing.Size(82, 17);
            this.labelinItNote.TabIndex = 6;
            this.labelinItNote.Text = "Initial Note: ";
            // 
            // labelIfNitro
            // 
            this.labelIfNitro.AutoSize = true;
            this.labelIfNitro.Location = new System.Drawing.Point(24, 331);
            this.labelIfNitro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIfNitro.Name = "labelIfNitro";
            this.labelIfNitro.Size = new System.Drawing.Size(42, 17);
            this.labelIfNitro.TabIndex = 34;
            this.labelIfNitro.Text = "Nitro:";
            // 
            // richTextBoxNitro
            // 
            this.richTextBoxNitro.Location = new System.Drawing.Point(112, 328);
            this.richTextBoxNitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxNitro.Name = "richTextBoxNitro";
            this.richTextBoxNitro.Size = new System.Drawing.Size(892, 66);
            this.richTextBoxNitro.TabIndex = 35;
            this.richTextBoxNitro.Text = "";
            // 
            // PaperWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 878);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxTerminal);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.comboBoxRange);
            this.Controls.Add(this.labelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PaperWork";
            this.Text = "How to do paper work?";
            this.Load += new System.EventHandler(this.PaperWork_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTerminal;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.ComboBox comboBoxRange;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonFileUpload;
        private System.Windows.Forms.RichTextBox richTextBoxParts;
        private System.Windows.Forms.RichTextBox richTextBoxHistory;
        private System.Windows.Forms.RichTextBox richTextBoxCall;
        private System.Windows.Forms.RichTextBox richTextBoxTaskTime;
        private System.Windows.Forms.RichTextBox richTextBoxInitNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxTerminal;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Label labelCall;
        private System.Windows.Forms.Label labelTaskTime;
        private System.Windows.Forms.Label labelinItNote;
        private System.Windows.Forms.RichTextBox richTextBoxEndNote;
        private System.Windows.Forms.Label labelEndNote;
        private System.Windows.Forms.RichTextBox richTextBoxNitro;
        private System.Windows.Forms.Label labelIfNitro;
    }
}