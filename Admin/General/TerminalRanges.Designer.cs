﻿namespace Skyzer_Production.Admin.General
{
    partial class TerminalRanges
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
            this.menuTabs = new System.Windows.Forms.TabControl();
            this.ranges = new System.Windows.Forms.TabPage();
            this.dataGridViewRanges = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonRangesAdd = new System.Windows.Forms.Button();
            this.textBoxRangeName = new System.Windows.Forms.TextBox();
            this.labelRangeName = new System.Windows.Forms.Label();
            this.terminals = new System.Windows.Forms.TabPage();
            this.pictureBoxTerminal = new System.Windows.Forms.PictureBox();
            this.buttonImageUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSeries = new System.Windows.Forms.DataGridView();
            this.Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditSerial = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteSerial = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonSeriesAdd = new System.Windows.Forms.Button();
            this.textBoxSeriesName = new System.Windows.Forms.TextBox();
            this.labelSeriesName = new System.Windows.Forms.Label();
            this.labelRange = new System.Windows.Forms.Label();
            this.comboBoxRange = new System.Windows.Forms.ComboBox();
            this.tabPageFAQs = new System.Windows.Forms.TabPage();
            this.dataGridViewFAQDepartment = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAddDepartment = new System.Windows.Forms.Button();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuTabs.SuspendLayout();
            this.ranges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanges)).BeginInit();
            this.terminals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeries)).BeginInit();
            this.tabPageFAQs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFAQDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTabs
            // 
            this.menuTabs.Controls.Add(this.ranges);
            this.menuTabs.Controls.Add(this.terminals);
            this.menuTabs.Controls.Add(this.tabPageFAQs);
            this.menuTabs.Location = new System.Drawing.Point(145, 68);
            this.menuTabs.Name = "menuTabs";
            this.menuTabs.SelectedIndex = 0;
            this.menuTabs.Size = new System.Drawing.Size(814, 460);
            this.menuTabs.TabIndex = 1;
            // 
            // ranges
            // 
            this.ranges.Controls.Add(this.dataGridViewRanges);
            this.ranges.Controls.Add(this.buttonRangesAdd);
            this.ranges.Controls.Add(this.textBoxRangeName);
            this.ranges.Controls.Add(this.labelRangeName);
            this.ranges.Location = new System.Drawing.Point(4, 22);
            this.ranges.Name = "ranges";
            this.ranges.Padding = new System.Windows.Forms.Padding(3);
            this.ranges.Size = new System.Drawing.Size(806, 434);
            this.ranges.TabIndex = 0;
            this.ranges.Text = "Ranges";
            this.ranges.UseVisualStyleBackColor = true;
            this.ranges.Click += new System.EventHandler(this.Ranges_Click);
            // 
            // dataGridViewRanges
            // 
            this.dataGridViewRanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Edit,
            this.Delete});
            this.dataGridViewRanges.Location = new System.Drawing.Point(231, 181);
            this.dataGridViewRanges.Name = "dataGridViewRanges";
            this.dataGridViewRanges.RowHeadersVisible = false;
            this.dataGridViewRanges.Size = new System.Drawing.Size(303, 160);
            this.dataGridViewRanges.TabIndex = 3;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Ranges";
            this.name.Name = "name";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // buttonRangesAdd
            // 
            this.buttonRangesAdd.Location = new System.Drawing.Point(569, 83);
            this.buttonRangesAdd.Name = "buttonRangesAdd";
            this.buttonRangesAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonRangesAdd.TabIndex = 2;
            this.buttonRangesAdd.Text = "+ Add";
            this.buttonRangesAdd.UseVisualStyleBackColor = true;
            this.buttonRangesAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxRangeName
            // 
            this.textBoxRangeName.Location = new System.Drawing.Point(222, 83);
            this.textBoxRangeName.Name = "textBoxRangeName";
            this.textBoxRangeName.Size = new System.Drawing.Size(312, 20);
            this.textBoxRangeName.TabIndex = 1;
            // 
            // labelRangeName
            // 
            this.labelRangeName.AutoSize = true;
            this.labelRangeName.Location = new System.Drawing.Point(175, 86);
            this.labelRangeName.Name = "labelRangeName";
            this.labelRangeName.Size = new System.Drawing.Size(41, 13);
            this.labelRangeName.TabIndex = 0;
            this.labelRangeName.Text = "Name: ";
            // 
            // terminals
            // 
            this.terminals.Controls.Add(this.pictureBoxTerminal);
            this.terminals.Controls.Add(this.buttonImageUpload);
            this.terminals.Controls.Add(this.label1);
            this.terminals.Controls.Add(this.dataGridViewSeries);
            this.terminals.Controls.Add(this.buttonSeriesAdd);
            this.terminals.Controls.Add(this.textBoxSeriesName);
            this.terminals.Controls.Add(this.labelSeriesName);
            this.terminals.Controls.Add(this.labelRange);
            this.terminals.Controls.Add(this.comboBoxRange);
            this.terminals.Location = new System.Drawing.Point(4, 22);
            this.terminals.Name = "terminals";
            this.terminals.Padding = new System.Windows.Forms.Padding(3);
            this.terminals.Size = new System.Drawing.Size(806, 434);
            this.terminals.TabIndex = 1;
            this.terminals.Text = "Terminals";
            this.terminals.UseVisualStyleBackColor = true;
            this.terminals.Click += new System.EventHandler(this.Terminals_Click);
            // 
            // pictureBoxTerminal
            // 
            this.pictureBoxTerminal.Location = new System.Drawing.Point(571, 36);
            this.pictureBoxTerminal.Name = "pictureBoxTerminal";
            this.pictureBoxTerminal.Size = new System.Drawing.Size(209, 379);
            this.pictureBoxTerminal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTerminal.TabIndex = 8;
            this.pictureBoxTerminal.TabStop = false;
            // 
            // buttonImageUpload
            // 
            this.buttonImageUpload.Location = new System.Drawing.Point(139, 115);
            this.buttonImageUpload.Name = "buttonImageUpload";
            this.buttonImageUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonImageUpload.TabIndex = 7;
            this.buttonImageUpload.Text = "Upload ...";
            this.buttonImageUpload.UseVisualStyleBackColor = true;
            this.buttonImageUpload.Click += new System.EventHandler(this.ButtonImageUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Image: ";
            // 
            // dataGridViewSeries
            // 
            this.dataGridViewSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Range,
            this.Serial,
            this.EditSerial,
            this.DeleteSerial});
            this.dataGridViewSeries.Location = new System.Drawing.Point(87, 246);
            this.dataGridViewSeries.Name = "dataGridViewSeries";
            this.dataGridViewSeries.Size = new System.Drawing.Size(454, 160);
            this.dataGridViewSeries.TabIndex = 5;
            // 
            // Range
            // 
            this.Range.DataPropertyName = "Range";
            this.Range.HeaderText = "Range";
            this.Range.Name = "Range";
            // 
            // Serial
            // 
            this.Serial.DataPropertyName = "Name";
            this.Serial.HeaderText = "Terminals";
            this.Serial.Name = "Serial";
            // 
            // EditSerial
            // 
            this.EditSerial.HeaderText = "Edit";
            this.EditSerial.Name = "EditSerial";
            this.EditSerial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditSerial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditSerial.Text = "Edit";
            this.EditSerial.UseColumnTextForButtonValue = true;
            // 
            // DeleteSerial
            // 
            this.DeleteSerial.HeaderText = "Delete";
            this.DeleteSerial.Name = "DeleteSerial";
            this.DeleteSerial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteSerial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteSerial.Text = "Delete";
            this.DeleteSerial.UseColumnTextForButtonValue = true;
            // 
            // buttonSeriesAdd
            // 
            this.buttonSeriesAdd.Location = new System.Drawing.Point(139, 198);
            this.buttonSeriesAdd.Name = "buttonSeriesAdd";
            this.buttonSeriesAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonSeriesAdd.TabIndex = 4;
            this.buttonSeriesAdd.Text = "+ Add";
            this.buttonSeriesAdd.UseVisualStyleBackColor = true;
            this.buttonSeriesAdd.Click += new System.EventHandler(this.ButtonSeriesAdd_Click);
            // 
            // textBoxSeriesName
            // 
            this.textBoxSeriesName.Location = new System.Drawing.Point(139, 73);
            this.textBoxSeriesName.Name = "textBoxSeriesName";
            this.textBoxSeriesName.Size = new System.Drawing.Size(312, 20);
            this.textBoxSeriesName.TabIndex = 3;
            // 
            // labelSeriesName
            // 
            this.labelSeriesName.AutoSize = true;
            this.labelSeriesName.Location = new System.Drawing.Point(85, 76);
            this.labelSeriesName.Name = "labelSeriesName";
            this.labelSeriesName.Size = new System.Drawing.Size(44, 13);
            this.labelSeriesName.TabIndex = 2;
            this.labelSeriesName.Text = "Name:  ";
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(84, 36);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(45, 13);
            this.labelRange.TabIndex = 1;
            this.labelRange.Text = "Range: ";
            // 
            // comboBoxRange
            // 
            this.comboBoxRange.FormattingEnabled = true;
            this.comboBoxRange.Location = new System.Drawing.Point(139, 33);
            this.comboBoxRange.Name = "comboBoxRange";
            this.comboBoxRange.Size = new System.Drawing.Size(312, 21);
            this.comboBoxRange.TabIndex = 0;
            this.comboBoxRange.DropDown += new System.EventHandler(this.ComboBoxRange_DropDown);
            // 
            // tabPageFAQs
            // 
            this.tabPageFAQs.Controls.Add(this.dataGridViewFAQDepartment);
            this.tabPageFAQs.Controls.Add(this.buttonAddDepartment);
            this.tabPageFAQs.Controls.Add(this.textBoxDepartmentName);
            this.tabPageFAQs.Controls.Add(this.label2);
            this.tabPageFAQs.Location = new System.Drawing.Point(4, 22);
            this.tabPageFAQs.Name = "tabPageFAQs";
            this.tabPageFAQs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFAQs.Size = new System.Drawing.Size(806, 434);
            this.tabPageFAQs.TabIndex = 2;
            this.tabPageFAQs.Text = "FAQs Department";
            this.tabPageFAQs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFAQDepartment
            // 
            this.dataGridViewFAQDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFAQDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dataGridViewFAQDepartment.Location = new System.Drawing.Point(194, 166);
            this.dataGridViewFAQDepartment.Name = "dataGridViewFAQDepartment";
            this.dataGridViewFAQDepartment.RowHeadersVisible = false;
            this.dataGridViewFAQDepartment.Size = new System.Drawing.Size(303, 160);
            this.dataGridViewFAQDepartment.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Department";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Edit";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Edit";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Delete";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Text = "Delete";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            // 
            // buttonAddDepartment
            // 
            this.buttonAddDepartment.Location = new System.Drawing.Point(541, 78);
            this.buttonAddDepartment.Name = "buttonAddDepartment";
            this.buttonAddDepartment.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDepartment.TabIndex = 5;
            this.buttonAddDepartment.Text = "+ Add";
            this.buttonAddDepartment.UseVisualStyleBackColor = true;
            this.buttonAddDepartment.Click += new System.EventHandler(this.ButtonAddDepartment_Click);
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Location = new System.Drawing.Point(194, 78);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(312, 20);
            this.textBoxDepartmentName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name: ";
            // 
            // TerminalRanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 586);
            this.Controls.Add(this.menuTabs);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "TerminalRanges";
            this.ShowIcon = false;
            this.Text = "Terminal Ranges";
            this.Load += new System.EventHandler(this.Ranges_Load);
            this.menuTabs.ResumeLayout(false);
            this.ranges.ResumeLayout(false);
            this.ranges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanges)).EndInit();
            this.terminals.ResumeLayout(false);
            this.terminals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeries)).EndInit();
            this.tabPageFAQs.ResumeLayout(false);
            this.tabPageFAQs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFAQDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuTabs;
        private System.Windows.Forms.TabPage ranges;
        private System.Windows.Forms.TabPage terminals;
        private System.Windows.Forms.DataGridView dataGridViewRanges;
        private System.Windows.Forms.Button buttonRangesAdd;
        private System.Windows.Forms.TextBox textBoxRangeName;
        private System.Windows.Forms.Label labelRangeName;
        private System.Windows.Forms.TextBox textBoxSeriesName;
        private System.Windows.Forms.Label labelSeriesName;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.ComboBox comboBoxRange;
        private System.Windows.Forms.DataGridView dataGridViewSeries;
        private System.Windows.Forms.Button buttonSeriesAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Range;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewButtonColumn EditSerial;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteSerial;
        private System.Windows.Forms.PictureBox pictureBoxTerminal;
        private System.Windows.Forms.Button buttonImageUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageFAQs;
        private System.Windows.Forms.DataGridView dataGridViewFAQDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.Button buttonAddDepartment;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Label label2;
    }
}