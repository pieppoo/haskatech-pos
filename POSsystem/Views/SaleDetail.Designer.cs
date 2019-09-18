namespace POSsystem.Views
{
    partial class SaleDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvsaledetail = new System.Windows.Forms.DataGridView();
            this.lbtotal = new System.Windows.Forms.Label();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceinpcs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oritotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalsell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvsaledetail)).BeginInit();
            this.SuspendLayout();
            // 
            // gvsaledetail
            // 
            this.gvsaledetail.AllowUserToAddRows = false;
            this.gvsaledetail.AllowUserToDeleteRows = false;
            this.gvsaledetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvsaledetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.historyid,
            this.itemname,
            this.qty,
            this.unitsell,
            this.priceinpcs,
            this.oritotal,
            this.disc,
            this.totalsell});
            this.gvsaledetail.Location = new System.Drawing.Point(22, 75);
            this.gvsaledetail.MultiSelect = false;
            this.gvsaledetail.Name = "gvsaledetail";
            this.gvsaledetail.ReadOnly = true;
            this.gvsaledetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvsaledetail.Size = new System.Drawing.Size(747, 292);
            this.gvsaledetail.TabIndex = 11;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbtotal.Location = new System.Drawing.Point(399, 385);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(182, 28);
            this.lbtotal.TabIndex = 12;
            this.lbtotal.Text = "Total Penjualan";
            // 
            // tbtotal
            // 
            this.tbtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtotal.Enabled = false;
            this.tbtotal.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbtotal.Location = new System.Drawing.Point(600, 377);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.ReadOnly = true;
            this.tbtotal.Size = new System.Drawing.Size(169, 36);
            this.tbtotal.TabIndex = 13;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // historyid
            // 
            this.historyid.HeaderText = "historyid";
            this.historyid.Name = "historyid";
            this.historyid.ReadOnly = true;
            this.historyid.Visible = false;
            // 
            // itemname
            // 
            this.itemname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.itemname.HeaderText = "Nama barang";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            this.itemname.Width = 119;
            // 
            // qty
            // 
            this.qty.HeaderText = "Jumlah jual";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // unitsell
            // 
            this.unitsell.HeaderText = "Kemasan";
            this.unitsell.Name = "unitsell";
            this.unitsell.ReadOnly = true;
            // 
            // priceinpcs
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.priceinpcs.DefaultCellStyle = dataGridViewCellStyle1;
            this.priceinpcs.HeaderText = "Harga perBarang (Rp)";
            this.priceinpcs.Name = "priceinpcs";
            this.priceinpcs.ReadOnly = true;
            // 
            // oritotal
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.oritotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.oritotal.HeaderText = "Total Awal (Rp)";
            this.oritotal.Name = "oritotal";
            this.oritotal.ReadOnly = true;
            // 
            // disc
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.disc.DefaultCellStyle = dataGridViewCellStyle3;
            this.disc.HeaderText = "Diskaun (Rp)";
            this.disc.Name = "disc";
            this.disc.ReadOnly = true;
            // 
            // totalsell
            // 
            this.totalsell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totalsell.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalsell.HeaderText = "Total Akhir (Rp)";
            this.totalsell.Name = "totalsell";
            this.totalsell.ReadOnly = true;
            // 
            // SaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 438);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.gvsaledetail);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SaleDetail";
            this.Text = "SaleList";
            this.Title = "Rincian penjualan";
            this.Load += new System.EventHandler(this.SaleDetail_Load);
            this.Controls.SetChildIndex(this.gvsaledetail, 0);
            this.Controls.SetChildIndex(this.lbtotal, 0);
            this.Controls.SetChildIndex(this.tbtotal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvsaledetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvsaledetail;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsell;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceinpcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn oritotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalsell;
    }
}