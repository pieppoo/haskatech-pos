namespace POSsystem
{
    partial class HistoryForm
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
            this.bttutuppenjualan = new System.Windows.Forms.Button();
            this.btpenjualanbaru = new System.Windows.Forms.Button();
            this.lbuser = new System.Windows.Forms.Label();
            this.gvhistory = new System.Windows.Forms.DataGridView();
            this.IDSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatetimeSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarkSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbsystemdate = new System.Windows.Forms.Label();
            this.lbpenjualanhariini = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvhistory)).BeginInit();
            this.SuspendLayout();
            // 
            // bttutuppenjualan
            // 
            this.bttutuppenjualan.Location = new System.Drawing.Point(600, 401);
            this.bttutuppenjualan.Name = "bttutuppenjualan";
            this.bttutuppenjualan.Size = new System.Drawing.Size(133, 23);
            this.bttutuppenjualan.TabIndex = 11;
            this.bttutuppenjualan.Text = "Tutup penjualan";
            this.bttutuppenjualan.UseVisualStyleBackColor = true;
            // 
            // btpenjualanbaru
            // 
            this.btpenjualanbaru.Location = new System.Drawing.Point(72, 401);
            this.btpenjualanbaru.Name = "btpenjualanbaru";
            this.btpenjualanbaru.Size = new System.Drawing.Size(133, 23);
            this.btpenjualanbaru.TabIndex = 10;
            this.btpenjualanbaru.Text = "Penjualan baru";
            this.btpenjualanbaru.UseVisualStyleBackColor = true;
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.Location = new System.Drawing.Point(629, 107);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(35, 17);
            this.lbuser.TabIndex = 9;
            this.lbuser.Text = "user";
            this.lbuser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gvhistory
            // 
            this.gvhistory.AllowUserToAddRows = false;
            this.gvhistory.AllowUserToDeleteRows = false;
            this.gvhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvhistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSell,
            this.DatetimeSell,
            this.TotalSell,
            this.PayMode,
            this.RemarkSell});
            this.gvhistory.Location = new System.Drawing.Point(72, 129);
            this.gvhistory.Name = "gvhistory";
            this.gvhistory.ReadOnly = true;
            this.gvhistory.Size = new System.Drawing.Size(661, 254);
            this.gvhistory.TabIndex = 8;
            // 
            // IDSell
            // 
            this.IDSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IDSell.HeaderText = "ID";
            this.IDSell.MinimumWidth = 80;
            this.IDSell.Name = "IDSell";
            this.IDSell.ReadOnly = true;
            // 
            // DatetimeSell
            // 
            this.DatetimeSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DatetimeSell.HeaderText = "Jam penjualan";
            this.DatetimeSell.Name = "DatetimeSell";
            this.DatetimeSell.ReadOnly = true;
            this.DatetimeSell.Width = 92;
            // 
            // TotalSell
            // 
            this.TotalSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalSell.HeaderText = "Total Penjualan";
            this.TotalSell.Name = "TotalSell";
            this.TotalSell.ReadOnly = true;
            this.TotalSell.Width = 97;
            // 
            // PayMode
            // 
            this.PayMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PayMode.HeaderText = "Tipe Pembayaran";
            this.PayMode.Name = "PayMode";
            this.PayMode.ReadOnly = true;
            this.PayMode.Width = 105;
            // 
            // RemarkSell
            // 
            this.RemarkSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RemarkSell.HeaderText = "Keterangan";
            this.RemarkSell.Name = "RemarkSell";
            this.RemarkSell.ReadOnly = true;
            // 
            // lbsystemdate
            // 
            this.lbsystemdate.AutoSize = true;
            this.lbsystemdate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsystemdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbsystemdate.Location = new System.Drawing.Point(68, 107);
            this.lbsystemdate.Name = "lbsystemdate";
            this.lbsystemdate.Size = new System.Drawing.Size(35, 17);
            this.lbsystemdate.TabIndex = 7;
            this.lbsystemdate.Text = "date";
            // 
            // lbpenjualanhariini
            // 
            this.lbpenjualanhariini.AutoSize = true;
            this.lbpenjualanhariini.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpenjualanhariini.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbpenjualanhariini.Location = new System.Drawing.Point(300, 31);
            this.lbpenjualanhariini.Name = "lbpenjualanhariini";
            this.lbpenjualanhariini.Size = new System.Drawing.Size(230, 34);
            this.lbpenjualanhariini.TabIndex = 6;
            this.lbpenjualanhariini.Text = "Penjualan hari ini";
            this.lbpenjualanhariini.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttutuppenjualan);
            this.Controls.Add(this.btpenjualanbaru);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.gvhistory);
            this.Controls.Add(this.lbsystemdate);
            this.Controls.Add(this.lbpenjualanhariini);
            this.Name = "HistoryForm";
            this.Text = "Riwayat Penjualan";
            ((System.ComponentModel.ISupportInitialize)(this.gvhistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttutuppenjualan;
        private System.Windows.Forms.Button btpenjualanbaru;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.DataGridView gvhistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatetimeSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarkSell;
        private System.Windows.Forms.Label lbsystemdate;
        private System.Windows.Forms.Label lbpenjualanhariini;
    }
}