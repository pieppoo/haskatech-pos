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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvpurchase = new System.Windows.Forms.DataGridView();
            this.btdeleteitem = new System.Windows.Forms.Button();
            this.btadditem = new System.Windows.Forms.Button();
            this.btnSellPrice = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btunitproduk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbitemname = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateitemin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvpurchase)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.Dateitemin,
            this.purchase_unit,
            this.purchase_qty,
            this.purchase_price});
            this.gvpurchase.Location = new System.Drawing.Point(21, 102);
            this.gvpurchase.Name = "gvpurchase";
            this.gvpurchase.ReadOnly = true;
            this.gvpurchase.RowHeadersVisible = false;
            this.gvpurchase.RowTemplate.Height = 30;
            this.gvpurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvpurchase.Size = new System.Drawing.Size(865, 284);
            this.gvpurchase.TabIndex = 11;
            // 
            // btdeleteitem
            // 
            this.btdeleteitem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btdeleteitem.BackColor = System.Drawing.Color.Teal;
            this.btdeleteitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeleteitem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeleteitem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdeleteitem.Location = new System.Drawing.Point(10, 6);
            this.btdeleteitem.Margin = new System.Windows.Forms.Padding(4);
            this.btdeleteitem.Name = "btdeleteitem";
            this.btdeleteitem.Size = new System.Drawing.Size(148, 82);
            this.btdeleteitem.TabIndex = 14;
            this.btdeleteitem.Text = "Hapus Barang (F3)";
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
            this.btadditem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadditem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btadditem.Location = new System.Drawing.Point(10, 6);
            this.btadditem.Margin = new System.Windows.Forms.Padding(4);
            this.btadditem.Name = "btadditem";
            this.btadditem.Size = new System.Drawing.Size(148, 82);
            this.btadditem.TabIndex = 12;
            this.btadditem.Text = "Barang Masuk (F2)";
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
            this.btnSellPrice.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSellPrice.Location = new System.Drawing.Point(9, 6);
            this.btnSellPrice.Margin = new System.Windows.Forms.Padding(4);
            this.btnSellPrice.Name = "btnSellPrice";
            this.btnSellPrice.Size = new System.Drawing.Size(148, 82);
            this.btnSellPrice.TabIndex = 15;
            this.btnSellPrice.Text = "Harga Jual (F4)";
            this.btnSellPrice.UseVisualStyleBackColor = false;
            this.btnSellPrice.Click += new System.EventHandler(this.btnSellPrice_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 399);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(865, 100);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btunitproduk);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 94);
            this.panel1.TabIndex = 0;
            // 
            // btunitproduk
            // 
            this.btunitproduk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btunitproduk.BackColor = System.Drawing.Color.Teal;
            this.btunitproduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btunitproduk.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunitproduk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btunitproduk.Location = new System.Drawing.Point(10, 6);
            this.btunitproduk.Margin = new System.Windows.Forms.Padding(4);
            this.btunitproduk.Name = "btunitproduk";
            this.btunitproduk.Size = new System.Drawing.Size(148, 82);
            this.btunitproduk.TabIndex = 13;
            this.btunitproduk.Text = "Kemasan Produk (F1)";
            this.btunitproduk.UseVisualStyleBackColor = false;
            this.btunitproduk.Click += new System.EventHandler(this.btunitproduk_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btadditem);
            this.panel2.Location = new System.Drawing.Point(176, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 94);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btdeleteitem);
            this.panel3.Location = new System.Drawing.Point(349, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 94);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnSellPrice);
            this.panel4.Location = new System.Drawing.Point(522, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 94);
            this.panel4.TabIndex = 3;
            // 
            // lbitemname
            // 
            this.lbitemname.AutoSize = true;
            this.lbitemname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbitemname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbitemname.Location = new System.Drawing.Point(16, 64);
            this.lbitemname.Name = "lbitemname";
            this.lbitemname.Size = new System.Drawing.Size(135, 25);
            this.lbitemname.TabIndex = 17;
            this.lbitemname.Text = "Nama Produk";
            this.lbitemname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Location = new System.Drawing.Point(695, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 94);
            this.panel5.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbtime);
            this.groupBox1.Controls.Add(this.lbdate);
            this.groupBox1.Location = new System.Drawing.Point(3, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 74);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // lbtime
            // 
            this.lbtime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.Location = new System.Drawing.Point(0, 8);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(160, 27);
            this.lbtime.TabIndex = 0;
            this.lbtime.Text = "time";
            this.lbtime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbdate
            // 
            this.lbdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(0, 43);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(160, 31);
            this.lbdate.TabIndex = 1;
            this.lbdate.Text = "date";
            this.lbdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Dateitemin
            // 
            this.Dateitemin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dateitemin.FillWeight = 25F;
            this.Dateitemin.HeaderText = "Tanggal Penambahan Barang";
            this.Dateitemin.Name = "Dateitemin";
            this.Dateitemin.ReadOnly = true;
            // 
            // purchase_unit
            // 
            this.purchase_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchase_unit.FillWeight = 25F;
            this.purchase_unit.HeaderText = "Kemasan Beli";
            this.purchase_unit.Name = "purchase_unit";
            this.purchase_unit.ReadOnly = true;
            // 
            // purchase_qty
            // 
            this.purchase_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchase_qty.FillWeight = 25F;
            this.purchase_qty.HeaderText = "Jumlah beli";
            this.purchase_qty.Name = "purchase_qty";
            this.purchase_qty.ReadOnly = true;
            // 
            // purchase_price
            // 
            this.purchase_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.purchase_price.DefaultCellStyle = dataGridViewCellStyle1;
            this.purchase_price.FillWeight = 25F;
            this.purchase_price.HeaderText = "Harga Beli (Rp)";
            this.purchase_price.Name = "purchase_price";
            this.purchase_price.ReadOnly = true;
            // 
            // ManagePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 513);
            this.Controls.Add(this.lbitemname);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gvpurchase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManagePurchase";
            this.Text = "HaskaTech POS";
            this.Title = "Daftar Pembelian (Barang Masuk)";
            this.Load += new System.EventHandler(this.ManageWarehouse_Load);
            this.Controls.SetChildIndex(this.gvpurchase, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.lbitemname, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvpurchase)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvpurchase;
        private System.Windows.Forms.Button btdeleteitem;
        private System.Windows.Forms.Button btadditem;
        private System.Windows.Forms.Button btnSellPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbitemname;
        private System.Windows.Forms.Button btunitproduk;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateitemin;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_price;
    }
}