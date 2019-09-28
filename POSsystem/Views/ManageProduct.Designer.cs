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
            this.qtypercontainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btadditem = new System.Windows.Forms.Button();
            this.btedititem = new System.Windows.Forms.Button();
            this.btdeleteitem = new System.Windows.Forms.Button();
            this.btmanagebrand = new System.Windows.Forms.Button();
            this.btunitmanage = new System.Windows.Forms.Button();
            this.lb_itemsearch = new System.Windows.Forms.Label();
            this.tbitemname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btsearch = new System.Windows.Forms.Button();
            this.cbbrand = new System.Windows.Forms.ComboBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvitem)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvitem
            // 
            this.gvitem.AllowUserToAddRows = false;
            this.gvitem.AllowUserToDeleteRows = false;
            this.gvitem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Brand,
            this.itemname,
            this.unit_bulk,
            this.unit_pcs,
            this.TotalStock,
            this.qtypercontainer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvitem.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvitem.Location = new System.Drawing.Point(29, 158);
            this.gvitem.Margin = new System.Windows.Forms.Padding(4);
            this.gvitem.MultiSelect = false;
            this.gvitem.Name = "gvitem";
            this.gvitem.ReadOnly = true;
            this.gvitem.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvitem.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvitem.RowTemplate.Height = 32;
            this.gvitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvitem.Size = new System.Drawing.Size(827, 342);
            this.gvitem.TabIndex = 0;
            this.gvitem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvitem_CellDoubleClick);
            this.gvitem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvitem_KeyDown);
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
            this.Brand.FillWeight = 200F;
            this.Brand.HeaderText = "Merek";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 200;
            // 
            // itemname
            // 
            this.itemname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemname.DefaultCellStyle = dataGridViewCellStyle1;
            this.itemname.HeaderText = "Nama Produk";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            // 
            // unit_bulk
            // 
            this.unit_bulk.HeaderText = "Kemasan Borong";
            this.unit_bulk.Name = "unit_bulk";
            this.unit_bulk.ReadOnly = true;
            this.unit_bulk.Visible = false;
            // 
            // unit_pcs
            // 
            this.unit_pcs.HeaderText = "Kemasan Eceran";
            this.unit_pcs.Name = "unit_pcs";
            this.unit_pcs.ReadOnly = true;
            this.unit_pcs.Visible = false;
            // 
            // TotalStock
            // 
            this.TotalStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalStock.HeaderText = "Stok";
            this.TotalStock.Name = "TotalStock";
            this.TotalStock.ReadOnly = true;
            this.TotalStock.Width = 61;
            // 
            // qtypercontainer
            // 
            this.qtypercontainer.HeaderText = "qtypercontainer";
            this.qtypercontainer.Name = "qtypercontainer";
            this.qtypercontainer.ReadOnly = true;
            this.qtypercontainer.Visible = false;
            // 
            // btadditem
            // 
            this.btadditem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btadditem.BackColor = System.Drawing.Color.Teal;
            this.btadditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btadditem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadditem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btadditem.Location = new System.Drawing.Point(4, 4);
            this.btadditem.Margin = new System.Windows.Forms.Padding(4);
            this.btadditem.Name = "btadditem";
            this.btadditem.Size = new System.Drawing.Size(151, 86);
            this.btadditem.TabIndex = 1;
            this.btadditem.Text = "Tambah Produk\r\n(F5)\r\n";
            this.btadditem.UseVisualStyleBackColor = false;
            this.btadditem.Click += new System.EventHandler(this.btadditem_Click);
            // 
            // btedititem
            // 
            this.btedititem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btedititem.BackColor = System.Drawing.Color.Teal;
            this.btedititem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btedititem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedititem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btedititem.Location = new System.Drawing.Point(4, 4);
            this.btedititem.Margin = new System.Windows.Forms.Padding(4);
            this.btedititem.Name = "btedititem";
            this.btedititem.Size = new System.Drawing.Size(151, 86);
            this.btedititem.TabIndex = 2;
            this.btedititem.Text = "Edit Produk \r\n(F6)";
            this.btedititem.UseVisualStyleBackColor = false;
            this.btedititem.Click += new System.EventHandler(this.btedititem_Click);
            // 
            // btdeleteitem
            // 
            this.btdeleteitem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btdeleteitem.BackColor = System.Drawing.Color.Teal;
            this.btdeleteitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeleteitem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeleteitem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdeleteitem.Location = new System.Drawing.Point(4, 4);
            this.btdeleteitem.Margin = new System.Windows.Forms.Padding(4);
            this.btdeleteitem.Name = "btdeleteitem";
            this.btdeleteitem.Size = new System.Drawing.Size(151, 86);
            this.btdeleteitem.TabIndex = 3;
            this.btdeleteitem.Text = "Hapus Produk\r\n(F7)";
            this.btdeleteitem.UseVisualStyleBackColor = false;
            this.btdeleteitem.Click += new System.EventHandler(this.btdeleteitem_Click);
            // 
            // btmanagebrand
            // 
            this.btmanagebrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmanagebrand.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btmanagebrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmanagebrand.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmanagebrand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btmanagebrand.Location = new System.Drawing.Point(4, 4);
            this.btmanagebrand.Margin = new System.Windows.Forms.Padding(4);
            this.btmanagebrand.Name = "btmanagebrand";
            this.btmanagebrand.Size = new System.Drawing.Size(151, 86);
            this.btmanagebrand.TabIndex = 4;
            this.btmanagebrand.Text = "Edit Merek\r\n(F8)";
            this.btmanagebrand.UseVisualStyleBackColor = false;
            this.btmanagebrand.Click += new System.EventHandler(this.btunitmanagement_Click);
            // 
            // btunitmanage
            // 
            this.btunitmanage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btunitmanage.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btunitmanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btunitmanage.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btunitmanage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btunitmanage.Location = new System.Drawing.Point(6, 4);
            this.btunitmanage.Margin = new System.Windows.Forms.Padding(4);
            this.btunitmanage.Name = "btunitmanage";
            this.btunitmanage.Size = new System.Drawing.Size(151, 86);
            this.btunitmanage.TabIndex = 5;
            this.btunitmanage.Text = "Edit Kemasan\r\n(F9)";
            this.btunitmanage.UseVisualStyleBackColor = false;
            this.btunitmanage.Click += new System.EventHandler(this.btunitmanage_Click);
            // 
            // lb_itemsearch
            // 
            this.lb_itemsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_itemsearch.AutoSize = true;
            this.lb_itemsearch.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_itemsearch.Location = new System.Drawing.Point(2, 10);
            this.lb_itemsearch.Name = "lb_itemsearch";
            this.lb_itemsearch.Size = new System.Drawing.Size(122, 22);
            this.lb_itemsearch.TabIndex = 11;
            this.lb_itemsearch.Text = "Nama Produk";
            // 
            // tbitemname
            // 
            this.tbitemname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbitemname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbitemname.Location = new System.Drawing.Point(6, 35);
            this.tbitemname.Name = "tbitemname";
            this.tbitemname.Size = new System.Drawing.Size(264, 32);
            this.tbitemname.TabIndex = 6;
            this.tbitemname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbitemname_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Merek";
            // 
            // btsearch
            // 
            this.btsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btsearch.BackColor = System.Drawing.Color.Goldenrod;
            this.btsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsearch.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btsearch.Location = new System.Drawing.Point(4, 4);
            this.btsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(107, 73);
            this.btsearch.TabIndex = 8;
            this.btsearch.Text = "Cari (F3)";
            this.btsearch.UseVisualStyleBackColor = false;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // cbbrand
            // 
            this.cbbrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbrand.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbrand.FormattingEnabled = true;
            this.cbbrand.Location = new System.Drawing.Point(8, 34);
            this.cbbrand.Name = "cbbrand";
            this.cbbrand.Size = new System.Drawing.Size(264, 33);
            this.cbbrand.TabIndex = 7;
            // 
            // btnreset
            // 
            this.btnreset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreset.BackColor = System.Drawing.Color.Goldenrod;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnreset.Location = new System.Drawing.Point(6, 4);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(107, 73);
            this.btnreset.TabIndex = 9;
            this.btnreset.Text = "Reset (F4)";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 521);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(827, 100);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btadditem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 94);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btedititem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(168, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 94);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btdeleteitem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(333, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 94);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btmanagebrand);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(498, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 94);
            this.panel4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(-487, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tambah Produk\r\n(F5)\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btadditem_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btunitmanage);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(663, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(161, 94);
            this.panel5.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(26, 49);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(827, 87);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbitemname);
            this.panel6.Controls.Add(this.lb_itemsearch);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(283, 81);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbbrand);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(292, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(283, 81);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btsearch);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(581, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(118, 81);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnreset);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(705, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(119, 81);
            this.panel9.TabIndex = 3;
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 639);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gvitem);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageProduct";
            this.Text = "HaskaTech POS";
            this.Title = "Daftar Produk";
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            this.Controls.SetChildIndex(this.gvitem, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvitem)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvitem;
        private System.Windows.Forms.Button btadditem;
        private System.Windows.Forms.Button btedititem;
        private System.Windows.Forms.Button btdeleteitem;
        private System.Windows.Forms.Button btmanagebrand;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn qtypercontainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button1;
    }
}