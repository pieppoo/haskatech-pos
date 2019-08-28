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
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.lbtotal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbpurchaseprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpurchaseqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpcsincontainer)).BeginInit();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(48, 132);
            this.tbname.Margin = new System.Windows.Forms.Padding(4);
            this.tbname.Multiline = true;
            this.tbname.Name = "tbname";
            this.tbname.ReadOnly = true;
            this.tbname.Size = new System.Drawing.Size(318, 68);
            this.tbname.TabIndex = 20;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(43, 100);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(135, 25);
            this.lbname.TabIndex = 19;
            this.lbname.Text = "Nama Produk";
            // 
            // tbpurchaseprice
            // 
            this.tbpurchaseprice.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpurchaseprice.Location = new System.Drawing.Point(404, 132);
            this.tbpurchaseprice.Margin = new System.Windows.Forms.Padding(4);
            this.tbpurchaseprice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tbpurchaseprice.Name = "tbpurchaseprice";
            this.tbpurchaseprice.Size = new System.Drawing.Size(313, 39);
            this.tbpurchaseprice.TabIndex = 27;
            this.tbpurchaseprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbpurchaseprice
            // 
            this.lbpurchaseprice.AutoSize = true;
            this.lbpurchaseprice.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpurchaseprice.Location = new System.Drawing.Point(399, 101);
            this.lbpurchaseprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpurchaseprice.Name = "lbpurchaseprice";
            this.lbpurchaseprice.Size = new System.Drawing.Size(105, 25);
            this.lbpurchaseprice.TabIndex = 26;
            this.lbpurchaseprice.Text = "Harga Beli";
            // 
            // numpurchaseqty
            // 
            this.numpurchaseqty.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpurchaseqty.Location = new System.Drawing.Point(48, 250);
            this.numpurchaseqty.Margin = new System.Windows.Forms.Padding(4);
            this.numpurchaseqty.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numpurchaseqty.Name = "numpurchaseqty";
            this.numpurchaseqty.Size = new System.Drawing.Size(318, 39);
            this.numpurchaseqty.TabIndex = 29;
            this.numpurchaseqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numpurchaseqty.ValueChanged += new System.EventHandler(this.numQuantityAndPriceValueChanged);
            // 
            // lbpurchaseqty
            // 
            this.lbpurchaseqty.AutoSize = true;
            this.lbpurchaseqty.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpurchaseqty.Location = new System.Drawing.Point(43, 219);
            this.lbpurchaseqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpurchaseqty.Name = "lbpurchaseqty";
            this.lbpurchaseqty.Size = new System.Drawing.Size(115, 25);
            this.lbpurchaseqty.TabIndex = 28;
            this.lbpurchaseqty.Text = "Jumlah Beli";
            // 
            // cbunitpurchase
            // 
            this.cbunitpurchase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunitpurchase.Enabled = false;
            this.cbunitpurchase.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitpurchase.FormattingEnabled = true;
            this.cbunitpurchase.Location = new System.Drawing.Point(404, 251);
            this.cbunitpurchase.Margin = new System.Windows.Forms.Padding(4);
            this.cbunitpurchase.Name = "cbunitpurchase";
            this.cbunitpurchase.Size = new System.Drawing.Size(313, 40);
            this.cbunitpurchase.TabIndex = 32;
            // 
            // lbpurchaseunit
            // 
            this.lbpurchaseunit.AutoSize = true;
            this.lbpurchaseunit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpurchaseunit.Location = new System.Drawing.Point(399, 219);
            this.lbpurchaseunit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpurchaseunit.Name = "lbpurchaseunit";
            this.lbpurchaseunit.Size = new System.Drawing.Size(133, 25);
            this.lbpurchaseunit.TabIndex = 31;
            this.lbpurchaseunit.Text = "Kemasan Beli";
            // 
            // numpcsincontainer
            // 
            this.numpcsincontainer.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpcsincontainer.Location = new System.Drawing.Point(48, 354);
            this.numpcsincontainer.Margin = new System.Windows.Forms.Padding(4);
            this.numpcsincontainer.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numpcsincontainer.Name = "numpcsincontainer";
            this.numpcsincontainer.Size = new System.Drawing.Size(318, 39);
            this.numpcsincontainer.TabIndex = 34;
            this.numpcsincontainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numpcsincontainer.ValueChanged += new System.EventHandler(this.numQuantityAndPriceValueChanged);
            // 
            // lbpcsincontainer
            // 
            this.lbpcsincontainer.AutoSize = true;
            this.lbpcsincontainer.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpcsincontainer.Location = new System.Drawing.Point(43, 322);
            this.lbpcsincontainer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpcsincontainer.Name = "lbpcsincontainer";
            this.lbpcsincontainer.Size = new System.Drawing.Size(257, 25);
            this.lbpcsincontainer.TabIndex = 33;
            this.lbpcsincontainer.Text = "Jumlah Eceran Perkemasan";
            // 
            // cbpcsunit
            // 
            this.cbpcsunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpcsunit.Enabled = false;
            this.cbpcsunit.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpcsunit.FormattingEnabled = true;
            this.cbpcsunit.Location = new System.Drawing.Point(404, 354);
            this.cbpcsunit.Margin = new System.Windows.Forms.Padding(4);
            this.cbpcsunit.Name = "cbpcsunit";
            this.cbpcsunit.Size = new System.Drawing.Size(313, 40);
            this.cbpcsunit.TabIndex = 36;
            // 
            // lbpcsunit
            // 
            this.lbpcsunit.AutoSize = true;
            this.lbpcsunit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpcsunit.Location = new System.Drawing.Point(399, 322);
            this.lbpcsunit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpcsunit.Name = "lbpcsunit";
            this.lbpcsunit.Size = new System.Drawing.Size(160, 25);
            this.lbpcsunit.TabIndex = 35;
            this.lbpcsunit.Text = "Kemasan Eceran";
            // 
            // tbtotal
            // 
            this.tbtotal.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotal.Location = new System.Drawing.Point(48, 451);
            this.tbtotal.Margin = new System.Windows.Forms.Padding(4);
            this.tbtotal.Multiline = true;
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.ReadOnly = true;
            this.tbtotal.Size = new System.Drawing.Size(318, 33);
            this.tbtotal.TabIndex = 37;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.Location = new System.Drawing.Point(43, 419);
            this.lbtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(192, 25);
            this.lbtotal.TabIndex = 38;
            this.lbtotal.Text = "Total Barang Eceran";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(404, 451);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(313, 67);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddEditPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 564);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.cbpcsunit);
            this.Controls.Add(this.lbpcsunit);
            this.Controls.Add(this.numpcsincontainer);
            this.Controls.Add(this.lbpcsincontainer);
            this.Controls.Add(this.cbunitpurchase);
            this.Controls.Add(this.lbpurchaseunit);
            this.Controls.Add(this.numpurchaseqty);
            this.Controls.Add(this.lbpurchaseqty);
            this.Controls.Add(this.tbpurchaseprice);
            this.Controls.Add(this.lbpurchaseprice);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbname);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditPurchase";
            this.Text = "HaskaTech POS";
            this.Title = "Pengaturan Pembelian";
            this.Load += new System.EventHandler(this.AddEditPurchase_Load);
            this.Controls.SetChildIndex(this.lbname, 0);
            this.Controls.SetChildIndex(this.tbname, 0);
            this.Controls.SetChildIndex(this.lbpurchaseprice, 0);
            this.Controls.SetChildIndex(this.tbpurchaseprice, 0);
            this.Controls.SetChildIndex(this.lbpurchaseqty, 0);
            this.Controls.SetChildIndex(this.numpurchaseqty, 0);
            this.Controls.SetChildIndex(this.lbpurchaseunit, 0);
            this.Controls.SetChildIndex(this.cbunitpurchase, 0);
            this.Controls.SetChildIndex(this.lbpcsincontainer, 0);
            this.Controls.SetChildIndex(this.numpcsincontainer, 0);
            this.Controls.SetChildIndex(this.lbpcsunit, 0);
            this.Controls.SetChildIndex(this.cbpcsunit, 0);
            this.Controls.SetChildIndex(this.tbtotal, 0);
            this.Controls.SetChildIndex(this.lbtotal, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tbpurchaseprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpurchaseqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpcsincontainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Button btnSave;
    }
}