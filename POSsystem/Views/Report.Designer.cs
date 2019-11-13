namespace POSsystem.Views
{
    partial class Report
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
            this.cbmonthlyreport = new System.Windows.Forms.ComboBox();
            this.lbreportsummary = new System.Windows.Forms.Label();
            this.printmonthlyreport = new System.Windows.Forms.PictureBox();
            this.printdetailreport = new System.Windows.Forms.PictureBox();
            this.cbdetailReport = new System.Windows.Forms.ComboBox();
            this.lbdetailreport = new System.Windows.Forms.Label();
            this.lbyear = new System.Windows.Forms.Label();
            this.tbReportFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printmonthlyreport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printdetailreport)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmonthlyreport
            // 
            this.cbmonthlyreport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmonthlyreport.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmonthlyreport.FormattingEnabled = true;
            this.cbmonthlyreport.Location = new System.Drawing.Point(32, 141);
            this.cbmonthlyreport.Name = "cbmonthlyreport";
            this.cbmonthlyreport.Size = new System.Drawing.Size(265, 36);
            this.cbmonthlyreport.TabIndex = 27;
            // 
            // lbreportsummary
            // 
            this.lbreportsummary.AutoSize = true;
            this.lbreportsummary.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbreportsummary.Location = new System.Drawing.Point(28, 116);
            this.lbreportsummary.Name = "lbreportsummary";
            this.lbreportsummary.Size = new System.Drawing.Size(167, 25);
            this.lbreportsummary.TabIndex = 26;
            this.lbreportsummary.Text = "Laporan Bulanan";
            // 
            // printmonthlyreport
            // 
            this.printmonthlyreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printmonthlyreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printmonthlyreport.Image = global::POSsystem.Properties.Resources.printing;
            this.printmonthlyreport.Location = new System.Drawing.Point(326, 119);
            this.printmonthlyreport.Name = "printmonthlyreport";
            this.printmonthlyreport.Size = new System.Drawing.Size(97, 58);
            this.printmonthlyreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printmonthlyreport.TabIndex = 32;
            this.printmonthlyreport.TabStop = false;
            this.printmonthlyreport.Click += new System.EventHandler(this.printmonthlyreport_Click);
            // 
            // printdetailreport
            // 
            this.printdetailreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printdetailreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printdetailreport.Image = global::POSsystem.Properties.Resources.printing;
            this.printdetailreport.Location = new System.Drawing.Point(326, 209);
            this.printdetailreport.Name = "printdetailreport";
            this.printdetailreport.Size = new System.Drawing.Size(97, 58);
            this.printdetailreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printdetailreport.TabIndex = 35;
            this.printdetailreport.TabStop = false;
            this.printdetailreport.Click += new System.EventHandler(this.printdetailreport_Click);
            // 
            // cbdetailReport
            // 
            this.cbdetailReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdetailReport.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdetailReport.FormattingEnabled = true;
            this.cbdetailReport.Location = new System.Drawing.Point(32, 231);
            this.cbdetailReport.Name = "cbdetailReport";
            this.cbdetailReport.Size = new System.Drawing.Size(265, 36);
            this.cbdetailReport.TabIndex = 34;
            // 
            // lbdetailreport
            // 
            this.lbdetailreport.AutoSize = true;
            this.lbdetailreport.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdetailreport.Location = new System.Drawing.Point(28, 206);
            this.lbdetailreport.Name = "lbdetailreport";
            this.lbdetailreport.Size = new System.Drawing.Size(225, 25);
            this.lbdetailreport.TabIndex = 33;
            this.lbdetailreport.Text = "Detail Laporan Bulanan";
            // 
            // lbyear
            // 
            this.lbyear.AutoSize = true;
            this.lbyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbyear.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbyear.Location = new System.Drawing.Point(155, 58);
            this.lbyear.Name = "lbyear";
            this.lbyear.Size = new System.Drawing.Size(132, 24);
            this.lbyear.TabIndex = 36;
            this.lbyear.Text = "Tahun : 2019";
            // 
            // tbReportFolder
            // 
            this.tbReportFolder.BackColor = System.Drawing.SystemColors.Control;
            this.tbReportFolder.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReportFolder.Location = new System.Drawing.Point(33, 313);
            this.tbReportFolder.MaxLength = 16;
            this.tbReportFolder.Name = "tbReportFolder";
            this.tbReportFolder.ReadOnly = true;
            this.tbReportFolder.Size = new System.Drawing.Size(390, 31);
            this.tbReportFolder.TabIndex = 37;
            this.tbReportFolder.DoubleClick += new System.EventHandler(this.tbReportFolder_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(31, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 14);
            this.label1.TabIndex = 33;
            this.label1.Text = "Folder Laporan";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 356);
            this.Controls.Add(this.tbReportFolder);
            this.Controls.Add(this.lbyear);
            this.Controls.Add(this.printdetailreport);
            this.Controls.Add(this.cbdetailReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbdetailreport);
            this.Controls.Add(this.printmonthlyreport);
            this.Controls.Add(this.cbmonthlyreport);
            this.Controls.Add(this.lbreportsummary);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Report";
            this.Text = " ";
            this.Title = "Laporan Bulanan";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.Report_Load);
            this.Controls.SetChildIndex(this.lbreportsummary, 0);
            this.Controls.SetChildIndex(this.cbmonthlyreport, 0);
            this.Controls.SetChildIndex(this.printmonthlyreport, 0);
            this.Controls.SetChildIndex(this.lbdetailreport, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cbdetailReport, 0);
            this.Controls.SetChildIndex(this.printdetailreport, 0);
            this.Controls.SetChildIndex(this.lbyear, 0);
            this.Controls.SetChildIndex(this.tbReportFolder, 0);
            ((System.ComponentModel.ISupportInitialize)(this.printmonthlyreport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printdetailreport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmonthlyreport;
        private System.Windows.Forms.Label lbreportsummary;
        private System.Windows.Forms.PictureBox printmonthlyreport;
        private System.Windows.Forms.PictureBox printdetailreport;
        private System.Windows.Forms.ComboBox cbdetailReport;
        private System.Windows.Forms.Label lbdetailreport;
        private System.Windows.Forms.Label lbyear;
        private System.Windows.Forms.TextBox tbReportFolder;
        private System.Windows.Forms.Label label1;
    }
}