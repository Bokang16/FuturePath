namespace FuturePath.UI
{
    partial class PastReports
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
            this.panelDatePicker = new System.Windows.Forms.Panel();
            this.panelReport = new System.Windows.Forms.Panel();
            this.panelReportTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.referenceNO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelDatePicker.SuspendLayout();
            this.panelReportTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatePicker
            // 
            this.panelDatePicker.BackColor = System.Drawing.Color.White;
            this.panelDatePicker.Controls.Add(this.label2);
            this.panelDatePicker.Controls.Add(this.listView1);
            this.panelDatePicker.Location = new System.Drawing.Point(12, 59);
            this.panelDatePicker.Name = "panelDatePicker";
            this.panelDatePicker.Size = new System.Drawing.Size(375, 342);
            this.panelDatePicker.TabIndex = 0;
            // 
            // panelReport
            // 
            this.panelReport.Location = new System.Drawing.Point(436, 59);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(352, 342);
            this.panelReport.TabIndex = 1;
            // 
            // panelReportTop
            // 
            this.panelReportTop.BackColor = System.Drawing.Color.Navy;
            this.panelReportTop.Controls.Add(this.label3);
            this.panelReportTop.Controls.Add(this.label1);
            this.panelReportTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportTop.Location = new System.Drawing.Point(0, 0);
            this.panelReportTop.Name = "panelReportTop";
            this.panelReportTop.Size = new System.Drawing.Size(800, 53);
            this.panelReportTop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Past Advisory Reports";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.date,
            this.referenceNO});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(372, 314);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Generated Reports";
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 200;
            // 
            // referenceNO
            // 
            this.referenceNO.Text = "Reference No.";
            this.referenceNO.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(620, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Learner ID: ";
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 2;
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 70;
            // 
            // PastReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelReportTop);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelDatePicker);
            this.Name = "PastReports";
            this.Text = "PastReports";
            this.panelDatePicker.ResumeLayout(false);
            this.panelDatePicker.PerformLayout();
            this.panelReportTop.ResumeLayout(false);
            this.panelReportTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDatePicker;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panelReportTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader referenceNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}