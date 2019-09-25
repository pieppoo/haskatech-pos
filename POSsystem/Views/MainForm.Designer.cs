namespace POSsystem.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnproduct = new System.Windows.Forms.Button();
            this.btnhistory = new System.Windows.Forms.Button();
            this.pbposicon = new System.Windows.Forms.PictureBox();
            this.btreport = new System.Windows.Forms.Button();
            this.changepswd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbposicon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.Color.Teal;
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnproduct.Location = new System.Drawing.Point(247, 152);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(207, 54);
            this.btnproduct.TabIndex = 12;
            this.btnproduct.Text = "Manajemen Produk (F4)";
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btnhistory
            // 
            this.btnhistory.BackColor = System.Drawing.Color.Teal;
            this.btnhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnhistory.Location = new System.Drawing.Point(247, 28);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(207, 54);
            this.btnhistory.TabIndex = 14;
            this.btnhistory.Text = "Riwayat Penjualan (F1)";
            this.btnhistory.UseVisualStyleBackColor = false;
            this.btnhistory.Click += new System.EventHandler(this.btnhistory_Click);
            // 
            // pbposicon
            // 
            this.pbposicon.ErrorImage = null;
            this.pbposicon.Image = global::POSsystem.Properties.Resources.trolley;
            this.pbposicon.Location = new System.Drawing.Point(24, 28);
            this.pbposicon.Name = "pbposicon";
            this.pbposicon.Size = new System.Drawing.Size(207, 119);
            this.pbposicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbposicon.TabIndex = 15;
            this.pbposicon.TabStop = false;
            // 
            // btreport
            // 
            this.btreport.BackColor = System.Drawing.Color.Teal;
            this.btreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btreport.Location = new System.Drawing.Point(24, 153);
            this.btreport.Name = "btreport";
            this.btreport.Size = new System.Drawing.Size(207, 54);
            this.btreport.TabIndex = 16;
            this.btreport.Text = "Laporan Bulanan (F3)";
            this.btreport.UseVisualStyleBackColor = false;
            this.btreport.Click += new System.EventHandler(this.btreport_Click);
            // 
            // changepswd
            // 
            this.changepswd.BackColor = System.Drawing.Color.Teal;
            this.changepswd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changepswd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepswd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changepswd.Location = new System.Drawing.Point(247, 90);
            this.changepswd.Name = "changepswd";
            this.changepswd.Size = new System.Drawing.Size(207, 54);
            this.changepswd.TabIndex = 17;
            this.changepswd.Text = "Ganti Kata Sandi (F2)";
            this.changepswd.UseVisualStyleBackColor = false;
            this.changepswd.Click += new System.EventHandler(this.changepswd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 235);
            this.Controls.Add(this.btnhistory);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.changepswd);
            this.Controls.Add(this.btreport);
            this.Controls.Add(this.pbposicon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbposicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btnhistory;
        private System.Windows.Forms.PictureBox pbposicon;
        private System.Windows.Forms.Button btreport;
        private System.Windows.Forms.Button changepswd;
    }
}