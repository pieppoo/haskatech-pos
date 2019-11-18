namespace POSsystem.Views
{
    partial class AddEditSellPrice
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
            this.lbitemname = new System.Windows.Forms.Label();
            this.lbunitsell = new System.Windows.Forms.Label();
            this.lbsellprice = new System.Windows.Forms.Label();
            this.cbunitsell = new System.Windows.Forms.ComboBox();
            this.tbsellprice = new System.Windows.Forms.NumericUpDown();
            this.btsave = new System.Windows.Forms.Button();
            this.lbbarcodeno = new System.Windows.Forms.Label();
            this.tbbarcodeno = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelprod = new System.Windows.Forms.Panel();
            this.panelsave = new System.Windows.Forms.Panel();
            this.panelbarcode = new System.Windows.Forms.Panel();
            this.panelkemasan = new System.Windows.Forms.Panel();
            this.panelharga = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbsellprice)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelprod.SuspendLayout();
            this.panelsave.SuspendLayout();
            this.panelbarcode.SuspendLayout();
            this.panelkemasan.SuspendLayout();
            this.panelharga.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbitemname
            // 
            this.lbitemname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbitemname.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbitemname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbitemname.Location = new System.Drawing.Point(18, 10);
            this.lbitemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbitemname.Name = "lbitemname";
            this.lbitemname.Size = new System.Drawing.Size(514, 69);
            this.lbitemname.TabIndex = 18;
            this.lbitemname.Text = "Nama Produk";
            this.lbitemname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbunitsell
            // 
            this.lbunitsell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbunitsell.AutoSize = true;
            this.lbunitsell.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitsell.Location = new System.Drawing.Point(14, 10);
            this.lbunitsell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbunitsell.Name = "lbunitsell";
            this.lbunitsell.Size = new System.Drawing.Size(93, 25);
            this.lbunitsell.TabIndex = 20;
            this.lbunitsell.Text = "Kemasan";
            // 
            // lbsellprice
            // 
            this.lbsellprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbsellprice.AutoSize = true;
            this.lbsellprice.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsellprice.Location = new System.Drawing.Point(18, 10);
            this.lbsellprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsellprice.Name = "lbsellprice";
            this.lbsellprice.Size = new System.Drawing.Size(150, 25);
            this.lbsellprice.TabIndex = 22;
            this.lbsellprice.Text = "Harga Jual (Rp)";
            // 
            // cbunitsell
            // 
            this.cbunitsell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbunitsell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunitsell.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitsell.FormattingEnabled = true;
            this.cbunitsell.Location = new System.Drawing.Point(19, 39);
            this.cbunitsell.Margin = new System.Windows.Forms.Padding(4);
            this.cbunitsell.Name = "cbunitsell";
            this.cbunitsell.Size = new System.Drawing.Size(234, 40);
            this.cbunitsell.TabIndex = 1;
            this.cbunitsell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbunitsell_KeyDown);
            // 
            // tbsellprice
            // 
            this.tbsellprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbsellprice.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsellprice.Location = new System.Drawing.Point(18, 39);
            this.tbsellprice.Margin = new System.Windows.Forms.Padding(4);
            this.tbsellprice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tbsellprice.Name = "tbsellprice";
            this.tbsellprice.Size = new System.Drawing.Size(243, 39);
            this.tbsellprice.TabIndex = 0;
            this.tbsellprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbsellprice.ThousandsSeparator = true;
            this.tbsellprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbsellprice_KeyDown);
            // 
            // btsave
            // 
            this.btsave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btsave.BackColor = System.Drawing.Color.SteelBlue;
            this.btsave.FlatAppearance.BorderSize = 0;
            this.btsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.Transparent;
            this.btsave.Location = new System.Drawing.Point(18, 15);
            this.btsave.Margin = new System.Windows.Forms.Padding(4);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(514, 67);
            this.btsave.TabIndex = 3;
            this.btsave.Text = "Simpan";
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // lbbarcodeno
            // 
            this.lbbarcodeno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbbarcodeno.AutoSize = true;
            this.lbbarcodeno.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbarcodeno.Location = new System.Drawing.Point(18, 12);
            this.lbbarcodeno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbarcodeno.Name = "lbbarcodeno";
            this.lbbarcodeno.Size = new System.Drawing.Size(153, 25);
            this.lbbarcodeno.TabIndex = 27;
            this.lbbarcodeno.Text = "Nomor Barcode";
            // 
            // tbbarcodeno
            // 
            this.tbbarcodeno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbbarcodeno.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbarcodeno.Location = new System.Drawing.Point(18, 40);
            this.tbbarcodeno.Name = "tbbarcodeno";
            this.tbbarcodeno.Size = new System.Drawing.Size(515, 39);
            this.tbbarcodeno.TabIndex = 2;
            this.tbbarcodeno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbbarcodeno_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelprod, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelsave, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelbarcode, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelkemasan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelharga, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 398);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // panelprod
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelprod, 2);
            this.panelprod.Controls.Add(this.lbitemname);
            this.panelprod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelprod.Location = new System.Drawing.Point(3, 3);
            this.panelprod.Name = "panelprod";
            this.panelprod.Size = new System.Drawing.Size(553, 93);
            this.panelprod.TabIndex = 0;
            // 
            // panelsave
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelsave, 2);
            this.panelsave.Controls.Add(this.btsave);
            this.panelsave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelsave.Location = new System.Drawing.Point(3, 300);
            this.panelsave.Name = "panelsave";
            this.panelsave.Size = new System.Drawing.Size(553, 95);
            this.panelsave.TabIndex = 4;
            // 
            // panelbarcode
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelbarcode, 2);
            this.panelbarcode.Controls.Add(this.tbbarcodeno);
            this.panelbarcode.Controls.Add(this.lbbarcodeno);
            this.panelbarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbarcode.Location = new System.Drawing.Point(3, 201);
            this.panelbarcode.Name = "panelbarcode";
            this.panelbarcode.Size = new System.Drawing.Size(553, 93);
            this.panelbarcode.TabIndex = 3;
            // 
            // panelkemasan
            // 
            this.panelkemasan.Controls.Add(this.cbunitsell);
            this.panelkemasan.Controls.Add(this.lbunitsell);
            this.panelkemasan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelkemasan.Location = new System.Drawing.Point(282, 102);
            this.panelkemasan.Name = "panelkemasan";
            this.panelkemasan.Size = new System.Drawing.Size(274, 93);
            this.panelkemasan.TabIndex = 2;
            // 
            // panelharga
            // 
            this.panelharga.Controls.Add(this.tbsellprice);
            this.panelharga.Controls.Add(this.lbsellprice);
            this.panelharga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelharga.Location = new System.Drawing.Point(3, 102);
            this.panelharga.Name = "panelharga";
            this.panelharga.Size = new System.Drawing.Size(273, 93);
            this.panelharga.TabIndex = 1;
            // 
            // AddEditSellPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditSellPrice";
            this.Text = "HaskaTech POS";
            this.Title = "Harga Jual";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.AddEditSellPrice_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tbsellprice)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelprod.ResumeLayout(false);
            this.panelsave.ResumeLayout(false);
            this.panelbarcode.ResumeLayout(false);
            this.panelbarcode.PerformLayout();
            this.panelkemasan.ResumeLayout(false);
            this.panelkemasan.PerformLayout();
            this.panelharga.ResumeLayout(false);
            this.panelharga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbitemname;
        private System.Windows.Forms.Label lbsellprice;
        private System.Windows.Forms.NumericUpDown tbsellprice;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label lbbarcodeno;
        private System.Windows.Forms.TextBox tbbarcodeno;
        private System.Windows.Forms.Label lbunitsell;
        private System.Windows.Forms.ComboBox cbunitsell;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelprod;
        private System.Windows.Forms.Panel panelsave;
        private System.Windows.Forms.Panel panelbarcode;
        private System.Windows.Forms.Panel panelkemasan;
        private System.Windows.Forms.Panel panelharga;
    }
}