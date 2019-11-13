namespace POSsystem.Views
{
    partial class AddEditPurchase
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
            this.tbname = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.tbpurchaseprice = new System.Windows.Forms.NumericUpDown();
            this.lbpurchaseprice = new System.Windows.Forms.Label();
            this.numpurchaseqty = new System.Windows.Forms.NumericUpDown();
            this.lbpurchaseqty = new System.Windows.Forms.Label();
            this.cbunitpurchase = new System.Windows.Forms.ComboBox();
            this.lbpurchaseunit = new System.Windows.Forms.Label();
            this.numpcsincontainer = new System.Windows.Forms.NumericUpDown();
            this.lbpcsincontainer = new System.Windows.Forms.Label();
            this.cbpcsunit = new System.Windows.Forms.ComboBox();
            this.lbpcsunit = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbtotal = new System.Windows.Forms.Label();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbpurchaseprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpurchaseqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpcsincontainer)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbname.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(7, 37);
            this.tbname.Margin = new System.Windows.Forms.Padding(4);
            this.tbname.Name = "tbname";
            this.tbname.ReadOnly = true;
            this.tbname.Size = new System.Drawing.Size(515, 39);
            this.tbname.TabIndex = 0;
            // 
            // lbname
            // 
            this.lbname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(7, 8);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(135, 25);
            this.lbname.TabIndex = 78;
            this.lbname.Text = "Nama Produk";
            // 
            // tbpurchaseprice
            // 
            this.tbpurchaseprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbpurchaseprice.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpurchaseprice.Location = new System.Drawing.Point(10, 37);
            this.tbpurchaseprice.Margin = new System.Windows.Forms.Padding(4);
            this.tbpurchaseprice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tbpurchaseprice.Name = "tbpurchaseprice";
            this.tbpurchaseprice.Size = new System.Drawing.Size(515, 39);
            this.tbpurchaseprice.TabIndex = 0;
            this.tbpurchaseprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbpurchaseprice.ThousandsSeparator = true;
            this.tbpurchaseprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbpurchaseprice_KeyDown);
            // 
            // lbpurchaseprice
            // 
            this.lbpurchaseprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpurchaseprice.AutoSize = true;
            this.lbpurchaseprice.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpurchaseprice.Location = new System.Drawing.Point(5, 8);
            this.lbpurchaseprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpurchaseprice.Name = "lbpurchaseprice";
            this.lbpurchaseprice.Size = new System.Drawing.Size(151, 25);
            this.lbpurchaseprice.TabIndex = 26;
            this.lbpurchaseprice.Text = "Harga Beli (Rp)";
            // 
            // numpurchaseqty
            // 
            this.numpurchaseqty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numpurchaseqty.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpurchaseqty.Location = new System.Drawing.Point(7, 37);
            this.numpurchaseqty.Margin = new System.Windows.Forms.Padding(4);
            this.numpurchaseqty.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numpurchaseqty.Name = "numpurchaseqty";
            this.numpurchaseqty.Size = new System.Drawing.Size(515, 39);
            this.numpurchaseqty.TabIndex = 0;
            this.numpurchaseqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numpurchaseqty.ValueChanged += new System.EventHandler(this.numQuantityAndPriceValueChanged);
            this.numpurchaseqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numpurchaseqty_KeyDown);
            // 
            // lbpurchaseqty
            // 
            this.lbpurchaseqty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpurchaseqty.AutoSize = true;
            this.lbpurchaseqty.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpurchaseqty.Location = new System.Drawing.Point(7, 8);
            this.lbpurchaseqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpurchaseqty.Name = "lbpurchaseqty";
            this.lbpurchaseqty.Size = new System.Drawing.Size(115, 25);
            this.lbpurchaseqty.TabIndex = 28;
            this.lbpurchaseqty.Text = "Jumlah Beli";
            // 
            // cbunitpurchase
            // 
            this.cbunitpurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbunitpurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunitpurchase.Enabled = false;
            this.cbunitpurchase.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitpurchase.FormattingEnabled = true;
            this.cbunitpurchase.Location = new System.Drawing.Point(10, 37);
            this.cbunitpurchase.Margin = new System.Windows.Forms.Padding(4);
            this.cbunitpurchase.Name = "cbunitpurchase";
            this.cbunitpurchase.Size = new System.Drawing.Size(515, 40);
            this.cbunitpurchase.TabIndex = 0;
            // 
            // lbpurchaseunit
            // 
            this.lbpurchaseunit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpurchaseunit.AutoSize = true;
            this.lbpurchaseunit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpurchaseunit.Location = new System.Drawing.Point(5, 10);
            this.lbpurchaseunit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpurchaseunit.Name = "lbpurchaseunit";
            this.lbpurchaseunit.Size = new System.Drawing.Size(133, 25);
            this.lbpurchaseunit.TabIndex = 31;
            this.lbpurchaseunit.Text = "Kemasan Beli";
            // 
            // numpcsincontainer
            // 
            this.numpcsincontainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numpcsincontainer.Enabled = false;
            this.numpcsincontainer.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpcsincontainer.Location = new System.Drawing.Point(7, 38);
            this.numpcsincontainer.Margin = new System.Windows.Forms.Padding(4);
            this.numpcsincontainer.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numpcsincontainer.Name = "numpcsincontainer";
            this.numpcsincontainer.ReadOnly = true;
            this.numpcsincontainer.Size = new System.Drawing.Size(515, 39);
            this.numpcsincontainer.TabIndex = 88;
            this.numpcsincontainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numpcsincontainer.ValueChanged += new System.EventHandler(this.numQuantityAndPriceValueChanged);
            // 
            // lbpcsincontainer
            // 
            this.lbpcsincontainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpcsincontainer.AutoSize = true;
            this.lbpcsincontainer.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpcsincontainer.Location = new System.Drawing.Point(7, 10);
            this.lbpcsincontainer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpcsincontainer.Name = "lbpcsincontainer";
            this.lbpcsincontainer.Size = new System.Drawing.Size(257, 25);
            this.lbpcsincontainer.TabIndex = 33;
            this.lbpcsincontainer.Text = "Jumlah Eceran Perkemasan";
            this.lbpcsincontainer.Click += new System.EventHandler(this.lbpcsincontainer_Click);
            // 
            // cbpcsunit
            // 
            this.cbpcsunit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbpcsunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpcsunit.Enabled = false;
            this.cbpcsunit.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpcsunit.FormattingEnabled = true;
            this.cbpcsunit.Location = new System.Drawing.Point(10, 37);
            this.cbpcsunit.Margin = new System.Windows.Forms.Padding(4);
            this.cbpcsunit.Name = "cbpcsunit";
            this.cbpcsunit.Size = new System.Drawing.Size(515, 40);
            this.cbpcsunit.TabIndex = 0;
            // 
            // lbpcsunit
            // 
            this.lbpcsunit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpcsunit.AutoSize = true;
            this.lbpcsunit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpcsunit.Location = new System.Drawing.Point(5, 8);
            this.lbpcsunit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpcsunit.Name = "lbpcsunit";
            this.lbpcsunit.Size = new System.Drawing.Size(160, 25);
            this.lbpcsunit.TabIndex = 35;
            this.lbpcsunit.Text = "Kemasan Eceran";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 92);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1077, 460);
            this.tableLayoutPanel2.TabIndex = 91;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbname);
            this.panel1.Controls.Add(this.tbname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 86);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbpurchaseprice);
            this.panel2.Controls.Add(this.lbpurchaseprice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(541, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 86);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numpurchaseqty);
            this.panel3.Controls.Add(this.lbpurchaseqty);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 86);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbunitpurchase);
            this.panel4.Controls.Add(this.lbpurchaseunit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(541, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(533, 86);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.numpcsincontainer);
            this.panel5.Controls.Add(this.lbpcsincontainer);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 187);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(532, 86);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbpcsunit);
            this.panel6.Controls.Add(this.cbpcsunit);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(541, 187);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(533, 86);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbtotal);
            this.panel7.Controls.Add(this.tbtotal);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 279);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(532, 86);
            this.panel7.TabIndex = 6;
            // 
            // lbtotal
            // 
            this.lbtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.Location = new System.Drawing.Point(7, 9);
            this.lbtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(192, 25);
            this.lbtotal.TabIndex = 38;
            this.lbtotal.Text = "Total Barang Eceran";
            // 
            // tbtotal
            // 
            this.tbtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtotal.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotal.Location = new System.Drawing.Point(7, 40);
            this.tbtotal.Margin = new System.Windows.Forms.Padding(4);
            this.tbtotal.Multiline = true;
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.ReadOnly = true;
            this.tbtotal.Size = new System.Drawing.Size(515, 33);
            this.tbtotal.TabIndex = 0;
            this.tbtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(541, 279);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(533, 86);
            this.panel8.TabIndex = 7;
            // 
            // panel9
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel9, 2);
            this.panel9.Controls.Add(this.btnSave);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 371);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1071, 86);
            this.panel9.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(17, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(1036, 67);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddEditPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 591);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditPurchase";
            this.Text = "HaskaTech POS";
            this.Title = "Pengaturan Pembelian";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.AddEditPurchase_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tbpurchaseprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpurchaseqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpcsincontainer)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.NumericUpDown tbpurchaseprice;
        private System.Windows.Forms.Label lbpurchaseprice;
        private System.Windows.Forms.NumericUpDown numpurchaseqty;
        private System.Windows.Forms.Label lbpurchaseqty;
        private System.Windows.Forms.ComboBox cbunitpurchase;
        private System.Windows.Forms.Label lbpurchaseunit;
        private System.Windows.Forms.NumericUpDown numpcsincontainer;
        private System.Windows.Forms.Label lbpcsincontainer;
        private System.Windows.Forms.ComboBox cbpcsunit;
        private System.Windows.Forms.Label lbpcsunit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSave;
    }
}