namespace POSsystem
{
    partial class ManageProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvitem = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_bulk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_pcs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btadditem = new System.Windows.Forms.Button();
            this.btedititem = new System.Windows.Forms.Button();
            this.btdeleteitem = new System.Windows.Forms.Button();
            this.btunitmanagement = new System.Windows.Forms.Button();
            this.btunitmanage = new System.Windows.Forms.Button();
            this.lb_itemsearch = new System.Windows.Forms.Label();
            this.tbitemname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btsearch = new System.Windows.Forms.Button();
            this.cbbrand = new System.Windows.Forms.ComboBox();
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvitem)).BeginInit();
            this.SuspendLayout();
            // 
            // gvitem
            // 
            this.gvitem.AllowUserToAddRows = false;
            this.gvitem.AllowUserToDeleteRows = false;
            this.gvitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Brand,
            this.itemname,
            this.unit_bulk,
            this.unit_pcs,
            this.TotalStock});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvitem.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvitem.Location = new System.Drawing.Point(29, 252);
            this.gvitem.Margin = new System.Windows.Forms.Padding(4);
            this.gvitem.MultiSelect = false;
            this.gvitem.Name = "gvitem";
            this.gvitem.ReadOnly = true;
            this.gvitem.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvitem.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvitem.RowTemplate.Height = 32;
            this.gvitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvitem.Size = new System.Drawing.Size(833, 193);
            this.gvitem.TabIndex = 0;
            this.gvitem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvitem_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Brand.HeaderText = "Merek";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 72;
            // 
            // itemname
            // 
            this.itemname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemname.DefaultCellStyle = dataGridViewCellStyle1;
            this.itemname.HeaderText = "Nama Barang";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            // 
            // unit_bulk
            // 
            this.unit_bulk.HeaderText = "Kemasan Borong";
            this.unit_bulk.Name = "unit_bulk";
            this.unit_bulk.ReadOnly = true;
            // 
            // unit_pcs
            // 
            this.unit_pcs.HeaderText = "Kemasan Eceran";
            this.unit_pcs.Name = "unit_pcs";
            this.unit_pcs.ReadOnly = true;
            // 
            // TotalStock
            // 
            this.TotalStock.HeaderText = "Stok";
            this.TotalStock.Name = "TotalStock";
            this.TotalStock.ReadOnly = true;
            // 
            // btadditem
            // 
            this.btadditem.BackColor = System.Drawing.Color.Teal;
            this.btadditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btadditem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadditem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btadditem.Location = new System.Drawing.Point(29, 460);
            this.btadditem.Margin = new System.Windows.Forms.Padding(4);
            this.btadditem.Name = "btadditem";
            this.btadditem.Size = new System.Drawing.Size(150, 53);
            this.btadditem.TabIndex = 2;
            this.btadditem.Text = "Tambah Produk";
            this.btadditem.UseVisualStyleBackColor = false;
            this.btadditem.Click += new System.EventHandler(this.btadditem_Click);
            // 
            // btedititem
            // 
            this.btedititem.BackColor = System.Drawing.Color.Teal;
            this.btedititem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btedititem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedititem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btedititem.Location = new System.Drawing.Point(369, 460);
            this.btedititem.Margin = new System.Windows.Forms.Padding(4);
            this.btedititem.Name = "btedititem";
            this.btedititem.Size = new System.Drawing.Size(150, 53);
            this.btedititem.TabIndex = 3;
            this.btedititem.Text = "Edit Produk";
            this.btedititem.UseVisualStyleBackColor = false;
            this.btedititem.Click += new System.EventHandler(this.btedititem_Click);
            // 
            // btdeleteitem
            // 
            this.btdeleteitem.BackColor = System.Drawing.Color.Teal;
            this.btdeleteitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeleteitem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeleteitem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdeleteitem.Location = new System.Drawing.Point(199, 460);
            this.btdeleteitem.Margin = new System.Windows.Forms.Padding(4);
            this.btdeleteitem.Name = "btdeleteitem";
            this.btdeleteitem.Size = new System.Drawing.Size(150, 53);
            this.btdeleteitem.TabIndex = 4;
            this.btdeleteitem.Text = "Hapus Produk";
            this.btdeleteitem.UseVisualStyleBackColor = false;
            this.btdeleteitem.Click += new System.EventHandler(this.btdeleteitem_Click);
            // 
            // btunitmanagement
            // 
            this.btunitmanagement.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btunitmanagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btunitmanagement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunitmanagement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btunitmanagement.Location = new System.Drawing.Point(709, 460);
            this.btunitmanagement.Margin = new System.Windows.Forms.Padding(4);
            this.btunitmanagement.Name = "btunitmanagement";
            this.btunitmanagement.Size = new System.Drawing.Size(151, 53);
            this.btunitmanagement.TabIndex = 5;
            this.btunitmanagement.Text = "Edit Merek";
            this.btunitmanagement.UseVisualStyleBackColor = false;
            this.btunitmanagement.Click += new System.EventHandler(this.btunitmanagement_Click);
            // 
            // btunitmanage
            // 
            this.btunitmanage.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btunitmanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btunitmanage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunitmanage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btunitmanage.Location = new System.Drawing.Point(539, 460);
            this.btunitmanage.Margin = new System.Windows.Forms.Padding(4);
            this.btunitmanage.Name = "btunitmanage";
            this.btunitmanage.Size = new System.Drawing.Size(150, 53);
            this.btunitmanage.TabIndex = 9;
            this.btunitmanage.Text = "Edit Kemasan";
            this.btunitmanage.UseVisualStyleBackColor = false;
            this.btunitmanage.Click += new System.EventHandler(this.btunitmanage_Click);
            // 
            // lb_itemsearch
            // 
            this.lb_itemsearch.AutoSize = true;
            this.lb_itemsearch.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_itemsearch.Location = new System.Drawing.Point(24, 86);
            this.lb_itemsearch.Name = "lb_itemsearch";
            this.lb_itemsearch.Size = new System.Drawing.Size(132, 25);
            this.lb_itemsearch.TabIndex = 11;
            this.lb_itemsearch.Text = "Nama Barang";
            // 
            // tbitemname
            // 
            this.tbitemname.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbitemname.Location = new System.Drawing.Point(29, 114);
            this.tbitemname.Name = "tbitemname";
            this.tbitemname.Size = new System.Drawing.Size(415, 39);
            this.tbitemname.TabIndex = 12;
            this.tbitemname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbitemname_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Merek";
            // 
            // btsearch
            // 
            this.btsearch.BackColor = System.Drawing.Color.Goldenrod;
            this.btsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btsearch.Location = new System.Drawing.Point(650, 96);
            this.btsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(212, 53);
            this.btsearch.TabIndex = 15;
            this.btsearch.Text = "Cari";
            this.btsearch.UseVisualStyleBackColor = false;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // cbbrand
            // 
            this.cbbrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbrand.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbrand.FormattingEnabled = true;
            this.cbbrand.Location = new System.Drawing.Point(29, 192);
            this.cbbrand.Name = "cbbrand";
            this.cbbrand.Size = new System.Drawing.Size(415, 40);
            this.cbbrand.TabIndex = 16;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Goldenrod;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnreset.Location = new System.Drawing.Point(650, 179);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(212, 53);
            this.btnreset.TabIndex = 15;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 526);
            this.Controls.Add(this.cbbrand);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbitemname);
            this.Controls.Add(this.lb_itemsearch);
            this.Controls.Add(this.btunitmanage);
            this.Controls.Add(this.btunitmanagement);
            this.Controls.Add(this.btdeleteitem);
            this.Controls.Add(this.btedititem);
            this.Controls.Add(this.btadditem);
            this.Controls.Add(this.gvitem);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageProduct";
            this.Text = "HaskaTech POS";
            this.Title = "Daftar Produk";
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            this.Controls.SetChildIndex(this.gvitem, 0);
            this.Controls.SetChildIndex(this.btadditem, 0);
            this.Controls.SetChildIndex(this.btedititem, 0);
            this.Controls.SetChildIndex(this.btdeleteitem, 0);
            this.Controls.SetChildIndex(this.btunitmanagement, 0);
            this.Controls.SetChildIndex(this.btunitmanage, 0);
            this.Controls.SetChildIndex(this.lb_itemsearch, 0);
            this.Controls.SetChildIndex(this.tbitemname, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btsearch, 0);
            this.Controls.SetChildIndex(this.btnreset, 0);
            this.Controls.SetChildIndex(this.cbbrand, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvitem;
        private System.Windows.Forms.Button btadditem;
        private System.Windows.Forms.Button btedititem;
        private System.Windows.Forms.Button btdeleteitem;
        private System.Windows.Forms.Button btunitmanagement;
        private System.Windows.Forms.Button btunitmanage;
        private System.Windows.Forms.Label lb_itemsearch;
        private System.Windows.Forms.TextBox tbitemname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.ComboBox cbbrand;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_bulk;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_pcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalStock;
    }
}