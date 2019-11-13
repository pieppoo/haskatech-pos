namespace POSsystem.Views
{
    partial class ManageCategories
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
            this.lbcatsearch = new System.Windows.Forms.Label();
            this.tbcatname = new System.Windows.Forms.TextBox();
            this.btsearch = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btaddcat = new System.Windows.Forms.Button();
            this.bteditcat = new System.Windows.Forms.Button();
            this.btdelcat = new System.Windows.Forms.Button();
            this.gvcat = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remaark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvcat)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbcatsearch
            // 
            this.lbcatsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcatsearch.AutoSize = true;
            this.lbcatsearch.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcatsearch.Location = new System.Drawing.Point(4, 7);
            this.lbcatsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcatsearch.Name = "lbcatsearch";
            this.lbcatsearch.Size = new System.Drawing.Size(127, 22);
            this.lbcatsearch.TabIndex = 1;
            this.lbcatsearch.Text = "Nama kategori";
            // 
            // tbcatname
            // 
            this.tbcatname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcatname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbcatname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcatname.Location = new System.Drawing.Point(8, 33);
            this.tbcatname.Margin = new System.Windows.Forms.Padding(4);
            this.tbcatname.Name = "tbcatname";
            this.tbcatname.Size = new System.Drawing.Size(384, 32);
            this.tbcatname.TabIndex = 0;
            this.tbcatname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbcatname_KeyDown);
            // 
            // btsearch
            // 
            this.btsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btsearch.BackColor = System.Drawing.Color.Goldenrod;
            this.btsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btsearch.Location = new System.Drawing.Point(2, 7);
            this.btsearch.Margin = new System.Windows.Forms.Padding(5);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(123, 64);
            this.btsearch.TabIndex = 0;
            this.btsearch.Text = "Cari (F4)";
            this.btsearch.UseVisualStyleBackColor = false;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // btnreset
            // 
            this.btnreset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreset.BackColor = System.Drawing.Color.Goldenrod;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnreset.Location = new System.Drawing.Point(5, 7);
            this.btnreset.Margin = new System.Windows.Forms.Padding(5);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(123, 64);
            this.btnreset.TabIndex = 0;
            this.btnreset.Text = "Reset (F5)";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btaddcat
            // 
            this.btaddcat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btaddcat.BackColor = System.Drawing.Color.Teal;
            this.btaddcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaddcat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddcat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btaddcat.Location = new System.Drawing.Point(6, 11);
            this.btaddcat.Margin = new System.Windows.Forms.Padding(5);
            this.btaddcat.Name = "btaddcat";
            this.btaddcat.Size = new System.Drawing.Size(117, 82);
            this.btaddcat.TabIndex = 0;
            this.btaddcat.Text = "Tambah kategori \r\n(F1)";
            this.btaddcat.UseVisualStyleBackColor = false;
            this.btaddcat.Click += new System.EventHandler(this.btaddcat_Click);
            // 
            // bteditcat
            // 
            this.bteditcat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bteditcat.BackColor = System.Drawing.Color.Teal;
            this.bteditcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditcat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditcat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bteditcat.Location = new System.Drawing.Point(5, 11);
            this.bteditcat.Margin = new System.Windows.Forms.Padding(5);
            this.bteditcat.Name = "bteditcat";
            this.bteditcat.Size = new System.Drawing.Size(117, 82);
            this.bteditcat.TabIndex = 0;
            this.bteditcat.Text = "Edit Kategori \r\n(F2)";
            this.bteditcat.UseVisualStyleBackColor = false;
            this.bteditcat.Click += new System.EventHandler(this.bteditcat_Click);
            // 
            // btdelcat
            // 
            this.btdelcat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btdelcat.BackColor = System.Drawing.Color.Teal;
            this.btdelcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdelcat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelcat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdelcat.Location = new System.Drawing.Point(7, 11);
            this.btdelcat.Margin = new System.Windows.Forms.Padding(5);
            this.btdelcat.Name = "btdelcat";
            this.btdelcat.Size = new System.Drawing.Size(117, 82);
            this.btdelcat.TabIndex = 0;
            this.btdelcat.Text = "Hapus Kategori (F3)";
            this.btdelcat.UseVisualStyleBackColor = false;
            this.btdelcat.Click += new System.EventHandler(this.btdelcat_Click);
            // 
            // gvcat
            // 
            this.gvcat.AllowUserToAddRows = false;
            this.gvcat.AllowUserToDeleteRows = false;
            this.gvcat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvcat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.No,
            this.catname,
            this.remaark});
            this.gvcat.Location = new System.Drawing.Point(21, 151);
            this.gvcat.Margin = new System.Windows.Forms.Padding(5);
            this.gvcat.MultiSelect = false;
            this.gvcat.Name = "gvcat";
            this.gvcat.ReadOnly = true;
            this.gvcat.RowHeadersVisible = false;
            this.gvcat.RowTemplate.Height = 30;
            this.gvcat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvcat.Size = new System.Drawing.Size(683, 265);
            this.gvcat.TabIndex = 1;
            this.gvcat.DoubleClick += new System.EventHandler(this.gvcat_DoubleClick);
            this.gvcat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvcat_KeyDown);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 40;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // catname
            // 
            this.catname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catname.FillWeight = 50F;
            this.catname.HeaderText = "Nama kategori";
            this.catname.Name = "catname";
            this.catname.ReadOnly = true;
            // 
            // remaark
            // 
            this.remaark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remaark.FillWeight = 50F;
            this.remaark.HeaderText = "Keterangan";
            this.remaark.Name = "remaark";
            this.remaark.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 59);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(683, 83);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btsearch);
            this.panel2.Location = new System.Drawing.Point(412, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 77);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnreset);
            this.panel3.Location = new System.Drawing.Point(548, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 77);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tbcatname);
            this.panel1.Controls.Add(this.lbcatsearch);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 77);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 427);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(683, 109);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Location = new System.Drawing.Point(411, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(269, 103);
            this.panel7.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbtime);
            this.groupBox1.Controls.Add(this.lbdate);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbtime
            // 
            this.lbtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.Location = new System.Drawing.Point(-3, 12);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(266, 30);
            this.lbtime.TabIndex = 0;
            this.lbtime.Text = "time";
            this.lbtime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbdate
            // 
            this.lbdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(-3, 43);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(266, 43);
            this.lbdate.TabIndex = 1;
            this.lbdate.Text = "date";
            this.lbdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.bteditcat);
            this.panel5.Location = new System.Drawing.Point(139, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 103);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.btdelcat);
            this.panel6.Location = new System.Drawing.Point(275, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(130, 103);
            this.panel6.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btaddcat);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 103);
            this.panel4.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 555);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gvcat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageCategories";
            this.Text = "ManageCategories";
            this.Title = "Daftar Kategori";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            this.Controls.SetChildIndex(this.gvcat, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvcat)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbcatsearch;
        private System.Windows.Forms.TextBox tbcatname;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btaddcat;
        private System.Windows.Forms.Button bteditcat;
        private System.Windows.Forms.Button btdelcat;
        private System.Windows.Forms.DataGridView gvcat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn catname;
        private System.Windows.Forms.DataGridViewTextBoxColumn remaark;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Timer timer1;
    }
}