namespace Skyzer_Production.Admin.Production
{
    partial class ReActivate
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonFileUpload = new System.Windows.Forms.Button();
            this.richTextBoxEndNote = new System.Windows.Forms.RichTextBox();
            this.richTextBoxStage3 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxStage2 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxStage1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInitNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxTerminal = new System.Windows.Forms.PictureBox();
            this.labelEndNote = new System.Windows.Forms.Label();
            this.labelStage3 = new System.Windows.Forms.Label();
            this.labelStage2 = new System.Windows.Forms.Label();
            this.labelStage1 = new System.Windows.Forms.Label();
            this.labelinItNote = new System.Windows.Forms.Label();
            this.comboBoxRange = new System.Windows.Forms.ComboBox();
            this.labelRange = new System.Windows.Forms.Label();
            this.comboBoxTerminal = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(32, 26);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(105, 13);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Skyzer Re-activation";
            // 
            // labelDivider
            // 
            this.labelDivider.Location = new System.Drawing.Point(32, 51);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(713, 13);
            this.labelDivider.TabIndex = 1;
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
            this.panel1.Controls.Add(this.richTextBoxStage3);
            this.panel1.Controls.Add(this.richTextBoxStage2);
            this.panel1.Controls.Add(this.richTextBoxStage1);
            this.panel1.Controls.Add(this.richTextBoxInitNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxTerminal);
            this.panel1.Controls.Add(this.labelEndNote);
            this.panel1.Controls.Add(this.labelStage3);
            this.panel1.Controls.Add(this.labelStage2);
            this.panel1.Controls.Add(this.labelStage1);
            this.panel1.Controls.Add(this.labelinItNote);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 557);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(290, 422);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 13);
            this.labelFileName.TabIndex = 31;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(289, 493);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 44);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonFileUpload
            // 
            this.buttonFileUpload.Location = new System.Drawing.Point(84, 392);
            this.buttonFileUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFileUpload.Name = "buttonFileUpload";
            this.buttonFileUpload.Size = new System.Drawing.Size(200, 44);
            this.buttonFileUpload.TabIndex = 28;
            this.buttonFileUpload.Text = "Upload... (Optional)";
            this.buttonFileUpload.UseVisualStyleBackColor = true;
            this.buttonFileUpload.Click += new System.EventHandler(this.ButtonFileUpload_Click);
            // 
            // richTextBoxEndNote
            // 
            this.richTextBoxEndNote.Location = new System.Drawing.Point(84, 331);
            this.richTextBoxEndNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxEndNote.Name = "richTextBoxEndNote";
            this.richTextBoxEndNote.Size = new System.Drawing.Size(670, 54);
            this.richTextBoxEndNote.TabIndex = 27;
            this.richTextBoxEndNote.Text = "";
            // 
            // richTextBoxStage3
            // 
            this.richTextBoxStage3.Location = new System.Drawing.Point(84, 269);
            this.richTextBoxStage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxStage3.Name = "richTextBoxStage3";
            this.richTextBoxStage3.Size = new System.Drawing.Size(670, 54);
            this.richTextBoxStage3.TabIndex = 26;
            this.richTextBoxStage3.Text = "";
            // 
            // richTextBoxStage2
            // 
            this.richTextBoxStage2.Location = new System.Drawing.Point(84, 210);
            this.richTextBoxStage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxStage2.Name = "richTextBoxStage2";
            this.richTextBoxStage2.Size = new System.Drawing.Size(670, 54);
            this.richTextBoxStage2.TabIndex = 25;
            this.richTextBoxStage2.Text = "";
            // 
            // richTextBoxStage1
            // 
            this.richTextBoxStage1.Location = new System.Drawing.Point(84, 153);
            this.richTextBoxStage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxStage1.Name = "richTextBoxStage1";
            this.richTextBoxStage1.Size = new System.Drawing.Size(670, 54);
            this.richTextBoxStage1.TabIndex = 24;
            this.richTextBoxStage1.Text = "";
            // 
            // richTextBoxInitNote
            // 
            this.richTextBoxInitNote.Location = new System.Drawing.Point(84, 49);
            this.richTextBoxInitNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxInitNote.Name = "richTextBoxInitNote";
            this.richTextBoxInitNote.Size = new System.Drawing.Size(670, 79);
            this.richTextBoxInitNote.TabIndex = 23;
            this.richTextBoxInitNote.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 407);
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
            this.labelEndNote.Location = new System.Drawing.Point(18, 333);
            this.labelEndNote.Name = "labelEndNote";
            this.labelEndNote.Size = new System.Drawing.Size(58, 13);
            this.labelEndNote.TabIndex = 16;
            this.labelEndNote.Text = "End Note: ";
            // 
            // labelStage3
            // 
            this.labelStage3.AutoSize = true;
            this.labelStage3.Location = new System.Drawing.Point(18, 271);
            this.labelStage3.Name = "labelStage3";
            this.labelStage3.Size = new System.Drawing.Size(50, 13);
            this.labelStage3.TabIndex = 10;
            this.labelStage3.Text = "Stage 3: ";
            // 
            // labelStage2
            // 
            this.labelStage2.AutoSize = true;
            this.labelStage2.Location = new System.Drawing.Point(18, 213);
            this.labelStage2.Name = "labelStage2";
            this.labelStage2.Size = new System.Drawing.Size(50, 13);
            this.labelStage2.TabIndex = 9;
            this.labelStage2.Text = "Stage 2: ";
            // 
            // labelStage1
            // 
            this.labelStage1.AutoSize = true;
            this.labelStage1.Location = new System.Drawing.Point(18, 155);
            this.labelStage1.Name = "labelStage1";
            this.labelStage1.Size = new System.Drawing.Size(50, 13);
            this.labelStage1.TabIndex = 8;
            this.labelStage1.Text = "Stage 1: ";
            // 
            // labelinItNote
            // 
            this.labelinItNote.AutoSize = true;
            this.labelinItNote.Location = new System.Drawing.Point(18, 51);
            this.labelinItNote.Name = "labelinItNote";
            this.labelinItNote.Size = new System.Drawing.Size(63, 13);
            this.labelinItNote.TabIndex = 6;
            this.labelinItNote.Text = "Initial Note: ";
            // 
            // comboBoxRange
            // 
            this.comboBoxRange.FormattingEnabled = true;
            this.comboBoxRange.Items.AddRange(new object[] {
            "Select the range..."});
            this.comboBoxRange.Location = new System.Drawing.Point(83, 78);
            this.comboBoxRange.Name = "comboBoxRange";
            this.comboBoxRange.Size = new System.Drawing.Size(180, 21);
            this.comboBoxRange.TabIndex = 0;
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(37, 81);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(45, 13);
            this.labelRange.TabIndex = 3;
            this.labelRange.Text = "Range: ";
            // 
            // comboBoxTerminal
            // 
            this.comboBoxTerminal.FormattingEnabled = true;
            this.comboBoxTerminal.Items.AddRange(new object[] {
            "Select the range first.."});
            this.comboBoxTerminal.Location = new System.Drawing.Point(303, 78);
            this.comboBoxTerminal.Name = "comboBoxTerminal";
            this.comboBoxTerminal.Size = new System.Drawing.Size(180, 21);
            this.comboBoxTerminal.TabIndex = 4;
            this.comboBoxTerminal.DropDown += new System.EventHandler(this.ComboBoxTerminal_DropDown);
            this.comboBoxTerminal.Leave += new System.EventHandler(this.ComboBoxTerminal_Leave);
            // 
            // ReActivate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.comboBoxTerminal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.comboBoxRange);
            this.Controls.Add(this.labelHeader);
            this.Name = "ReActivate";
            this.Text = "How to do re-activation?";
            this.Load += new System.EventHandler(this.ReActivate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.ComboBox comboBoxRange;
        private System.Windows.Forms.Label labelinItNote;
        private System.Windows.Forms.Label labelEndNote;
        private System.Windows.Forms.Label labelStage3;
        private System.Windows.Forms.Label labelStage2;
        private System.Windows.Forms.Label labelStage1;
        private System.Windows.Forms.PictureBox pictureBoxTerminal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonFileUpload;
        private System.Windows.Forms.RichTextBox richTextBoxEndNote;
        private System.Windows.Forms.RichTextBox richTextBoxStage3;
        private System.Windows.Forms.RichTextBox richTextBoxStage2;
        private System.Windows.Forms.RichTextBox richTextBoxStage1;
        private System.Windows.Forms.RichTextBox richTextBoxInitNote;
        private System.Windows.Forms.ComboBox comboBoxTerminal;
        private System.Windows.Forms.Label labelFileName;
    }
}