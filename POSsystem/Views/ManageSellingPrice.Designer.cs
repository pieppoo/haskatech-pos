namespace POSsystem.Views
{
    partial class ManageSellingPrice
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
            this.gvsellprice = new System.Windows.Forms.DataGridView();
            this.warehouseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnnewprice = new System.Windows.Forms.Button();
            this.bteditprice = new System.Windows.Forms.Button();
            this.btndeleteprice = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvsellprice)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvsellprice
            // 
            this.gvsellprice.AllowUserToAddRows = false;
            this.gvsellprice.AllowUserToDeleteRows = false;
            this.gvsellprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvsellprice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvsellprice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvsellprice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warehouseid,
            this.itemid,
            this.sellid,
            this.ItemName,
            this.sellprice,
            this.perUnit,
            this.barcodeno});
            this.gvsellprice.Location = new System.Drawing.Point(31, 84);
            this.gvsellprice.Margin = new System.Windows.Forms.Padding(4);
            this.gvsellprice.MultiSelect = false;
            this.gvsellprice.Name = "gvsellprice";
            this.gvsellprice.ReadOnly = true;
            this.gvsellprice.RowHeadersVisible = false;
            this.gvsellprice.RowTemplate.Height = 30;
            this.gvsellprice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvsellprice.Size = new System.Drawing.Size(662, 202);
            this.gvsellprice.TabIndex = 15;
            this.gvsellprice.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvsellprice_CellContentDoubleClick);
            this.gvsellprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvsellprice_KeyDown);
            // 
            // warehouseid
            // 
            this.warehouseid.HeaderText = "warehouseid";
            this.warehouseid.Name = "warehouseid";
            this.warehouseid.ReadOnly = true;
            this.warehouseid.Visible = false;
            // 
            // itemid
            // 
            this.itemid.HeaderText = "itemid";
            this.itemid.Name = "itemid";
            this.itemid.ReadOnly = true;
            this.itemid.Visible = false;
            // 
            // sellid
            // 
            this.sellid.HeaderText = "sellid";
            this.sellid.Name = "sellid";
            this.sellid.ReadOnly = true;
            this.sellid.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ItemName.HeaderText = "Produk";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 78;
            // 
            // sellprice
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.sellprice.DefaultCellStyle = dataGridViewCellStyle2;
            this.sellprice.HeaderText = "Harga Jual (Rp)";
            this.sellprice.Name = "sellprice";
            this.sellprice.ReadOnly = true;
            // 
            // perUnit
            // 
            this.perUnit.HeaderText = "per Kemasan";
            this.perUnit.Name = "perUnit";
            this.perUnit.ReadOnly = true;
            // 
            // barcodeno
            // 
            this.barcodeno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barcodeno.HeaderText = "Nomor Barcode";
            this.barcodeno.Name = "barcodeno";
            this.barcodeno.ReadOnly = true;
            // 
            // btnnewprice
            // 
            this.btnnewprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnewprice.BackColor = System.Drawing.Color.Teal;
            this.btnnewprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewprice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewprice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnnewprice.Location = new System.Drawing.Point(10, 9);
            this.btnnewprice.Margin = new System.Windows.Forms.Padding(4);
            this.btnnewprice.Name = "btnnewprice";
            this.btnnewprice.Size = new System.Drawing.Size(189, 76);
            this.btnnewprice.TabIndex = 16;
            this.btnnewprice.Text = "Harga Baru\r\n(F1)\r\n";
            this.btnnewprice.UseVisualStyleBackColor = false;
            this.btnnewprice.Click += new System.EventHandler(this.btnnewprice_Click);
            // 
            // bteditprice
            // 
            this.bteditprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bteditprice.BackColor = System.Drawing.Color.Teal;
            this.bteditprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditprice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditprice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bteditprice.Location = new System.Drawing.Point(12, 9);
            this.bteditprice.Margin = new System.Windows.Forms.Padding(4);
            this.bteditprice.Name = "bteditprice";
            this.bteditprice.Size = new System.Drawing.Size(189, 76);
            this.bteditprice.TabIndex = 17;
            this.bteditprice.Text = "Edit Harga\r\n(F2)";
            this.bteditprice.UseVisualStyleBackColor = false;
            this.bteditprice.Click += new System.EventHandler(this.bteditprice_Click);
            // 
            // btndeleteprice
            // 
            this.btndeleteprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btndeleteprice.BackColor = System.Drawing.Color.Teal;
            this.btndeleteprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteprice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteprice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndeleteprice.Location = new System.Drawing.Point(13, 9);
            this.btndeleteprice.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteprice.Name = "btndeleteprice";
            this.btndeleteprice.Size = new System.Drawing.Size(190, 76);
            this.btndeleteprice.TabIndex = 18;
            this.btndeleteprice.Text = "Hapus Harga\r\n(F3)";
            this.btndeleteprice.UseVisualStyleBackColor = false;
            this.btndeleteprice.Click += new System.EventHandler(this.btndeleteprice_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 311);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 100);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnnewprice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 94);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bteditprice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(223, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 94);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btndeleteprice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(443, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 94);
            this.panel3.TabIndex = 2;
            // 
            // ManageSellingPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 434);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gvsellprice);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageSellingPrice";
            this.Text = "HaskaTech POS";
            this.Title = "Daftar Harga Jual";
            this.Load += new System.EventHandler(this.ManageSellingPrice_Load);
            this.Controls.SetChildIndex(this.gvsellprice, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvsellprice)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gvsellprice;
        private System.Windows.Forms.Button btnnewprice;
        private System.Windows.Forms.Button bteditprice;
        private System.Windows.Forms.Button btndeleteprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn perUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeno;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}