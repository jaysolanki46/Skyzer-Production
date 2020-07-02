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
            this.series = new System.Windows.Forms.TabPage();
            this.dataGridViewSeries = new System.Windows.Forms.DataGridView();
            this.buttonSeriesAdd = new System.Windows.Forms.Button();
            this.textBoxSeriesName = new System.Windows.Forms.TextBox();
            this.labelSeriesName = new System.Windows.Forms.Label();
            this.labelRange = new System.Windows.Forms.Label();
            this.comboBoxRange = new System.Windows.Forms.ComboBox();
            this.Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditSerial = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteSerial = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuTabs.SuspendLayout();
            this.ranges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanges)).BeginInit();
            this.series.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTabs
            // 
            this.menuTabs.Controls.Add(this.ranges);
            this.menuTabs.Controls.Add(this.series);
            this.menuTabs.Location = new System.Drawing.Point(145, 68);
            this.menuTabs.Name = "menuTabs";
            this.menuTabs.SelectedIndex = 0;
            this.menuTabs.Size = new System.Drawing.Size(607, 320);
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
            this.ranges.Size = new System.Drawing.Size(599, 294);
            this.ranges.TabIndex = 0;
            this.ranges.Text = "Ranges";
            this.ranges.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRanges
            // 
            this.dataGridViewRanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Edit,
            this.Delete});
            this.dataGridViewRanges.Location = new System.Drawing.Point(138, 128);
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
            this.buttonRangesAdd.Location = new System.Drawing.Point(476, 30);
            this.buttonRangesAdd.Name = "buttonRangesAdd";
            this.buttonRangesAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonRangesAdd.TabIndex = 2;
            this.buttonRangesAdd.Text = "+ Add";
            this.buttonRangesAdd.UseVisualStyleBackColor = true;
            this.buttonRangesAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxRangeName
            // 
            this.textBoxRangeName.Location = new System.Drawing.Point(129, 30);
            this.textBoxRangeName.Name = "textBoxRangeName";
            this.textBoxRangeName.Size = new System.Drawing.Size(312, 20);
            this.textBoxRangeName.TabIndex = 1;
            // 
            // labelRangeName
            // 
            this.labelRangeName.AutoSize = true;
            this.labelRangeName.Location = new System.Drawing.Point(82, 33);
            this.labelRangeName.Name = "labelRangeName";
            this.labelRangeName.Size = new System.Drawing.Size(41, 13);
            this.labelRangeName.TabIndex = 0;
            this.labelRangeName.Text = "Name: ";
            // 
            // series
            // 
            this.series.Controls.Add(this.dataGridViewSeries);
            this.series.Controls.Add(this.buttonSeriesAdd);
            this.series.Controls.Add(this.textBoxSeriesName);
            this.series.Controls.Add(this.labelSeriesName);
            this.series.Controls.Add(this.labelRange);
            this.series.Controls.Add(this.comboBoxRange);
            this.series.Location = new System.Drawing.Point(4, 22);
            this.series.Name = "series";
            this.series.Padding = new System.Windows.Forms.Padding(3);
            this.series.Size = new System.Drawing.Size(599, 294);
            this.series.TabIndex = 1;
            this.series.Text = "Series";
            this.series.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSeries
            // 
            this.dataGridViewSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Range,
            this.Serial,
            this.EditSerial,
            this.DeleteSerial});
            this.dataGridViewSeries.Location = new System.Drawing.Point(100, 128);
            this.dataGridViewSeries.Name = "dataGridViewSeries";
            this.dataGridViewSeries.Size = new System.Drawing.Size(442, 160);
            this.dataGridViewSeries.TabIndex = 5;
            // 
            // buttonSeriesAdd
            // 
            this.buttonSeriesAdd.Location = new System.Drawing.Point(467, 71);
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
            this.Serial.HeaderText = "Serial";
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
            // TerminalRanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.series.ResumeLayout(false);
            this.series.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuTabs;
        private System.Windows.Forms.TabPage ranges;
        private System.Windows.Forms.TabPage series;
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
    }
}