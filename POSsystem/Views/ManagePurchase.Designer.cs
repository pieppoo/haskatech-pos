namespace POSsystem.Views
{
    partial class ManagePurchase
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
            this.gvpurchase = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_pcs_in_container = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcs_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCStotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateitemin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btdeleteitem = new System.Windows.Forms.Button();
            this.btadditem = new System.Windows.Forms.Button();
            this.btnSellPrice = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvpurchase)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvpurchase
            // 
            this.gvpurchase.AllowUserToAddRows = false;
            this.gvpurchase.AllowUserToDeleteRows = false;
            this.gvpurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvpurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvpurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.itemname,
            this.purchase_qty,
            this.purchase_unit,
            this.purchase_price,
            this.qty_pcs_in_container,
            this.pcs_unit,
            this.PCStotal,
            this.Dateitemin});
            this.gvpurchase.Location = new System.Drawing.Point(21, 95);
            this.gvpurchase.Name = "gvpurchase";
            this.gvpurchase.ReadOnly = true;
            this.gvpurchase.RowHeadersVisible = false;
            this.gvpurchase.RowTemplate.Height = 30;
            this.gvpurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvpurchase.Size = new System.Drawing.Size(865, 307);
            this.gvpurchase.TabIndex = 11;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // itemname
            // 
            this.itemname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.itemname.HeaderText = "Nama barang";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            this.itemname.Width = 109;
            // 
            // purchase_qty
            // 
            this.purchase_qty.FillWeight = 70F;
            this.purchase_qty.HeaderText = "Jumlah beli";
            this.purchase_qty.Name = "purchase_qty";
            this.purchase_qty.ReadOnly = true;
            this.purchase_qty.Width = 70;
            // 
            // purchase_unit
            // 
            this.purchase_unit.HeaderText = "Kemasan Beli";
            this.purchase_unit.Name = "purchase_unit";
            this.purchase_unit.ReadOnly = true;
            // 
            // purchase_price
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.purchase_price.DefaultCellStyle = dataGridViewCellStyle1;
            this.purchase_price.HeaderText = "Harga Beli (Rp)";
            this.purchase_price.Name = "purchase_price";
            this.purchase_price.ReadOnly = true;
            // 
            // qty_pcs_in_container
            // 
            this.qty_pcs_in_container.HeaderText = "Jumlah eceran perKemasan";
            this.qty_pcs_in_container.Name = "qty_pcs_in_container";
            this.qty_pcs_in_container.ReadOnly = true;
            this.qty_pcs_in_container.Width = 120;
            // 
            // pcs_unit
            // 
            this.pcs_unit.HeaderText = "Kemasan Eceran";
            this.pcs_unit.Name = "pcs_unit";
            this.pcs_unit.ReadOnly = true;
            // 
            // PCStotal
            // 
            this.PCStotal.HeaderText = "Total Seluruh dalam eceran";
            this.PCStotal.Name = "PCStotal";
            this.PCStotal.ReadOnly = true;
            this.PCStotal.Visible = false;
            // 
            // Dateitemin
            // 
            this.Dateitemin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dateitemin.HeaderText = "Tanggal Penambahan Barang";
            this.Dateitemin.Name = "Dateitemin";
            this.Dateitemin.ReadOnly = true;
            // 
            // btdeleteitem
            // 
            this.btdeleteitem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btdeleteitem.BackColor = System.Drawing.Color.Teal;
            this.btdeleteitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeleteitem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeleteitem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdeleteitem.Location = new System.Drawing.Point(4, 6);
            this.btdeleteitem.Margin = new System.Windows.Forms.Padding(4);
            this.btdeleteitem.Name = "btdeleteitem";
            this.btdeleteitem.Size = new System.Drawing.Size(274, 53);
            this.btdeleteitem.TabIndex = 14;
            this.btdeleteitem.Text = "Hapus Barang (F2)";
            this.btdeleteitem.UseVisualStyleBackColor = false;
            this.btdeleteitem.Click += new System.EventHandler(this.btdeleteitem_Click);
            // 
            // btadditem
            // 
            this.btadditem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btadditem.BackColor = System.Drawing.Color.Teal;
            this.btadditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btadditem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadditem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btadditem.Location = new System.Drawing.Point(4, 6);
            this.btadditem.Margin = new System.Windows.Forms.Padding(4);
            this.btadditem.Name = "btadditem";
            this.btadditem.Size = new System.Drawing.Size(274, 53);
            this.btadditem.TabIndex = 12;
            this.btadditem.Text = "Tambah Barang (F1)";
            this.btadditem.UseVisualStyleBackColor = false;
            this.btadditem.Click += new System.EventHandler(this.btadditem_Click);
            // 
            // btnSellPrice
            // 
            this.btnSellPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSellPrice.BackColor = System.Drawing.Color.Peru;
            this.btnSellPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSellPrice.Location = new System.Drawing.Point(5, 6);
            this.btnSellPrice.Margin = new System.Windows.Forms.Padding(4);
            this.btnSellPrice.Name = "btnSellPrice";
            this.btnSellPrice.Size = new System.Drawing.Size(274, 53);
            this.btnSellPrice.TabIndex = 15;
            this.btnSellPrice.Text = "Edit Harga Jual (F3)";
            this.btnSellPrice.UseVisualStyleBackColor = false;
            this.btnSellPrice.Click += new System.EventHandler(this.btnSellPrice_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 421);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(865, 69);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btadditem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 63);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btdeleteitem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(291, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 63);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSellPrice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(579, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 63);
            this.panel3.TabIndex = 2;
            // 
            // ManagePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gvpurchase);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManagePurchase";
            this.Text = "HaskaTech POS";
            this.Title = "Daftar Pembelian";
            this.Load += new System.EventHandler(this.ManageWarehouse_Load);
            this.Controls.SetChildIndex(this.gvpurchase, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvpurchase)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvpurchase;
        private System.Windows.Forms.Button btdeleteitem;
        private System.Windows.Forms.Button btadditem;
        private System.Windows.Forms.Button btnSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_pcs_in_container;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcs_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCStotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateitemin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}