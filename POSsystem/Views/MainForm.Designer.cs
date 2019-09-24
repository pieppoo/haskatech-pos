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
            ((System.ComponentModel.ISupportInitialize)(this.pbposicon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.Color.Teal;
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnproduct.Location = new System.Drawing.Point(270, 34);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(230, 68);
            this.btnproduct.TabIndex = 12;
            this.btnproduct.Text = "Manajemen Produk";
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btnhistory
            // 
            this.btnhistory.BackColor = System.Drawing.Color.Teal;
            this.btnhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnhistory.Location = new System.Drawing.Point(270, 116);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(230, 68);
            this.btnhistory.TabIndex = 14;
            this.btnhistory.Text = "Riwayat Penjualan";
            this.btnhistory.UseVisualStyleBackColor = false;
            this.btnhistory.Click += new System.EventHandler(this.btnhistory_Click);
            // 
            // pbposicon
            // 
            this.pbposicon.ErrorImage = null;
            this.pbposicon.Image = global::POSsystem.Properties.Resources.trolley;
            this.pbposicon.Location = new System.Drawing.Point(27, 34);
            this.pbposicon.Name = "pbposicon";
            this.pbposicon.Size = new System.Drawing.Size(226, 225);
            this.pbposicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbposicon.TabIndex = 15;
            this.pbposicon.TabStop = false;
            // 
            // btreport
            // 
            this.btreport.BackColor = System.Drawing.Color.Teal;
            this.btreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btreport.Location = new System.Drawing.Point(270, 198);
            this.btreport.Name = "btreport";
            this.btreport.Size = new System.Drawing.Size(230, 68);
            this.btreport.TabIndex = 16;
            this.btreport.Text = "Laporan Bulanan";
            this.btreport.UseVisualStyleBackColor = false;
            this.btreport.Click += new System.EventHandler(this.btreport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 294);
            this.Controls.Add(this.btreport);
            this.Controls.Add(this.pbposicon);
            this.Controls.Add(this.btnhistory);
            this.Controls.Add(this.btnproduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbposicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btnhistory;
        private System.Windows.Forms.PictureBox pbposicon;
        private System.Windows.Forms.Button btreport;
    }
}