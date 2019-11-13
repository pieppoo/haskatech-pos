namespace POSsystem
{
    partial class ManageBrand
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
            this.gvbrand = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remaark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btdeletebrand = new System.Windows.Forms.Button();
            this.bteditbrand = new System.Windows.Forms.Button();
            this.btaddbrand = new System.Windows.Forms.Button();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbbrandname = new System.Windows.Forms.TextBox();
            this.lb_brandsearch = new System.Windows.Forms.Label();
            this.btsearch = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvbrand)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvbrand
            // 
            this.gvbrand.AllowUserToAddRows = false;
            this.gvbrand.AllowUserToDeleteRows = false;
            this.gvbrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvbrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvbrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.No,
            this.brandname,
            this.remaark});
            this.gvbrand.Location = new System.Drawing.Point(24, 133);
            this.gvbrand.Margin = new System.Windows.Forms.Padding(4);
            this.gvbrand.MultiSelect = false;
            this.gvbrand.Name = "gvbrand";
            this.gvbrand.ReadOnly = true;
            this.gvbrand.RowHeadersVisible = false;
            this.gvbrand.RowTemplate.Height = 30;
            this.gvbrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvbrand.Size = new System.Drawing.Size(710, 203);
            this.gvbrand.TabIndex = 12;
            this.gvbrand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvbrand_KeyDown);
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
            // brandname
            // 
            this.brandname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brandname.FillWeight = 50F;
            this.brandname.HeaderText = "Nama Merek";
            this.brandname.Name = "brandname";
            this.brandname.ReadOnly = true;
            // 
            // remaark
            // 
            this.remaark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remaark.FillWeight = 50F;
            this.remaark.HeaderText = "Keterangan";
            this.remaark.Name = "remaark";
            this.remaark.ReadOnly = true;
            // 
            // btdeletebrand
            // 
            this.btdeletebrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btdeletebrand.BackColor = System.Drawing.Color.Teal;
            this.btdeletebrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeletebrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeletebrand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdeletebrand.Location = new System.Drawing.Point(5, 4);
            this.btdeletebrand.Margin = new System.Windows.Forms.Padding(4);
            this.btdeletebrand.Name = "btdeletebrand";
            this.btdeletebrand.Size = new System.Drawing.Size(128, 79);
            this.btdeletebrand.TabIndex = 15;
            this.btdeletebrand.Text = "Hapus Merek\r\n(F3)";
            this.btdeletebrand.UseVisualStyleBackColor = false;
            this.btdeletebrand.Click += new System.EventHandler(this.btdeletebrand_Click);
            // 
            // bteditbrand
            // 
            this.bteditbrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bteditbrand.BackColor = System.Drawing.Color.Teal;
            this.bteditbrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditbrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditbrand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bteditbrand.Location = new System.Drawing.Point(4, 4);
            this.bteditbrand.Margin = new System.Windows.Forms.Padding(4);
            this.bteditbrand.Name = "bteditbrand";
            this.bteditbrand.Size = new System.Drawing.Size(128, 79);
            this.bteditbrand.TabIndex = 14;
            this.bteditbrand.Text = "Edit Merek\r\n(F2)";
            this.bteditbrand.UseVisualStyleBackColor = false;
            this.bteditbrand.Click += new System.EventHandler(this.bteditbrand_Click);
            // 
            // btaddbrand
            // 
            this.btaddbrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btaddbrand.BackColor = System.Drawing.Color.Teal;
            this.btaddbrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaddbrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddbrand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btaddbrand.Location = new System.Drawing.Point(5, 4);
            this.btaddbrand.Margin = new System.Windows.Forms.Padding(4);
            this.btaddbrand.Name = "btaddbrand";
            this.btaddbrand.Size = new System.Drawing.Size(128, 79);
            this.btaddbrand.TabIndex = 13;
            this.btaddbrand.Text = "Tambah Merek\r\n(F1)";
            this.btaddbrand.UseVisualStyleBackColor = false;
            this.btaddbrand.Click += new System.EventHandler(this.btaddbrand_Click);
            // 
            // lbtime
            // 
            this.lbtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.Location = new System.Drawing.Point(5, 9);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(266, 30);
            this.lbtime.TabIndex = 1;
            this.lbtime.Text = "time";
            this.lbtime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbdate
            // 
            this.lbdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(1, 37);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(276, 36);
            this.lbdate.TabIndex = 0;
            this.lbdate.Text = "date";
            this.lbdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 353);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 93);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btaddbrand);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 87);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.bteditbrand);
            this.panel2.Location = new System.Drawing.Point(146, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 87);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btdeletebrand);
            this.panel3.Location = new System.Drawing.Point(289, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 87);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(432, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 87);
            this.panel4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbtime);
            this.groupBox1.Controls.Add(this.lbdate);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tbbrandname
            // 
            this.tbbrandname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbbrandname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbrandname.Location = new System.Drawing.Point(6, 30);
            this.tbbrandname.Name = "tbbrandname";
            this.tbbrandname.Size = new System.Drawing.Size(410, 32);
            this.tbbrandname.TabIndex = 18;
            // 
            // lb_brandsearch
            // 
            this.lb_brandsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_brandsearch.AutoSize = true;
            this.lb_brandsearch.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_brandsearch.Location = new System.Drawing.Point(6, 7);
            this.lb_brandsearch.Name = "lb_brandsearch";
            this.lb_brandsearch.Size = new System.Drawing.Size(113, 22);
            this.lb_brandsearch.TabIndex = 22;
            this.lb_brandsearch.Text = "Nama Merek";
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
            this.btsearch.Location = new System.Drawing.Point(7, 7);
            this.btsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(122, 58);
            this.btsearch.TabIndex = 20;
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
            this.btnreset.Location = new System.Drawing.Point(7, 7);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(122, 58);
            this.btnreset.TabIndex = 21;
            this.btnreset.Text = "Reset (F5)";
            this.btnreset.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(24, 50);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(710, 76);
            this.tableLayoutPanel3.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.lb_brandsearch);
            this.panel5.Controls.Add(this.tbbrandname);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(420, 70);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.btsearch);
            this.panel6.Location = new System.Drawing.Point(429, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(136, 70);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.btnreset);
            this.panel7.Location = new System.Drawing.Point(571, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(136, 70);
            this.panel7.TabIndex = 2;
            // 
            // ManageBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 458);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gvbrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageBrand";
            this.Text = "HaskaTech POS";
            this.Title = "Daftar Merek";
            this.Load += new System.EventHandler(this.ManageBrand_Load);
            this.Controls.SetChildIndex(this.gvbrand, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvbrand)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gvbrand;
        private System.Windows.Forms.Button btdeletebrand;
        private System.Windows.Forms.Button bteditbrand;
        private System.Windows.Forms.Button btaddbrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandname;
        private System.Windows.Forms.DataGridViewTextBoxColumn remaark;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbbrandname;
        private System.Windows.Forms.Label lb_brandsearch;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}