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
            this.lbname = new System.Windows.Forms.Label();
            this.tbpurchaseprice = new System.Windows.Forms.NumericUpDown();
            this.lbpurchaseprice = new System.Windows.Forms.Label();
            this.numpurchaseqty = new System.Windows.Forms.NumericUpDown();
            this.lbpurchaseqty = new System.Windows.Forms.Label();
            this.cbunitpurchase = new System.Windows.Forms.ComboBox();
            this.lbpurchaseunit = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbpurchaseprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpurchaseqty)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbname.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbname.Location = new System.Drawing.Point(4, 2);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(600, 101);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "INDOMIE GORENG ORIGINAL RASA DAGING RENDANG PADANG";
            this.lbname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpurchaseprice
            // 
            this.tbpurchaseprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbpurchaseprice.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpurchaseprice.Location = new System.Drawing.Point(14, 49);
            this.tbpurchaseprice.Margin = new System.Windows.Forms.Padding(4);
            this.tbpurchaseprice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tbpurchaseprice.Name = "tbpurchaseprice";
            this.tbpurchaseprice.Size = new System.Drawing.Size(170, 39);
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
            this.lbpurchaseprice.Location = new System.Drawing.Point(9, 20);
            this.lbpurchaseprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpurchaseprice.Name = "lbpurchaseprice";
            this.lbpurchaseprice.Size = new System.Drawing.Size(151, 25);
            this.lbpurchaseprice.TabIndex = 1;
            this.lbpurchaseprice.Text = "Harga Beli (Rp)";
            // 
            // numpurchaseqty
            // 
            this.numpurchaseqty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numpurchaseqty.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpurchaseqty.Location = new System.Drawing.Point(8, 49);
            this.numpurchaseqty.Margin = new System.Windows.Forms.Padding(4);
            this.numpurchaseqty.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numpurchaseqty.Name = "numpurchaseqty";
            this.numpurchaseqty.Size = new System.Drawing.Size(129, 39);
            this.numpurchaseqty.TabIndex = 0;
            this.numpurchaseqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numpurchaseqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numpurchaseqty_KeyDown);
            // 
            // lbpurchaseqty
            // 
            this.lbpurchaseqty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpurchaseqty.AutoSize = true;
            this.lbpurchaseqty.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpurchaseqty.Location = new System.Drawing.Point(7, 20);
            this.lbpurchaseqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpurchaseqty.Name = "lbpurchaseqty";
            this.lbpurchaseqty.Size = new System.Drawing.Size(115, 25);
            this.lbpurchaseqty.TabIndex = 1;
            this.lbpurchaseqty.Text = "Jumlah Beli";
            // 
            // cbunitpurchase
            // 
            this.cbunitpurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbunitpurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunitpurchase.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitpurchase.FormattingEnabled = true;
            this.cbunitpurchase.Location = new System.Drawing.Point(11, 48);
            this.cbunitpurchase.Margin = new System.Windows.Forms.Padding(4);
            this.cbunitpurchase.Name = "cbunitpurchase";
            this.cbunitpurchase.Size = new System.Drawing.Size(227, 40);
            this.cbunitpurchase.TabIndex = 0;
            // 
            // lbpurchaseunit
            // 
            this.lbpurchaseunit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpurchaseunit.AutoSize = true;
            this.lbpurchaseunit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpurchaseunit.Location = new System.Drawing.Point(6, 20);
            this.lbpurchaseunit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpurchaseunit.Name = "lbpurchaseunit";
            this.lbpurchaseunit.Size = new System.Drawing.Size(133, 25);
            this.lbpurchaseunit.TabIndex = 1;
            this.lbpurchaseunit.Text = "Kemasan Beli";
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
            this.btnSave.Location = new System.Drawing.Point(8, 23);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(591, 67);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.lbname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 107);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbpurchaseqty);
            this.panel2.Controls.Add(this.numpurchaseqty);
            this.panel2.Location = new System.Drawing.Point(3, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 107);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbpurchaseunit);
            this.panel3.Controls.Add(this.cbunitpurchase);
            this.panel3.Location = new System.Drawing.Point(156, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 107);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbpurchaseprice);
            this.panel4.Controls.Add(this.tbpurchaseprice);
            this.panel4.Location = new System.Drawing.Point(413, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 107);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 3);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 229);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(608, 110);
            this.panel5.TabIndex = 4;
            // 
            // AddEditPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 436);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditPurchase";
            this.Text = "HaskaTech POS";
            this.Title = "Pengaturan Pembelian";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.AddEditPurchase_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tbpurchaseprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpurchaseqty)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.NumericUpDown tbpurchaseprice;
        private System.Windows.Forms.Label lbpurchaseprice;
        private System.Windows.Forms.NumericUpDown numpurchaseqty;
        private System.Windows.Forms.Label lbpurchaseqty;
        private System.Windows.Forms.ComboBox cbunitpurchase;
        private System.Windows.Forms.Label lbpurchaseunit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}