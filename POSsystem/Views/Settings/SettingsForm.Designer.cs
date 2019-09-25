namespace POSsystem.Views.Settings
{
    partial class SettingsForm
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
            this.tbConnectionString = new System.Windows.Forms.TextBox();
            this.lbbrandname = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReportFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseReportFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbConnectionString.Location = new System.Drawing.Point(13, 38);
            this.tbConnectionString.Margin = new System.Windows.Forms.Padding(4);
            this.tbConnectionString.Multiline = true;
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConnectionString.Size = new System.Drawing.Size(435, 64);
            this.tbConnectionString.TabIndex = 0;
            // 
            // lbbrandname
            // 
            this.lbbrandname.AutoSize = true;
            this.lbbrandname.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbrandname.Location = new System.Drawing.Point(13, 14);
            this.lbbrandname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbrandname.Name = "lbbrandname";
            this.lbbrandname.Size = new System.Drawing.Size(156, 17);
            this.lbbrandname.TabIndex = 17;
            this.lbbrandname.Text = "DB Connection String";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(265, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 49);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Report Folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbReportFolder
            // 
            this.tbReportFolder.Location = new System.Drawing.Point(13, 145);
            this.tbReportFolder.Margin = new System.Windows.Forms.Padding(4);
            this.tbReportFolder.Name = "tbReportFolder";
            this.tbReportFolder.ReadOnly = true;
            this.tbReportFolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReportFolder.Size = new System.Drawing.Size(358, 23);
            this.tbReportFolder.TabIndex = 0;
            // 
            // btnBrowseReportFolder
            // 
            this.btnBrowseReportFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseReportFolder.BackColor = System.Drawing.Color.Gray;
            this.btnBrowseReportFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseReportFolder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnBrowseReportFolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBrowseReportFolder.Location = new System.Drawing.Point(380, 141);
            this.btnBrowseReportFolder.Name = "btnBrowseReportFolder";
            this.btnBrowseReportFolder.Size = new System.Drawing.Size(68, 31);
            this.btnBrowseReportFolder.TabIndex = 1;
            this.btnBrowseReportFolder.Text = "Browse";
            this.btnBrowseReportFolder.UseVisualStyleBackColor = false;
            this.btnBrowseReportFolder.Click += new System.EventHandler(this.btnBrowseReportFolder_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 256);
            this.Controls.Add(this.tbReportFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbConnectionString);
            this.Controls.Add(this.lbbrandname);
            this.Controls.Add(this.btnBrowseReportFolder);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbConnectionString;
        private System.Windows.Forms.Label lbbrandname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReportFolder;
        private System.Windows.Forms.Button btnBrowseReportFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}