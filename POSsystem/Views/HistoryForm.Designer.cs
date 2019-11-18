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
            this.components = new System.ComponentModel.Container();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbdate = new System.Windows.Forms.Label();
            this.lbtime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvhistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbreset)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvhistory
            // 
            this.gvhistory.AllowUserToAddRows = false;
            this.gvhistory.AllowUserToDeleteRows = false;
            this.gvhistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvhistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSell,
            this.DatetimeSell,
            this.PayMode,
            this.oritotal,
            this.discount,
            this.TotalSell,
            this.RemarkSell});
            this.gvhistory.Location = new System.Drawing.Point(24, 249);
            this.gvhistory.Margin = new System.Windows.Forms.Padding(4);
            this.gvhistory.Name = "gvhistory";
            this.gvhistory.ReadOnly = true;
            this.gvhistory.RowHeadersVisible = false;
            this.gvhistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvhistory.Size = new System.Drawing.Size(664, 267);
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
            this.btpenjualanbaru.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btpenjualanbaru.BackColor = System.Drawing.Color.Teal;
            this.btpenjualanbaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btpenjualanbaru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpenjualanbaru.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btpenjualanbaru.Location = new System.Drawing.Point(4, 6);
            this.btpenjualanbaru.Margin = new System.Windows.Forms.Padding(4);
            this.btpenjualanbaru.Name = "btpenjualanbaru";
            this.btpenjualanbaru.Size = new System.Drawing.Size(147, 68);
            this.btpenjualanbaru.TabIndex = 1;
            this.btpenjualanbaru.Text = "Penjualan baru\r\n(F1)";
            this.btpenjualanbaru.UseVisualStyleBackColor = false;
            this.btpenjualanbaru.Click += new System.EventHandler(this.btpenjualanbaru_Click);
            // 
            // lb_datesearch
            // 
            this.lb_datesearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_datesearch.AutoSize = true;
            this.lb_datesearch.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_datesearch.Location = new System.Drawing.Point(8, 15);
            this.lb_datesearch.Name = "lb_datesearch";
            this.lb_datesearch.Size = new System.Drawing.Size(157, 22);
            this.lb_datesearch.TabIndex = 16;
            this.lb_datesearch.Text = "Tanggal penjualan";
            // 
            // lbpaymodesearch
            // 
            this.lbpaymodesearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpaymodesearch.AutoSize = true;
            this.lbpaymodesearch.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpaymodesearch.Location = new System.Drawing.Point(8, 11);
            this.lbpaymodesearch.Name = "lbpaymodesearch";
            this.lbpaymodesearch.Size = new System.Drawing.Size(152, 22);
            this.lbpaymodesearch.TabIndex = 18;
            this.lbpaymodesearch.Text = "Tipe pembayaran";
            // 
            // dtpfrom
            // 
            this.dtpfrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpfrom.CalendarFont = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfrom.CustomFormat = "";
            this.dtpfrom.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfrom.Location = new System.Drawing.Point(12, 40);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(183, 32);
            this.dtpfrom.TabIndex = 4;
            this.dtpfrom.Value = new System.DateTime(2019, 8, 30, 0, 0, 0, 0);
            this.dtpfrom.ValueChanged += new System.EventHandler(this.dtpfrom_ValueChanged);
            // 
            // dtpto
            // 
            this.dtpto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpto.CalendarFont = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpto.Checked = false;
            this.dtpto.CustomFormat = "";
            this.dtpto.Enabled = false;
            this.dtpto.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpto.Location = new System.Drawing.Point(9, 40);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(190, 32);
            this.dtpto.TabIndex = 5;
            this.dtpto.Value = new System.DateTime(2019, 8, 30, 0, 0, 0, 0);
            this.dtpto.ValueChanged += new System.EventHandler(this.dtpto_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "to";
            // 
            // cbpaymentmode
            // 
            this.cbpaymentmode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbpaymentmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpaymentmode.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpaymentmode.FormattingEnabled = true;
            this.cbpaymentmode.Location = new System.Drawing.Point(12, 36);
            this.cbpaymentmode.Name = "cbpaymentmode";
            this.cbpaymentmode.Size = new System.Drawing.Size(438, 40);
            this.cbpaymentmode.TabIndex = 3;
            this.cbpaymentmode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbpaymentmode_KeyDown);
            // 
            // tbtotalgv
            // 
            this.tbtotalgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtotalgv.Enabled = false;
            this.tbtotalgv.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotalgv.Location = new System.Drawing.Point(9, 17);
            this.tbtotalgv.Name = "tbtotalgv";
            this.tbtotalgv.ReadOnly = true;
            this.tbtotalgv.Size = new System.Drawing.Size(302, 49);
            this.tbtotalgv.TabIndex = 27;
            // 
            // btfinditem
            // 
            this.btfinditem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btfinditem.BackColor = System.Drawing.Color.Teal;
            this.btfinditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfinditem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfinditem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btfinditem.Location = new System.Drawing.Point(5, 6);
            this.btfinditem.Margin = new System.Windows.Forms.Padding(4);
            this.btfinditem.Name = "btfinditem";
            this.btfinditem.Size = new System.Drawing.Size(147, 68);
            this.btfinditem.TabIndex = 2;
            this.btfinditem.Text = "Cari Barang\r\n(F2)";
            this.btfinditem.UseVisualStyleBackColor = false;
            this.btfinditem.Click += new System.EventHandler(this.btfinditem_Click);
            // 
            // pbsearch
            // 
            this.pbsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbsearch.Image = global::POSsystem.Properties.Resources.search;
            this.pbsearch.Location = new System.Drawing.Point(6, 17);
            this.pbsearch.Name = "pbsearch";
            this.pbsearch.Size = new System.Drawing.Size(77, 63);
            this.pbsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbsearch.TabIndex = 30;
            this.pbsearch.TabStop = false;
            this.pbsearch.Click += new System.EventHandler(this.pbsearch_Click);
            // 
            // pbreset
            // 
            this.pbreset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbreset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbreset.Image = global::POSsystem.Properties.Resources.Refresh;
            this.pbreset.Location = new System.Drawing.Point(8, 17);
            this.pbreset.Name = "pbreset";
            this.pbreset.Size = new System.Drawing.Size(77, 63);
            this.pbreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbreset.TabIndex = 29;
            this.pbreset.TabStop = false;
            this.pbreset.Click += new System.EventHandler(this.pbreset_Click);
            // 
            // lbF3
            // 
            this.lbF3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbF3.AutoSize = true;
            this.lbF3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF3.ForeColor = System.Drawing.Color.DarkRed;
            this.lbF3.Location = new System.Drawing.Point(58, -1);
            this.lbF3.Name = "lbF3";
            this.lbF3.Size = new System.Drawing.Size(27, 19);
            this.lbF3.TabIndex = 31;
            this.lbF3.Text = "F3";
            // 
            // lbF4
            // 
            this.lbF4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbF4.AutoSize = true;
            this.lbF4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF4.ForeColor = System.Drawing.Color.DarkRed;
            this.lbF4.Location = new System.Drawing.Point(60, -1);
            this.lbF4.Name = "lbF4";
            this.lbF4.Size = new System.Drawing.Size(27, 19);
            this.lbF4.TabIndex = 32;
            this.lbF4.Text = "F4";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 523);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 86);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btpenjualanbaru);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 80);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btfinditem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(168, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 80);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbtotalgv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(333, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 80);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(24, 62);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(664, 180);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // panel4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel4, 3);
            this.panel4.Controls.Add(this.cbpaymentmode);
            this.panel4.Controls.Add(this.lbpaymodesearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 84);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpfrom);
            this.panel5.Controls.Add(this.lb_datesearch);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(206, 84);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(215, 93);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(33, 84);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtpto);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(254, 93);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(206, 84);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pbsearch);
            this.panel8.Controls.Add(this.lbF3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(466, 93);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(93, 84);
            this.panel8.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pbreset);
            this.panel9.Controls.Add(this.lbF4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(565, 93);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(96, 84);
            this.panel9.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.panel10, 2);
            this.panel10.Controls.Add(this.groupBox2);
            this.panel10.Location = new System.Drawing.Point(466, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(195, 84);
            this.panel10.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbdate);
            this.groupBox2.Controls.Add(this.lbtime);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 71);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // lbdate
            // 
            this.lbdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbdate.Location = new System.Drawing.Point(4, 40);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(172, 28);
            this.lbdate.TabIndex = 1;
            this.lbdate.Text = "date";
            this.lbdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbtime
            // 
            this.lbtime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbtime.Location = new System.Drawing.Point(4, 12);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(172, 28);
            this.lbtime.TabIndex = 0;
            this.lbtime.Text = "time";
            this.lbtime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 620);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gvhistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HistoryForm";
            this.Text = "HaskaTech POS";
            this.Title = "Riwayat Penjualan";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.Controls.SetChildIndex(this.gvhistory, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvhistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbreset)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Timer timer1;
    }
}