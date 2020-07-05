namespace Skyzer_Production.Admin.Production
{
    partial class LogOnTesting
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
            this.comboBoxRange = new System.Windows.Forms.ComboBox();
            this.labelDivider = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonFileUpload = new System.Windows.Forms.Button();
            this.richTextBoxEndNote = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPerforme = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInitNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTerminal = new System.Windows.Forms.PictureBox();
            this.labelEndNote = new System.Windows.Forms.Label();
            this.labelPerforme = new System.Windows.Forms.Label();
            this.labelinItNote = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTerminal
            // 
            this.comboBoxTerminal.FormattingEnabled = true;
            this.comboBoxTerminal.Items.AddRange(new object[] {
            "Select the range first.."});
            this.comboBoxTerminal.Location = new System.Drawing.Point(292, 64);
            this.comboBoxTerminal.Name = "comboBoxTerminal";
            this.comboBoxTerminal.Size = new System.Drawing.Size(180, 21);
            this.comboBoxTerminal.TabIndex = 12;
            this.comboBoxTerminal.DropDown += new System.EventHandler(this.ComboBoxTerminal_DropDown);
            this.comboBoxTerminal.Leave += new System.EventHandler(this.ComboBoxTerminal_Leave);
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(26, 67);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(45, 13);
            this.labelRange.TabIndex = 11;
            this.labelRange.Text = "Range: ";
            // 
            // comboBoxRange
            // 
            this.comboBoxRange.FormattingEnabled = true;
            this.comboBoxRange.Items.AddRange(new object[] {
            "Select the range..."});
            this.comboBoxRange.Location = new System.Drawing.Point(72, 64);
            this.comboBoxRange.Name = "comboBoxRange";
            this.comboBoxRange.Size = new System.Drawing.Size(180, 21);
            this.comboBoxRange.TabIndex = 10;
            // 
            // labelDivider
            // 
            this.labelDivider.Location = new System.Drawing.Point(25, 48);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(713, 13);
            this.labelDivider.TabIndex = 9;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(25, 23);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(101, 13);
            this.labelHeader.TabIndex = 8;
            this.labelHeader.Text = "Skyzer Log On Test";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelFileName);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonFileUpload);
            this.panel1.Controls.Add(this.richTextBoxEndNote);
            this.panel1.Controls.Add(this.richTextBoxPerforme);
            this.panel1.Controls.Add(this.richTextBoxInitNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxTerminal);
            this.panel1.Controls.Add(this.labelEndNote);
            this.panel1.Controls.Add(this.labelPerforme);
            this.panel1.Controls.Add(this.labelinItNote);
            this.panel1.Location = new System.Drawing.Point(28, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 557);
            this.panel1.TabIndex = 13;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(289, 417);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 13);
            this.labelFileName.TabIndex = 31;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(289, 493);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 44);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(84, 493);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 44);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonFileUpload
            // 
            this.buttonFileUpload.Location = new System.Drawing.Point(84, 401);
            this.buttonFileUpload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFileUpload.Name = "buttonFileUpload";
            this.buttonFileUpload.Size = new System.Drawing.Size(200, 44);
            this.buttonFileUpload.TabIndex = 28;
            this.buttonFileUpload.Text = "Upload... (Optional)";
            this.buttonFileUpload.UseVisualStyleBackColor = true;
            this.buttonFileUpload.Click += new System.EventHandler(this.ButtonFileUpload_Click);
            // 
            // richTextBoxEndNote
            // 
            this.richTextBoxEndNote.Location = new System.Drawing.Point(84, 343);
            this.richTextBoxEndNote.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxEndNote.Name = "richTextBoxEndNote";
            this.richTextBoxEndNote.Size = new System.Drawing.Size(670, 54);
            this.richTextBoxEndNote.TabIndex = 27;
            this.richTextBoxEndNote.Text = "";
            // 
            // richTextBoxPerforme
            // 
            this.richTextBoxPerforme.Location = new System.Drawing.Point(84, 183);
            this.richTextBoxPerforme.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxPerforme.Name = "richTextBoxPerforme";
            this.richTextBoxPerforme.Size = new System.Drawing.Size(670, 156);
            this.richTextBoxPerforme.TabIndex = 24;
            this.richTextBoxPerforme.Text = "";
            // 
            // richTextBoxInitNote
            // 
            this.richTextBoxInitNote.Location = new System.Drawing.Point(84, 100);
            this.richTextBoxInitNote.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxInitNote.Name = "richTextBoxInitNote";
            this.richTextBoxInitNote.Size = new System.Drawing.Size(670, 79);
            this.richTextBoxInitNote.TabIndex = 23;
            this.richTextBoxInitNote.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "File: ";
            // 
            // pictureBoxTerminal
            // 
            this.pictureBoxTerminal.Enabled = false;
            this.pictureBoxTerminal.Location = new System.Drawing.Point(798, 30);
            this.pictureBoxTerminal.Name = "pictureBoxTerminal";
            this.pictureBoxTerminal.Size = new System.Drawing.Size(388, 485);
            this.pictureBoxTerminal.TabIndex = 20;
            this.pictureBoxTerminal.TabStop = false;
            // 
            // labelEndNote
            // 
            this.labelEndNote.AutoSize = true;
            this.labelEndNote.Location = new System.Drawing.Point(19, 346);
            this.labelEndNote.Name = "labelEndNote";
            this.labelEndNote.Size = new System.Drawing.Size(58, 13);
            this.labelEndNote.TabIndex = 16;
            this.labelEndNote.Text = "End Note: ";
            // 
            // labelPerforme
            // 
            this.labelPerforme.AutoSize = true;
            this.labelPerforme.Location = new System.Drawing.Point(18, 186);
            this.labelPerforme.Name = "labelPerforme";
            this.labelPerforme.Size = new System.Drawing.Size(52, 13);
            this.labelPerforme.TabIndex = 8;
            this.labelPerforme.Text = "Performe:";
            // 
            // labelinItNote
            // 
            this.labelinItNote.AutoSize = true;
            this.labelinItNote.Location = new System.Drawing.Point(18, 102);
            this.labelinItNote.Name = "labelinItNote";
            this.labelinItNote.Size = new System.Drawing.Size(63, 13);
            this.labelinItNote.TabIndex = 6;
            this.labelinItNote.Text = "Initial Note: ";
            // 
            // LogOnTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxTerminal);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.comboBoxRange);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.labelHeader);
            this.Name = "LogOnTesting";
            this.Text = "How to do log on test?";
            this.Load += new System.EventHandler(this.LogOnTesting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTerminal;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.ComboBox comboBoxRange;
        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonFileUpload;
        private System.Windows.Forms.RichTextBox richTextBoxEndNote;
        private System.Windows.Forms.RichTextBox richTextBoxPerforme;
        private System.Windows.Forms.RichTextBox richTextBoxInitNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxTerminal;
        private System.Windows.Forms.Label labelEndNote;
        private System.Windows.Forms.Label labelPerforme;
        private System.Windows.Forms.Label labelinItNote;
    }
}