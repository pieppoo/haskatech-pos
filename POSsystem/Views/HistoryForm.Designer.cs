﻿namespace POSsystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.gvhistory = new System.Windows.Forms.DataGridView();
            this.IDSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatetimeSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarkSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btpenjualanbaru = new System.Windows.Forms.Button();
            this.lb_datesearch = new System.Windows.Forms.Label();
            this.lbpaymodesearch = new System.Windows.Forms.Label();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.cbpaymentmode = new System.Windows.Forms.ComboBox();
            this.btnprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvhistory)).BeginInit();
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
            this.TotalSell,
            this.PayMode,
            this.RemarkSell});
            this.gvhistory.Location = new System.Drawing.Point(24, 227);
            this.gvhistory.Margin = new System.Windows.Forms.Padding(4);
            this.gvhistory.Name = "gvhistory";
            this.gvhistory.ReadOnly = true;
            this.gvhistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvhistory.Size = new System.Drawing.Size(650, 246);
            this.gvhistory.TabIndex = 8;
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
            // TotalSell
            // 
            this.TotalSell.FillWeight = 70F;
            this.TotalSell.HeaderText = "Total Penjualan";
            this.TotalSell.Name = "TotalSell";
            this.TotalSell.ReadOnly = true;
            this.TotalSell.Width = 145;
            // 
            // PayMode
            // 
            this.PayMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PayMode.FillWeight = 70F;
            this.PayMode.HeaderText = "Tipe Pembayaran";
            this.PayMode.Name = "PayMode";
            this.PayMode.ReadOnly = true;
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
            this.btpenjualanbaru.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpenjualanbaru.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btpenjualanbaru.Location = new System.Drawing.Point(24, 490);
            this.btpenjualanbaru.Margin = new System.Windows.Forms.Padding(4);
            this.btpenjualanbaru.Name = "btpenjualanbaru";
            this.btpenjualanbaru.Size = new System.Drawing.Size(233, 55);
            this.btpenjualanbaru.TabIndex = 14;
            this.btpenjualanbaru.Text = "Penjualan baru";
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
            this.dtpfrom.TabIndex = 20;
            this.dtpfrom.Value = new System.DateTime(2019, 8, 26, 16, 27, 41, 0);
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
            this.dtpto.Location = new System.Drawing.Point(264, 179);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(190, 32);
            this.dtpto.TabIndex = 21;
            this.dtpto.ValueChanged += new System.EventHandler(this.dtpto_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "to";
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Goldenrod;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnreset.Location = new System.Drawing.Point(509, 99);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(165, 50);
            this.btnreset.TabIndex = 23;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btsearch
            // 
            this.btsearch.BackColor = System.Drawing.Color.Goldenrod;
            this.btsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btsearch.Location = new System.Drawing.Point(509, 170);
            this.btsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(165, 50);
            this.btsearch.TabIndex = 24;
            this.btsearch.Text = "Cari";
            this.btsearch.UseVisualStyleBackColor = false;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // cbpaymentmode
            // 
            this.cbpaymentmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpaymentmode.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpaymentmode.FormattingEnabled = true;
            this.cbpaymentmode.Location = new System.Drawing.Point(23, 108);
            this.cbpaymentmode.Name = "cbpaymentmode";
            this.cbpaymentmode.Size = new System.Drawing.Size(431, 33);
            this.cbpaymentmode.TabIndex = 25;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.Teal;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnprint.Location = new System.Drawing.Point(441, 490);
            this.btnprint.Margin = new System.Windows.Forms.Padding(4);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(233, 55);
            this.btnprint.TabIndex = 26;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 558);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.cbpaymentmode);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.btnreset);
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
            this.Controls.SetChildIndex(this.btnreset, 0);
            this.Controls.SetChildIndex(this.btsearch, 0);
            this.Controls.SetChildIndex(this.cbpaymentmode, 0);
            this.Controls.SetChildIndex(this.btnprint, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvhistory)).EndInit();
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
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.ComboBox cbpaymentmode;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatetimeSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarkSell;
        private System.Windows.Forms.Button btnprint;
    }
}