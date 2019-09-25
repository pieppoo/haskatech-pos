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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.gvhistory = new System.Windows.Forms.DataGridView();
            this.IDSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatetimeSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oritotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarkSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btpenjualanbaru = new System.Windows.Forms.Button();
            this.lb_datesearch = new System.Windows.Forms.Label();
            this.lbpaymodesearch = new System.Windows.Forms.Label();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbpaymentmode = new System.Windows.Forms.ComboBox();
            this.tbtotalgv = new System.Windows.Forms.TextBox();
            this.btfinditem = new System.Windows.Forms.Button();
            this.pbsearch = new System.Windows.Forms.PictureBox();
            this.pbreset = new System.Windows.Forms.PictureBox();
            this.lbF3 = new System.Windows.Forms.Label();
            this.lbF4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvhistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbreset)).BeginInit();
            this.SuspendLayout();
            // 
            // gvhistory
            // 
            this.gvhistory.AllowUserToAddRows = false;
            this.gvhistory.AllowUserToDeleteRows = false;
            this.gvhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvhistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSell,
            this.DatetimeSell,
            this.PayMode,
            this.oritotal,
            this.discount,
            this.TotalSell,
            this.RemarkSell});
            this.gvhistory.Location = new System.Drawing.Point(24, 227);
            this.gvhistory.Margin = new System.Windows.Forms.Padding(4);
            this.gvhistory.Name = "gvhistory";
            this.gvhistory.ReadOnly = true;
            this.gvhistory.RowHeadersVisible = false;
            this.gvhistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvhistory.Size = new System.Drawing.Size(650, 246);
            this.gvhistory.TabIndex = 0;
            this.gvhistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvhistory_CellDoubleClick);
            // 
            // IDSell
            // 
            this.IDSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IDSell.FillWeight = 70F;
            this.IDSell.HeaderText = "ID";
            this.IDSell.Name = "IDSell";
            this.IDSell.ReadOnly = true;
            this.IDSell.Visible = false;
            this.IDSell.Width = 70;
            // 
            // DatetimeSell
            // 
            this.DatetimeSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DatetimeSell.FillWeight = 125F;
            this.DatetimeSell.HeaderText = "Tanggal / Jam penjualan";
            this.DatetimeSell.Name = "DatetimeSell";
            this.DatetimeSell.ReadOnly = true;
            this.DatetimeSell.Width = 172;
            // 
            // PayMode
            // 
            this.PayMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PayMode.FillWeight = 70F;
            this.PayMode.HeaderText = "Tipe Pembayaran";
            this.PayMode.Name = "PayMode";
            this.PayMode.ReadOnly = true;
            // 
            // oritotal
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.oritotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.oritotal.HeaderText = "Total Awal (Rp)";
            this.oritotal.Name = "oritotal";
            this.oritotal.ReadOnly = true;
            // 
            // discount
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.discount.DefaultCellStyle = dataGridViewCellStyle2;
            this.discount.HeaderText = "diskaun (Rp)";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // TotalSell
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalSell.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalSell.FillWeight = 70F;
            this.TotalSell.HeaderText = "Total Akhir (Rp)";
            this.TotalSell.Name = "TotalSell";
            this.TotalSell.ReadOnly = true;
            this.TotalSell.Width = 145;
            // 
            // RemarkSell
            // 
            this.RemarkSell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RemarkSell.HeaderText = "Keterangan";
            this.RemarkSell.Name = "RemarkSell";
            this.RemarkSell.ReadOnly = true;
            this.RemarkSell.Visible = false;
            // 
            // btpenjualanbaru
            // 
            this.btpenjualanbaru.BackColor = System.Drawing.Color.Teal;
            this.btpenjualanbaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btpenjualanbaru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpenjualanbaru.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btpenjualanbaru.Location = new System.Drawing.Point(24, 490);
            this.btpenjualanbaru.Margin = new System.Windows.Forms.Padding(4);
            this.btpenjualanbaru.Name = "btpenjualanbaru";
            this.btpenjualanbaru.Size = new System.Drawing.Size(147, 55);
            this.btpenjualanbaru.TabIndex = 1;
            this.btpenjualanbaru.Text = "Penjualan baru\r\n(F1)";
            this.btpenjualanbaru.UseVisualStyleBackColor = false;
            this.btpenjualanbaru.Click += new System.EventHandler(this.btpenjualanbaru_Click);
            // 
            // lb_datesearch
            // 
            this.lb_datesearch.AutoSize = true;
            this.lb_datesearch.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_datesearch.Location = new System.Drawing.Point(20, 154);
            this.lb_datesearch.Name = "lb_datesearch";
            this.lb_datesearch.Size = new System.Drawing.Size(157, 22);
            this.lb_datesearch.TabIndex = 16;
            this.lb_datesearch.Text = "Tanggal penjualan";
            // 
            // lbpaymodesearch
            // 
            this.lbpaymodesearch.AutoSize = true;
            this.lbpaymodesearch.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpaymodesearch.Location = new System.Drawing.Point(19, 82);
            this.lbpaymodesearch.Name = "lbpaymodesearch";
            this.lbpaymodesearch.Size = new System.Drawing.Size(152, 22);
            this.lbpaymodesearch.TabIndex = 18;
            this.lbpaymodesearch.Text = "Tipe pembayaran";
            // 
            // dtpfrom
            // 
            this.dtpfrom.CalendarFont = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfrom.CustomFormat = "";
            this.dtpfrom.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfrom.Location = new System.Drawing.Point(24, 179);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(183, 32);
            this.dtpfrom.TabIndex = 4;
            this.dtpfrom.Value = new System.DateTime(2019, 8, 30, 0, 0, 0, 0);
            this.dtpfrom.ValueChanged += new System.EventHandler(this.dtpfrom_ValueChanged);
            // 
            // dtpto
            // 
            this.dtpto.CalendarFont = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpto.Checked = false;
            this.dtpto.CustomFormat = "";
            this.dtpto.Enabled = false;
            this.dtpto.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpto.Location = new System.Drawing.Point(263, 179);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(190, 32);
            this.dtpto.TabIndex = 5;
            this.dtpto.Value = new System.DateTime(2019, 8, 30, 0, 0, 0, 0);
            this.dtpto.ValueChanged += new System.EventHandler(this.dtpto_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "to";
            // 
            // cbpaymentmode
            // 
            this.cbpaymentmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpaymentmode.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpaymentmode.FormattingEnabled = true;
            this.cbpaymentmode.Location = new System.Drawing.Point(23, 108);
            this.cbpaymentmode.Name = "cbpaymentmode";
            this.cbpaymentmode.Size = new System.Drawing.Size(430, 33);
            this.cbpaymentmode.TabIndex = 3;
            this.cbpaymentmode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbpaymentmode_KeyDown);
            // 
            // tbtotalgv
            // 
            this.tbtotalgv.Enabled = false;
            this.tbtotalgv.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotalgv.Location = new System.Drawing.Point(399, 493);
            this.tbtotalgv.Name = "tbtotalgv";
            this.tbtotalgv.ReadOnly = true;
            this.tbtotalgv.Size = new System.Drawing.Size(274, 49);
            this.tbtotalgv.TabIndex = 27;
            // 
            // btfinditem
            // 
            this.btfinditem.BackColor = System.Drawing.Color.Teal;
            this.btfinditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfinditem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfinditem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btfinditem.Location = new System.Drawing.Point(211, 490);
            this.btfinditem.Margin = new System.Windows.Forms.Padding(4);
            this.btfinditem.Name = "btfinditem";
            this.btfinditem.Size = new System.Drawing.Size(147, 55);
            this.btfinditem.TabIndex = 2;
            this.btfinditem.Text = "Cari Barang\r\n(F2)";
            this.btfinditem.UseVisualStyleBackColor = false;
            this.btfinditem.Click += new System.EventHandler(this.btfinditem_Click);
            // 
            // pbsearch
            // 
            this.pbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbsearch.Image = global::POSsystem.Properties.Resources.search;
            this.pbsearch.Location = new System.Drawing.Point(494, 124);
            this.pbsearch.Name = "pbsearch";
            this.pbsearch.Size = new System.Drawing.Size(77, 63);
            this.pbsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbsearch.TabIndex = 30;
            this.pbsearch.TabStop = false;
            this.pbsearch.Click += new System.EventHandler(this.pbsearch_Click);
            // 
            // pbreset
            // 
            this.pbreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbreset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbreset.Image = global::POSsystem.Properties.Resources.Refresh;
            this.pbreset.Location = new System.Drawing.Point(596, 124);
            this.pbreset.Name = "pbreset";
            this.pbreset.Size = new System.Drawing.Size(77, 63);
            this.pbreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbreset.TabIndex = 29;
            this.pbreset.TabStop = false;
            this.pbreset.Click += new System.EventHandler(this.pbreset_Click);
            // 
            // lbF3
            // 
            this.lbF3.AutoSize = true;
            this.lbF3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF3.ForeColor = System.Drawing.Color.DarkRed;
            this.lbF3.Location = new System.Drawing.Point(549, 113);
            this.lbF3.Name = "lbF3";
            this.lbF3.Size = new System.Drawing.Size(27, 19);
            this.lbF3.TabIndex = 31;
            this.lbF3.Text = "F3";
            // 
            // lbF4
            // 
            this.lbF4.AutoSize = true;
            this.lbF4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF4.ForeColor = System.Drawing.Color.DarkRed;
            this.lbF4.Location = new System.Drawing.Point(660, 113);
            this.lbF4.Name = "lbF4";
            this.lbF4.Size = new System.Drawing.Size(27, 19);
            this.lbF4.TabIndex = 32;
            this.lbF4.Text = "F4";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 558);
            this.Controls.Add(this.lbF4);
            this.Controls.Add(this.lbF3);
            this.Controls.Add(this.pbsearch);
            this.Controls.Add(this.pbreset);
            this.Controls.Add(this.btfinditem);
            this.Controls.Add(this.tbtotalgv);
            this.Controls.Add(this.cbpaymentmode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpto);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.lbpaymodesearch);
            this.Controls.Add(this.lb_datesearch);
            this.Controls.Add(this.btpenjualanbaru);
            this.Controls.Add(this.gvhistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HistoryForm";
            this.Text = "HaskaTech POS";
            this.Title = "Riwayat Penjualan";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.Controls.SetChildIndex(this.gvhistory, 0);
            this.Controls.SetChildIndex(this.btpenjualanbaru, 0);
            this.Controls.SetChildIndex(this.lb_datesearch, 0);
            this.Controls.SetChildIndex(this.lbpaymodesearch, 0);
            this.Controls.SetChildIndex(this.dtpfrom, 0);
            this.Controls.SetChildIndex(this.dtpto, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cbpaymentmode, 0);
            this.Controls.SetChildIndex(this.tbtotalgv, 0);
            this.Controls.SetChildIndex(this.btfinditem, 0);
            this.Controls.SetChildIndex(this.pbreset, 0);
            this.Controls.SetChildIndex(this.pbsearch, 0);
            this.Controls.SetChildIndex(this.lbF3, 0);
            this.Controls.SetChildIndex(this.lbF4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvhistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbreset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvhistory;
        private System.Windows.Forms.Button btpenjualanbaru;
        private System.Windows.Forms.Label lb_datesearch;
        private System.Windows.Forms.Label lbpaymodesearch;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbpaymentmode;
        private System.Windows.Forms.TextBox tbtotalgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatetimeSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn oritotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarkSell;
        private System.Windows.Forms.Button btfinditem;
        private System.Windows.Forms.PictureBox pbreset;
        private System.Windows.Forms.PictureBox pbsearch;
        private System.Windows.Forms.Label lbF3;
        private System.Windows.Forms.Label lbF4;
    }
}