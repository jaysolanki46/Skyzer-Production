﻿namespace Skyzer_Production.Admin.Production
{
    partial class Testing
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
            this.labelDivider = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.comboBoxTerminal = new System.Windows.Forms.ComboBox();
            this.labelRange = new System.Windows.Forms.Label();
            this.comboBoxRange = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxManualTest = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoTest = new System.Windows.Forms.CheckBox();
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
            // labelDivider
            // 
            this.labelDivider.Location = new System.Drawing.Point(35, 63);
            this.labelDivider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(951, 16);
            this.labelDivider.TabIndex = 3;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(35, 32);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(102, 17);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Skyzer Testing";
            // 
            // comboBoxTerminal
            // 
            this.comboBoxTerminal.FormattingEnabled = true;
            this.comboBoxTerminal.Items.AddRange(new object[] {
            "Select the range first.."});
            this.comboBoxTerminal.Location = new System.Drawing.Point(391, 82);
            this.comboBoxTerminal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTerminal.Name = "comboBoxTerminal";
            this.comboBoxTerminal.Size = new System.Drawing.Size(239, 24);
            this.comboBoxTerminal.TabIndex = 7;
            this.comboBoxTerminal.DropDown += new System.EventHandler(this.ComboBoxTerminal_DropDown);
            this.comboBoxTerminal.Leave += new System.EventHandler(this.ComboBoxTerminal_Leave);
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(36, 86);
            this.labelRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(58, 17);
            this.labelRange.TabIndex = 6;
            this.labelRange.Text = "Range: ";
            // 
            // comboBoxRange
            // 
            this.comboBoxRange.FormattingEnabled = true;
            this.comboBoxRange.Items.AddRange(new object[] {
            "Select the range..."});
            this.comboBoxRange.Location = new System.Drawing.Point(97, 82);
            this.comboBoxRange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxRange.Name = "comboBoxRange";
            this.comboBoxRange.Size = new System.Drawing.Size(239, 24);
            this.comboBoxRange.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkBoxManualTest);
            this.panel1.Controls.Add(this.checkBoxAutoTest);
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
            this.panel1.Location = new System.Drawing.Point(39, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1624, 685);
            this.panel1.TabIndex = 8;
            // 
            // checkBoxManualTest
            // 
            this.checkBoxManualTest.AutoSize = true;
            this.checkBoxManualTest.Checked = true;
            this.checkBoxManualTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxManualTest.Location = new System.Drawing.Point(265, 78);
            this.checkBoxManualTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxManualTest.Name = "checkBoxManualTest";
            this.checkBoxManualTest.Size = new System.Drawing.Size(108, 21);
            this.checkBoxManualTest.TabIndex = 34;
            this.checkBoxManualTest.Text = "Manual Test";
            this.checkBoxManualTest.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoTest
            // 
            this.checkBoxAutoTest.AutoSize = true;
            this.checkBoxAutoTest.Location = new System.Drawing.Point(112, 78);
            this.checkBoxAutoTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxAutoTest.Name = "checkBoxAutoTest";
            this.checkBoxAutoTest.Size = new System.Drawing.Size(91, 21);
            this.checkBoxAutoTest.TabIndex = 33;
            this.checkBoxAutoTest.Text = "Auto Test";
            this.checkBoxAutoTest.UseVisualStyleBackColor = true;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(385, 513);
            this.labelFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 17);
            this.labelFileName.TabIndex = 31;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(385, 607);
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
            this.buttonSave.Location = new System.Drawing.Point(112, 607);
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
            this.buttonFileUpload.Location = new System.Drawing.Point(112, 494);
            this.buttonFileUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFileUpload.Name = "buttonFileUpload";
            this.buttonFileUpload.Size = new System.Drawing.Size(267, 54);
            this.buttonFileUpload.TabIndex = 28;
            this.buttonFileUpload.Text = "Upload... (Optional)";
            this.buttonFileUpload.UseVisualStyleBackColor = true;
            this.buttonFileUpload.Click += new System.EventHandler(this.ButtonFileUpload_Click);
            // 
            // richTextBoxEndNote
            // 
            this.richTextBoxEndNote.Location = new System.Drawing.Point(112, 422);
            this.richTextBoxEndNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxEndNote.Name = "richTextBoxEndNote";
            this.richTextBoxEndNote.Size = new System.Drawing.Size(892, 66);
            this.richTextBoxEndNote.TabIndex = 27;
            this.richTextBoxEndNote.Text = "";
            // 
            // richTextBoxPerforme
            // 
            this.richTextBoxPerforme.Location = new System.Drawing.Point(112, 225);
            this.richTextBoxPerforme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxPerforme.Name = "richTextBoxPerforme";
            this.richTextBoxPerforme.Size = new System.Drawing.Size(892, 191);
            this.richTextBoxPerforme.TabIndex = 24;
            this.richTextBoxPerforme.Text = "";
            // 
            // richTextBoxInitNote
            // 
            this.richTextBoxInitNote.Location = new System.Drawing.Point(112, 123);
            this.richTextBoxInitNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxInitNote.Name = "richTextBoxInitNote";
            this.richTextBoxInitNote.Size = new System.Drawing.Size(892, 96);
            this.richTextBoxInitNote.TabIndex = 23;
            this.richTextBoxInitNote.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 513);
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
            // labelEndNote
            // 
            this.labelEndNote.AutoSize = true;
            this.labelEndNote.Location = new System.Drawing.Point(25, 426);
            this.labelEndNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndNote.Name = "labelEndNote";
            this.labelEndNote.Size = new System.Drawing.Size(75, 17);
            this.labelEndNote.TabIndex = 16;
            this.labelEndNote.Text = "End Note: ";
            // 
            // labelPerforme
            // 
            this.labelPerforme.AutoSize = true;
            this.labelPerforme.Location = new System.Drawing.Point(24, 229);
            this.labelPerforme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPerforme.Name = "labelPerforme";
            this.labelPerforme.Size = new System.Drawing.Size(70, 17);
            this.labelPerforme.TabIndex = 8;
            this.labelPerforme.Text = "Performe:";
            // 
            // labelinItNote
            // 
            this.labelinItNote.AutoSize = true;
            this.labelinItNote.Location = new System.Drawing.Point(24, 126);
            this.labelinItNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelinItNote.Name = "labelinItNote";
            this.labelinItNote.Size = new System.Drawing.Size(82, 17);
            this.labelinItNote.TabIndex = 6;
            this.labelinItNote.Text = "Initial Note: ";
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 906);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxTerminal);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.comboBoxRange);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.labelHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Testing";
            this.Text = " How to do testing?";
            this.Load += new System.EventHandler(this.Testing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ComboBox comboBoxTerminal;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.ComboBox comboBoxRange;
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
        private System.Windows.Forms.CheckBox checkBoxManualTest;
        private System.Windows.Forms.CheckBox checkBoxAutoTest;
    }
}