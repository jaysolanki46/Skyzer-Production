namespace Skyzer_Production.Admin.General
{
    partial class FAQ
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
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(41, 38);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(228, 13);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Skyzer Production Frequently Asked Questions";
            // 
            // labelDivider
            // 
            this.labelDivider.Location = new System.Drawing.Point(41, 71);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(713, 13);
            this.labelDivider.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBoxDepartment);
            this.panel1.Controls.Add(this.labelDepartment);
            this.panel1.Controls.Add(this.textBoxQuestion);
            this.panel1.Controls.Add(this.labelFileName);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonFileUpload);
            this.panel1.Controls.Add(this.richTextBoxAnswer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelAnswer);
            this.panel1.Controls.Add(this.labelQuestion);
            this.panel1.Location = new System.Drawing.Point(44, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 406);
            this.panel1.TabIndex = 14;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(302, 271);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 13);
            this.labelFileName.TabIndex = 31;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(289, 327);
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
            this.buttonSave.Location = new System.Drawing.Point(84, 327);
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
            this.buttonFileUpload.Location = new System.Drawing.Point(84, 248);
            this.buttonFileUpload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFileUpload.Name = "buttonFileUpload";
            this.buttonFileUpload.Size = new System.Drawing.Size(200, 44);
            this.buttonFileUpload.TabIndex = 28;
            this.buttonFileUpload.Text = "Upload... (Optional)";
            this.buttonFileUpload.UseVisualStyleBackColor = true;
            this.buttonFileUpload.Click += new System.EventHandler(this.ButtonFileUpload_Click);
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.Location = new System.Drawing.Point(84, 88);
            this.richTextBoxAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.Size = new System.Drawing.Size(670, 156);
            this.richTextBoxAnswer.TabIndex = 24;
            this.richTextBoxAnswer.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "File: ";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(18, 91);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(48, 13);
            this.labelAnswer.TabIndex = 8;
            this.labelAnswer.Text = "Answer: ";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(14, 63);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(52, 13);
            this.labelQuestion.TabIndex = 6;
            this.labelQuestion.Text = "Question:";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(84, 63);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(670, 20);
            this.textBoxQuestion.TabIndex = 32;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(14, 30);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(68, 13);
            this.labelDepartment.TabIndex = 33;
            this.labelDepartment.Text = "Department: ";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(84, 30);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(260, 21);
            this.comboBoxDepartment.TabIndex = 34;
            this.comboBoxDepartment.DropDown += new System.EventHandler(this.ComboBoxDepartment_DropDown);
            // 
            // FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.labelHeader);
            this.Name = "FAQ";
            this.Text = "What\'s in your mind?";
            this.Load += new System.EventHandler(this.FAQ_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonFileUpload;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label labelDepartment;
    }
}