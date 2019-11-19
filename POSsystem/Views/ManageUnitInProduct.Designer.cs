namespace POSsystem.Views
{
    partial class ManageUnitInProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUnitInProduct));
            this.gvunitlist = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seq_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbitemname = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btchangerelation = new System.Windows.Forms.Button();
            this.lbunitrelation = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btmanageunit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btaddunit = new System.Windows.Forms.Button();
            this.bteditunit = new System.Windows.Forms.Button();
            this.btdeleteunit = new System.Windows.Forms.Button();
            this.cbseq = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btdeleteall = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvunitlist)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvunitlist
            // 
            this.gvunitlist.AllowUserToAddRows = false;
            this.gvunitlist.AllowUserToDeleteRows = false;
            this.gvunitlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvunitlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvunitlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.itemid,
            this.seq_no,
            this.unit,
            this.qty,
            this.isPCS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvunitlist.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvunitlist.Location = new System.Drawing.Point(13, 130);
            this.gvunitlist.Margin = new System.Windows.Forms.Padding(4);
            this.gvunitlist.MultiSelect = false;
            this.gvunitlist.Name = "gvunitlist";
            this.gvunitlist.ReadOnly = true;
            this.gvunitlist.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvunitlist.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvunitlist.RowTemplate.Height = 32;
            this.gvunitlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvunitlist.Size = new System.Drawing.Size(716, 261);
            this.gvunitlist.TabIndex = 11;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // itemid
            // 
            this.itemid.HeaderText = "itemid";
            this.itemid.Name = "itemid";
            this.itemid.ReadOnly = true;
            this.itemid.Visible = false;
            // 
            // seq_no
            // 
            this.seq_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.seq_no.HeaderText = "No urut";
            this.seq_no.Name = "seq_no";
            this.seq_no.ReadOnly = true;
            this.seq_no.Width = 74;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.FillWeight = 200F;
            this.unit.HeaderText = "Kemasan";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Jumlah";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // isPCS
            // 
            this.isPCS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.isPCS.DefaultCellStyle = dataGridViewCellStyle1;
            this.isPCS.HeaderText = "Kemasan Eceran?";
            this.isPCS.Name = "isPCS";
            this.isPCS.ReadOnly = true;
            // 
            // lbitemname
            // 
            this.lbitemname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbitemname.AutoSize = true;
            this.lbitemname.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbitemname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbitemname.Location = new System.Drawing.Point(4, 4);
            this.lbitemname.Name = "lbitemname";
            this.lbitemname.Size = new System.Drawing.Size(234, 43);
            this.lbitemname.TabIndex = 12;
            this.lbitemname.Text = "Nama Produk";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 74);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbitemname);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 68);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btchangerelation);
            this.panel2.Controls.Add(this.lbunitrelation);
            this.panel2.Location = new System.Drawing.Point(361, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 68);
            this.panel2.TabIndex = 1;
            // 
            // btchangerelation
            // 
            this.btchangerelation.FlatAppearance.BorderSize = 0;
            this.btchangerelation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btchangerelation.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchangerelation.ForeColor = System.Drawing.Color.MediumBlue;
            this.btchangerelation.Location = new System.Drawing.Point(4, 35);
            this.btchangerelation.Name = "btchangerelation";
            this.btchangerelation.Size = new System.Drawing.Size(109, 28);
            this.btchangerelation.TabIndex = 19;
            this.btchangerelation.Text = "Tukar (F6)";
            this.btchangerelation.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btchangerelation.UseVisualStyleBackColor = true;
            this.btchangerelation.Click += new System.EventHandler(this.btchangerelation_Click);
            // 
            // lbunitrelation
            // 
            this.lbunitrelation.AutoSize = true;
            this.lbunitrelation.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitrelation.Location = new System.Drawing.Point(4, 10);
            this.lbunitrelation.Name = "lbunitrelation";
            this.lbunitrelation.Size = new System.Drawing.Size(133, 22);
            this.lbunitrelation.TabIndex = 13;
            this.lbunitrelation.Text = "Unit berkaitan?";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.btmanageunit);
            this.panel9.Location = new System.Drawing.Point(576, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(138, 68);
            this.panel9.TabIndex = 2;
            // 
            // btmanageunit
            // 
            this.btmanageunit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmanageunit.BackColor = System.Drawing.Color.Purple;
            this.btmanageunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmanageunit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmanageunit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btmanageunit.Location = new System.Drawing.Point(7, 6);
            this.btmanageunit.Margin = new System.Windows.Forms.Padding(4);
            this.btmanageunit.Name = "btmanageunit";
            this.btmanageunit.Size = new System.Drawing.Size(127, 57);
            this.btmanageunit.TabIndex = 18;
            this.btmanageunit.Text = "Pengaturan Kemasan (F5)";
            this.btmanageunit.UseVisualStyleBackColor = false;
            this.btmanageunit.Click += new System.EventHandler(this.btmanageunit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "No Urut (F4)";
            // 
            // btaddunit
            // 
            this.btaddunit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btaddunit.BackColor = System.Drawing.Color.Teal;
            this.btaddunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaddunit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddunit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btaddunit.Location = new System.Drawing.Point(8, 10);
            this.btaddunit.Margin = new System.Windows.Forms.Padding(4);
            this.btaddunit.Name = "btaddunit";
            this.btaddunit.Size = new System.Drawing.Size(105, 65);
            this.btaddunit.TabIndex = 14;
            this.btaddunit.Text = "Tambah Kemasan (F1)";
            this.btaddunit.UseVisualStyleBackColor = false;
            this.btaddunit.Click += new System.EventHandler(this.btaddunit_Click);
            // 
            // bteditunit
            // 
            this.bteditunit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bteditunit.BackColor = System.Drawing.Color.Teal;
            this.bteditunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditunit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditunit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bteditunit.Location = new System.Drawing.Point(7, 10);
            this.bteditunit.Margin = new System.Windows.Forms.Padding(4);
            this.bteditunit.Name = "bteditunit";
            this.bteditunit.Size = new System.Drawing.Size(105, 65);
            this.bteditunit.TabIndex = 15;
            this.bteditunit.Text = "Edit Kemasan (F2)";
            this.bteditunit.UseVisualStyleBackColor = false;
            this.bteditunit.Click += new System.EventHandler(this.bteditunit_Click);
            // 
            // btdeleteunit
            // 
            this.btdeleteunit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btdeleteunit.BackColor = System.Drawing.Color.Teal;
            this.btdeleteunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeleteunit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeleteunit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdeleteunit.Location = new System.Drawing.Point(8, 10);
            this.btdeleteunit.Margin = new System.Windows.Forms.Padding(4);
            this.btdeleteunit.Name = "btdeleteunit";
            this.btdeleteunit.Size = new System.Drawing.Size(105, 65);
            this.btdeleteunit.TabIndex = 16;
            this.btdeleteunit.Text = "Hapus Kemasan (F3)";
            this.btdeleteunit.UseVisualStyleBackColor = false;
            this.btdeleteunit.Click += new System.EventHandler(this.btdeleteunit_Click);
            // 
            // cbseq
            // 
            this.cbseq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbseq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbseq.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbseq.FormattingEnabled = true;
            this.cbseq.Location = new System.Drawing.Point(5, 42);
            this.cbseq.Name = "cbseq";
            this.cbseq.Size = new System.Drawing.Size(52, 30);
            this.cbseq.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 405);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(710, 92);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbseq);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 86);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btaddunit);
            this.panel4.Location = new System.Drawing.Point(74, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 86);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.bteditunit);
            this.panel5.Location = new System.Drawing.Point(201, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(121, 86);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.btdeleteunit);
            this.panel6.Location = new System.Drawing.Point(328, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(121, 86);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.btdeleteall);
            this.panel7.Location = new System.Drawing.Point(455, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(121, 86);
            this.panel7.TabIndex = 4;
            // 
            // btdeleteall
            // 
            this.btdeleteall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btdeleteall.BackColor = System.Drawing.Color.Purple;
            this.btdeleteall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeleteall.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeleteall.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdeleteall.Location = new System.Drawing.Point(8, 10);
            this.btdeleteall.Margin = new System.Windows.Forms.Padding(4);
            this.btdeleteall.Name = "btdeleteall";
            this.btdeleteall.Size = new System.Drawing.Size(105, 65);
            this.btdeleteall.TabIndex = 17;
            this.btdeleteall.Text = "Hapus Semua (F10)";
            this.btdeleteall.UseVisualStyleBackColor = false;
            this.btdeleteall.Click += new System.EventHandler(this.btdeleteall_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.groupBox1);
            this.panel8.Location = new System.Drawing.Point(582, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(125, 86);
            this.panel8.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbtime);
            this.groupBox1.Controls.Add(this.lbdate);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 83);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // lbtime
            // 
            this.lbtime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.Location = new System.Drawing.Point(0, 17);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(119, 27);
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
            this.lbdate.Size = new System.Drawing.Size(119, 31);
            this.lbdate.TabIndex = 1;
            this.lbdate.Text = "date";
            this.lbdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ManageUnitInProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 509);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gvunitlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageUnitInProduct";
            this.Text = "HaskaTech POS";
            this.Title = "Daftar Kemasan Pada Produk";
            this.Load += new System.EventHandler(this.ManageUnitInProduct_Load);
            this.Controls.SetChildIndex(this.gvunitlist, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvunitlist)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvunitlist;
        private System.Windows.Forms.Label lbitemname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbunitrelation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btaddunit;
        private System.Windows.Forms.Button bteditunit;
        private System.Windows.Forms.Button btdeleteunit;
        private System.Windows.Forms.ComboBox cbseq;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn seq_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn isPCS;
        private System.Windows.Forms.Button btdeleteall;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btmanageunit;
        private System.Windows.Forms.Button btchangerelation;
    }
}