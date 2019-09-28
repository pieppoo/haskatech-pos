namespace POSsystem.Views
{
    partial class POSSalesEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSSalesEntry));
            this.gvsales = new System.Windows.Forms.DataGridView();
            this.salesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtysale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcsprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oritotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalsale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btpay = new System.Windows.Forms.Button();
            this.btnewsale = new System.Windows.Forms.Button();
            this.lbbarcode = new System.Windows.Forms.Label();
            this.lbitemname = new System.Windows.Forms.Label();
            this.tbitemname = new System.Windows.Forms.TextBox();
            this.lbpay = new System.Windows.Forms.Label();
            this.lbtotaltopay = new System.Windows.Forms.Label();
            this.tbtotaltopay = new System.Windows.Forms.TextBox();
            this.tbpay = new System.Windows.Forms.TextBox();
            this.lbbalance = new System.Windows.Forms.Label();
            this.tbbalance = new System.Windows.Forms.TextBox();
            this.lbdiscount = new System.Windows.Forms.Label();
            this.lboritotal = new System.Windows.Forms.Label();
            this.tboritotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbdiscount = new System.Windows.Forms.TextBox();
            this.tbbarcodeno = new System.Windows.Forms.TextBox();
            this.btdelete = new System.Windows.Forms.Button();
            this.iconsearch = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvsales)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconsearch)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvsales
            // 
            this.gvsales.AllowUserToAddRows = false;
            this.gvsales.AllowUserToDeleteRows = false;
            this.gvsales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvsales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvsales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesId,
            this.Itemname,
            this.qtysale,
            this.unitsale,
            this.pcsprice,
            this.oritotal,
            this.discount,
            this.totalsale,
            this.item_id,
            this.unitcode});
            this.gvsales.Location = new System.Drawing.Point(23, 113);
            this.gvsales.MultiSelect = false;
            this.gvsales.Name = "gvsales";
            this.gvsales.RowHeadersVisible = false;
            this.gvsales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvsales.Size = new System.Drawing.Size(651, 395);
            this.gvsales.TabIndex = 11;
            this.gvsales.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvsales_CellEndEdit);
            this.gvsales.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gvsales_CellValidating);
            // 
            // salesId
            // 
            this.salesId.HeaderText = "salesId";
            this.salesId.Name = "salesId";
            this.salesId.Visible = false;
            // 
            // Itemname
            // 
            this.Itemname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Itemname.DefaultCellStyle = dataGridViewCellStyle2;
            this.Itemname.FillWeight = 75F;
            this.Itemname.HeaderText = "Nama Barang";
            this.Itemname.Name = "Itemname";
            this.Itemname.ReadOnly = true;
            // 
            // qtysale
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qtysale.DefaultCellStyle = dataGridViewCellStyle3;
            this.qtysale.FillWeight = 50F;
            this.qtysale.HeaderText = "Jumlah";
            this.qtysale.Name = "qtysale";
            this.qtysale.Width = 50;
            // 
            // unitsale
            // 
            this.unitsale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unitsale.DefaultCellStyle = dataGridViewCellStyle4;
            this.unitsale.FillWeight = 25F;
            this.unitsale.HeaderText = "Kemasan";
            this.unitsale.Name = "unitsale";
            this.unitsale.ReadOnly = true;
            // 
            // pcsprice
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pcsprice.DefaultCellStyle = dataGridViewCellStyle5;
            this.pcsprice.FillWeight = 85F;
            this.pcsprice.HeaderText = "Harga satuan";
            this.pcsprice.Name = "pcsprice";
            this.pcsprice.ReadOnly = true;
            this.pcsprice.Width = 85;
            // 
            // oritotal
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.oritotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.oritotal.FillWeight = 85F;
            this.oritotal.HeaderText = "Total Awal";
            this.oritotal.Name = "oritotal";
            this.oritotal.ReadOnly = true;
            this.oritotal.Width = 85;
            // 
            // discount
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.discount.DefaultCellStyle = dataGridViewCellStyle7;
            this.discount.FillWeight = 85F;
            this.discount.HeaderText = "Diskon";
            this.discount.Name = "discount";
            this.discount.Width = 85;
            // 
            // totalsale
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totalsale.DefaultCellStyle = dataGridViewCellStyle8;
            this.totalsale.FillWeight = 85F;
            this.totalsale.HeaderText = "Total Akhir";
            this.totalsale.Name = "totalsale";
            this.totalsale.ReadOnly = true;
            this.totalsale.Width = 85;
            // 
            // item_id
            // 
            this.item_id.HeaderText = "item_id";
            this.item_id.Name = "item_id";
            this.item_id.Visible = false;
            // 
            // unitcode
            // 
            this.unitcode.HeaderText = "unitcode";
            this.unitcode.Name = "unitcode";
            this.unitcode.Visible = false;
            // 
            // btpay
            // 
            this.btpay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btpay.BackColor = System.Drawing.Color.Teal;
            this.btpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btpay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btpay.Location = new System.Drawing.Point(10, 7);
            this.btpay.Margin = new System.Windows.Forms.Padding(4);
            this.btpay.Name = "btpay";
            this.btpay.Size = new System.Drawing.Size(201, 56);
            this.btpay.TabIndex = 4;
            this.btpay.Text = "BAYAR\r\n(F5)";
            this.btpay.UseVisualStyleBackColor = false;
            this.btpay.Click += new System.EventHandler(this.btpay_Click);
            // 
            // btnewsale
            // 
            this.btnewsale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnewsale.BackColor = System.Drawing.Color.Teal;
            this.btnewsale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnewsale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnewsale.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnewsale.Location = new System.Drawing.Point(8, 7);
            this.btnewsale.Margin = new System.Windows.Forms.Padding(4);
            this.btnewsale.Name = "btnewsale";
            this.btnewsale.Size = new System.Drawing.Size(201, 56);
            this.btnewsale.TabIndex = 2;
            this.btnewsale.Text = "PENJUALAN BARU \r\n(F3)";
            this.btnewsale.UseVisualStyleBackColor = false;
            this.btnewsale.Click += new System.EventHandler(this.btnewsale_Click);
            // 
            // lbbarcode
            // 
            this.lbbarcode.AutoSize = true;
            this.lbbarcode.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbarcode.Location = new System.Drawing.Point(8, 3);
            this.lbbarcode.Name = "lbbarcode";
            this.lbbarcode.Size = new System.Drawing.Size(120, 25);
            this.lbbarcode.TabIndex = 12;
            this.lbbarcode.Text = "No. Barcode";
            // 
            // lbitemname
            // 
            this.lbitemname.AutoSize = true;
            this.lbitemname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbitemname.Location = new System.Drawing.Point(6, 3);
            this.lbitemname.Name = "lbitemname";
            this.lbitemname.Size = new System.Drawing.Size(122, 25);
            this.lbitemname.TabIndex = 13;
            this.lbitemname.Text = "Nama Brang";
            // 
            // tbitemname
            // 
            this.tbitemname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbitemname.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbitemname.Location = new System.Drawing.Point(11, 30);
            this.tbitemname.Name = "tbitemname";
            this.tbitemname.Size = new System.Drawing.Size(261, 30);
            this.tbitemname.TabIndex = 1;
            this.tbitemname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbitemname_KeyDown);
            // 
            // lbpay
            // 
            this.lbpay.AutoSize = true;
            this.lbpay.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpay.Location = new System.Drawing.Point(6, 268);
            this.lbpay.Name = "lbpay";
            this.lbpay.Size = new System.Drawing.Size(65, 25);
            this.lbpay.TabIndex = 17;
            this.lbpay.Text = "Bayar";
            // 
            // lbtotaltopay
            // 
            this.lbtotaltopay.AutoSize = true;
            this.lbtotaltopay.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotaltopay.Location = new System.Drawing.Point(6, 160);
            this.lbtotaltopay.Name = "lbtotaltopay";
            this.lbtotaltopay.Size = new System.Drawing.Size(128, 25);
            this.lbtotaltopay.TabIndex = 16;
            this.lbtotaltopay.Text = "Total Belanja";
            // 
            // tbtotaltopay
            // 
            this.tbtotaltopay.Enabled = false;
            this.tbtotaltopay.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotaltopay.Location = new System.Drawing.Point(11, 188);
            this.tbtotaltopay.Multiline = true;
            this.tbtotaltopay.Name = "tbtotaltopay";
            this.tbtotaltopay.ReadOnly = true;
            this.tbtotaltopay.Size = new System.Drawing.Size(146, 55);
            this.tbtotaltopay.TabIndex = 8;
            this.tbtotaltopay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbpay
            // 
            this.tbpay.Enabled = false;
            this.tbpay.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpay.Location = new System.Drawing.Point(11, 296);
            this.tbpay.Name = "tbpay";
            this.tbpay.ReadOnly = true;
            this.tbpay.Size = new System.Drawing.Size(146, 36);
            this.tbpay.TabIndex = 9;
            this.tbpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbbalance
            // 
            this.lbbalance.AutoSize = true;
            this.lbbalance.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbalance.Location = new System.Drawing.Point(6, 364);
            this.lbbalance.Name = "lbbalance";
            this.lbbalance.Size = new System.Drawing.Size(108, 25);
            this.lbbalance.TabIndex = 18;
            this.lbbalance.Text = "Kembalian";
            // 
            // tbbalance
            // 
            this.tbbalance.Enabled = false;
            this.tbbalance.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbalance.Location = new System.Drawing.Point(11, 392);
            this.tbbalance.Name = "tbbalance";
            this.tbbalance.ReadOnly = true;
            this.tbbalance.Size = new System.Drawing.Size(146, 36);
            this.tbbalance.TabIndex = 10;
            this.tbbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbdiscount
            // 
            this.lbdiscount.AutoSize = true;
            this.lbdiscount.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiscount.Location = new System.Drawing.Point(6, 84);
            this.lbdiscount.Name = "lbdiscount";
            this.lbdiscount.Size = new System.Drawing.Size(75, 25);
            this.lbdiscount.TabIndex = 15;
            this.lbdiscount.Text = "Diskon";
            // 
            // lboritotal
            // 
            this.lboritotal.AutoSize = true;
            this.lboritotal.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboritotal.Location = new System.Drawing.Point(6, 16);
            this.lboritotal.Name = "lboritotal";
            this.lboritotal.Size = new System.Drawing.Size(151, 25);
            this.lboritotal.TabIndex = 14;
            this.lboritotal.Text = "Total Awal (Rp)";
            // 
            // tboritotal
            // 
            this.tboritotal.Enabled = false;
            this.tboritotal.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboritotal.Location = new System.Drawing.Point(11, 45);
            this.tboritotal.Name = "tboritotal";
            this.tboritotal.ReadOnly = true;
            this.tboritotal.Size = new System.Drawing.Size(146, 36);
            this.tboritotal.TabIndex = 6;
            this.tboritotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbdiscount);
            this.groupBox1.Controls.Add(this.tboritotal);
            this.groupBox1.Controls.Add(this.lboritotal);
            this.groupBox1.Controls.Add(this.lbdiscount);
            this.groupBox1.Controls.Add(this.tbbalance);
            this.groupBox1.Controls.Add(this.lbbalance);
            this.groupBox1.Controls.Add(this.tbpay);
            this.groupBox1.Controls.Add(this.tbtotaltopay);
            this.groupBox1.Controls.Add(this.lbtotaltopay);
            this.groupBox1.Controls.Add(this.lbpay);
            this.groupBox1.Location = new System.Drawing.Point(692, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 495);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // tbdiscount
            // 
            this.tbdiscount.Enabled = false;
            this.tbdiscount.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdiscount.Location = new System.Drawing.Point(11, 112);
            this.tbdiscount.Name = "tbdiscount";
            this.tbdiscount.ReadOnly = true;
            this.tbdiscount.Size = new System.Drawing.Size(146, 36);
            this.tbdiscount.TabIndex = 7;
            this.tbdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbbarcodeno
            // 
            this.tbbarcodeno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbbarcodeno.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbarcodeno.Location = new System.Drawing.Point(8, 30);
            this.tbbarcodeno.Name = "tbbarcodeno";
            this.tbbarcodeno.Size = new System.Drawing.Size(265, 30);
            this.tbbarcodeno.TabIndex = 0;
            this.tbbarcodeno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbbarcodeno_KeyDown);
            this.tbbarcodeno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbbarcodeno_KeyPress);
            // 
            // btdelete
            // 
            this.btdelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btdelete.BackColor = System.Drawing.Color.Teal;
            this.btdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdelete.Location = new System.Drawing.Point(7, 7);
            this.btdelete.Margin = new System.Windows.Forms.Padding(4);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(201, 56);
            this.btdelete.TabIndex = 5;
            this.btdelete.Text = "HAPUS\r\n(F4)";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // iconsearch
            // 
            this.iconsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconsearch.Image = global::POSsystem.Properties.Resources.search;
            this.iconsearch.Location = new System.Drawing.Point(9, 12);
            this.iconsearch.Name = "iconsearch";
            this.iconsearch.Size = new System.Drawing.Size(73, 47);
            this.iconsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconsearch.TabIndex = 31;
            this.iconsearch.TabStop = false;
            this.iconsearch.Click += new System.EventHandler(this.iconsearch_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 514);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 75);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnewsale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 69);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btdelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(227, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 69);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btpay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(451, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 69);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(671, 74);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbbarcodeno);
            this.panel4.Controls.Add(this.lbbarcode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 68);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbitemname);
            this.panel5.Controls.Add(this.tbitemname);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(291, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 68);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.iconsearch);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(579, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(89, 68);
            this.panel6.TabIndex = 2;
            // 
            // POSSalesEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 613);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvsales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POSSalesEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HaskaTech POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POSSalesEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvsales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconsearch)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvsales;
        private System.Windows.Forms.Button btpay;
        private System.Windows.Forms.Button btnewsale;
        private System.Windows.Forms.Label lbbarcode;
        private System.Windows.Forms.Label lbitemname;
        private System.Windows.Forms.TextBox tbitemname;
        private System.Windows.Forms.PictureBox iconsearch;
        private System.Windows.Forms.Label lbpay;
        private System.Windows.Forms.Label lbtotaltopay;
        private System.Windows.Forms.TextBox tbtotaltopay;
        private System.Windows.Forms.TextBox tbpay;
        private System.Windows.Forms.Label lbbalance;
        private System.Windows.Forms.TextBox tbbalance;
        private System.Windows.Forms.Label lbdiscount;
        private System.Windows.Forms.Label lboritotal;
        private System.Windows.Forms.TextBox tboritotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbbarcodeno;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.TextBox tbdiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtysale;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsale;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcsprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn oritotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalsale;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitcode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}