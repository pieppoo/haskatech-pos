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
            this.lbchangerelation = new System.Windows.Forms.Label();
            this.lbunitrelation = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvunitlist)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.gvunitlist.Location = new System.Drawing.Point(13, 112);
            this.gvunitlist.Margin = new System.Windows.Forms.Padding(4);
            this.gvunitlist.MultiSelect = false;
            this.gvunitlist.Name = "gvunitlist";
            this.gvunitlist.ReadOnly = true;
            this.gvunitlist.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvunitlist.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvunitlist.RowTemplate.Height = 32;
            this.gvunitlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvunitlist.Size = new System.Drawing.Size(716, 279);
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
            this.lbitemname.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbitemname.Location = new System.Drawing.Point(11, 8);
            this.lbitemname.Name = "lbitemname";
            this.lbitemname.Size = new System.Drawing.Size(183, 34);
            this.lbitemname.TabIndex = 12;
            this.lbitemname.Text = "Nama Produk";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 56);
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
            this.panel1.Size = new System.Drawing.Size(352, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbchangerelation);
            this.panel2.Controls.Add(this.lbunitrelation);
            this.panel2.Location = new System.Drawing.Point(361, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 50);
            this.panel2.TabIndex = 1;
            // 
            // lbchangerelation
            // 
            this.lbchangerelation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbchangerelation.AutoSize = true;
            this.lbchangerelation.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchangerelation.ForeColor = System.Drawing.Color.Blue;
            this.lbchangerelation.Location = new System.Drawing.Point(6, 29);
            this.lbchangerelation.Name = "lbchangerelation";
            this.lbchangerelation.Size = new System.Drawing.Size(37, 14);
            this.lbchangerelation.TabIndex = 14;
            this.lbchangerelation.Text = "Tukar";
            this.lbchangerelation.Click += new System.EventHandler(this.lbchangerelation_Click);
            // 
            // lbunitrelation
            // 
            this.lbunitrelation.AutoSize = true;
            this.lbunitrelation.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitrelation.Location = new System.Drawing.Point(4, 7);
            this.lbunitrelation.Name = "lbunitrelation";
            this.lbunitrelation.Size = new System.Drawing.Size(133, 22);
            this.lbunitrelation.TabIndex = 13;
            this.lbunitrelation.Text = "Unit berkaitan?";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
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
            this.btaddunit.Location = new System.Drawing.Point(8, 8);
            this.btaddunit.Margin = new System.Windows.Forms.Padding(4);
            this.btaddunit.Name = "btaddunit";
            this.btaddunit.Size = new System.Drawing.Size(120, 71);
            this.btaddunit.TabIndex = 14;
            this.btaddunit.Text = "Tambah Unit (F1)";
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
            this.bteditunit.Location = new System.Drawing.Point(7, 8);
            this.bteditunit.Margin = new System.Windows.Forms.Padding(4);
            this.bteditunit.Name = "bteditunit";
            this.bteditunit.Size = new System.Drawing.Size(120, 71);
            this.bteditunit.TabIndex = 15;
            this.bteditunit.Text = "Edit Unit \r\n(F2)";
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
            this.btdeleteunit.Location = new System.Drawing.Point(7, 8);
            this.btdeleteunit.Margin = new System.Windows.Forms.Padding(4);
            this.btdeleteunit.Name = "btdeleteunit";
            this.btdeleteunit.Size = new System.Drawing.Size(120, 71);
            this.btdeleteunit.TabIndex = 16;
            this.btdeleteunit.Text = "Hapus Unit (F3)";
            this.btdeleteunit.UseVisualStyleBackColor = false;
            this.btdeleteunit.Click += new System.EventHandler(this.btdeleteunit_Click);
            // 
            // cbseq
            // 
            this.cbseq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbseq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbseq.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbseq.FormattingEnabled = true;
            this.cbseq.Location = new System.Drawing.Point(11, 40);
            this.cbseq.Name = "cbseq";
            this.cbseq.Size = new System.Drawing.Size(70, 30);
            this.cbseq.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 4, 0);
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
            this.panel3.Size = new System.Drawing.Size(100, 86);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btaddunit);
            this.panel4.Location = new System.Drawing.Point(109, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 86);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.bteditunit);
            this.panel5.Location = new System.Drawing.Point(251, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(136, 86);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.btdeleteunit);
            this.panel6.Location = new System.Drawing.Point(393, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(136, 86);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Location = new System.Drawing.Point(535, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(172, 86);
            this.panel7.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbtime);
            this.groupBox1.Controls.Add(this.lbdate);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 74);
            this.groupBox1.TabIndex = 19;
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbchangerelation;
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
    }
}