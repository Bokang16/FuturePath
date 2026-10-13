namespace FuturePath.UI
{
    partial class HomePage
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
            this.lblHomePage = new System.Windows.Forms.Label();
            this.btnCheckCourseEligibility = new System.Windows.Forms.Button();
            this.btnViewFundingOpportunities = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnTestimonials = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePage.Location = new System.Drawing.Point(23, 21);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(125, 30);
            this.lblHomePage.TabIndex = 1;
            this.lblHomePage.Text = "Home Page";
            // 
            // btnCheckCourseEligibility
            // 
            this.btnCheckCourseEligibility.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCourseEligibility.Location = new System.Drawing.Point(148, 101);
            this.btnCheckCourseEligibility.Name = "btnCheckCourseEligibility";
            this.btnCheckCourseEligibility.Size = new System.Drawing.Size(185, 70);
            this.btnCheckCourseEligibility.TabIndex = 2;
            this.btnCheckCourseEligibility.Text = "Check Course Eligibility";
            this.btnCheckCourseEligibility.UseVisualStyleBackColor = true;
            // 
            // btnViewFundingOpportunities
            // 
            this.btnViewFundingOpportunities.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFundingOpportunities.Location = new System.Drawing.Point(456, 101);
            this.btnViewFundingOpportunities.Name = "btnViewFundingOpportunities";
            this.btnViewFundingOpportunities.Size = new System.Drawing.Size(185, 70);
            this.btnViewFundingOpportunities.TabIndex = 3;
            this.btnViewFundingOpportunities.Text = "View Funding Opportunities";
            this.btnViewFundingOpportunities.UseVisualStyleBackColor = true;
            // 
            // btnViewReports
            // 
            this.btnViewReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReports.Location = new System.Drawing.Point(148, 265);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(185, 70);
            this.btnViewReports.TabIndex = 5;
            this.btnViewReports.Text = "View Past Reports";
            this.btnViewReports.UseVisualStyleBackColor = true;
            // 
            // btnTestimonials
            // 
            this.btnTestimonials.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestimonials.Location = new System.Drawing.Point(456, 265);
            this.btnTestimonials.Name = "btnTestimonials";
            this.btnTestimonials.Size = new System.Drawing.Size(185, 70);
            this.btnTestimonials.TabIndex = 6;
            this.btnTestimonials.Text = "View Testimonials";
            this.btnTestimonials.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::FuturePath.UI.Properties.Resources.image1;
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestimonials);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnViewFundingOpportunities);
            this.Controls.Add(this.btnCheckCourseEligibility);
            this.Controls.Add(this.lblHomePage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.Button btnCheckCourseEligibility;
        private System.Windows.Forms.Button btnViewFundingOpportunities;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnTestimonials;
    }
}