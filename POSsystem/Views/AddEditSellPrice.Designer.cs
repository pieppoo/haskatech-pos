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
            this.tbitemname = new System.Windows.Forms.TextBox();
            this.lbunitsell = new System.Windows.Forms.Label();
            this.lbsellprice = new System.Windows.Forms.Label();
            this.cbunitsell = new System.Windows.Forms.ComboBox();
            this.tbsellprice = new System.Windows.Forms.NumericUpDown();
            this.btsave = new System.Windows.Forms.Button();
            this.lbbarcodeno = new System.Windows.Forms.Label();
            this.tbbarcodeno = new System.Windows.Forms.TextBox();
            this.btscan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbsellprice)).BeginInit();
            this.SuspendLayout();
            // 
            // lbitemname
            // 
            this.lbitemname.AutoSize = true;
            this.lbitemname.Font = new System.Drawing.Font("Cambria", 18F);
            this.lbitemname.Location = new System.Drawing.Point(36, 111);
            this.lbitemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbitemname.Name = "lbitemname";
            this.lbitemname.Size = new System.Drawing.Size(153, 28);
            this.lbitemname.TabIndex = 18;
            this.lbitemname.Text = "Nama Produk";
            // 
            // tbitemname
            // 
            this.tbitemname.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbitemname.Location = new System.Drawing.Point(40, 152);
            this.tbitemname.Margin = new System.Windows.Forms.Padding(4);
            this.tbitemname.Multiline = true;
            this.tbitemname.Name = "tbitemname";
            this.tbitemname.ReadOnly = true;
            this.tbitemname.Size = new System.Drawing.Size(352, 93);
            this.tbitemname.TabIndex = 19;
            // 
            // lbunitsell
            // 
            this.lbunitsell.AutoSize = true;
            this.lbunitsell.Font = new System.Drawing.Font("Cambria", 18F);
            this.lbunitsell.Location = new System.Drawing.Point(261, 267);
            this.lbunitsell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbunitsell.Name = "lbunitsell";
            this.lbunitsell.Size = new System.Drawing.Size(73, 28);
            this.lbunitsell.TabIndex = 20;
            this.lbunitsell.Text = "/ Unit";
            // 
            // lbsellprice
            // 
            this.lbsellprice.AutoSize = true;
            this.lbsellprice.Font = new System.Drawing.Font("Cambria", 18F);
            this.lbsellprice.Location = new System.Drawing.Point(36, 267);
            this.lbsellprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsellprice.Name = "lbsellprice";
            this.lbsellprice.Size = new System.Drawing.Size(118, 28);
            this.lbsellprice.TabIndex = 22;
            this.lbsellprice.Text = "Harga Jual";
            // 
            // cbunitsell
            // 
            this.cbunitsell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunitsell.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitsell.FormattingEnabled = true;
            this.cbunitsell.Location = new System.Drawing.Point(266, 299);
            this.cbunitsell.Margin = new System.Windows.Forms.Padding(4);
            this.cbunitsell.Name = "cbunitsell";
            this.cbunitsell.Size = new System.Drawing.Size(126, 36);
            this.cbunitsell.TabIndex = 24;
            // 
            // tbsellprice
            // 
            this.tbsellprice.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsellprice.Location = new System.Drawing.Point(40, 299);
            this.tbsellprice.Margin = new System.Windows.Forms.Padding(4);
            this.tbsellprice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.tbsellprice.Name = "tbsellprice";
            this.tbsellprice.Size = new System.Drawing.Size(208, 36);
            this.tbsellprice.TabIndex = 25;
            this.tbsellprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.Color.SteelBlue;
            this.btsave.FlatAppearance.BorderSize = 0;
            this.btsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.Transparent;
            this.btsave.Location = new System.Drawing.Point(40, 438);
            this.btsave.Margin = new System.Windows.Forms.Padding(4);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(357, 67);
            this.btsave.TabIndex = 26;
            this.btsave.Text = "Simpan";
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // lbbarcodeno
            // 
            this.lbbarcodeno.AutoSize = true;
            this.lbbarcodeno.Font = new System.Drawing.Font("Cambria", 18F);
            this.lbbarcodeno.Location = new System.Drawing.Point(37, 353);
            this.lbbarcodeno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbarcodeno.Name = "lbbarcodeno";
            this.lbbarcodeno.Size = new System.Drawing.Size(132, 28);
            this.lbbarcodeno.TabIndex = 27;
            this.lbbarcodeno.Text = "Barcode No";
            // 
            // tbbarcodeno
            // 
            this.tbbarcodeno.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbarcodeno.Location = new System.Drawing.Point(40, 385);
            this.tbbarcodeno.Name = "tbbarcodeno";
            this.tbbarcodeno.Size = new System.Drawing.Size(208, 36);
            this.tbbarcodeno.TabIndex = 28;
            // 
            // btscan
            // 
            this.btscan.BackColor = System.Drawing.Color.DarkViolet;
            this.btscan.FlatAppearance.BorderSize = 0;
            this.btscan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btscan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btscan.ForeColor = System.Drawing.Color.Transparent;
            this.btscan.Location = new System.Drawing.Point(266, 385);
            this.btscan.Margin = new System.Windows.Forms.Padding(4);
            this.btscan.Name = "btscan";
            this.btscan.Size = new System.Drawing.Size(131, 36);
            this.btscan.TabIndex = 29;
            this.btscan.Text = "scan barcode";
            this.btscan.UseVisualStyleBackColor = false;
            // 
            // AddEditSellPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 545);
            this.Controls.Add(this.btscan);
            this.Controls.Add(this.tbbarcodeno);
            this.Controls.Add(this.lbbarcodeno);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.tbsellprice);
            this.Controls.Add(this.cbunitsell);
            this.Controls.Add(this.lbsellprice);
            this.Controls.Add(this.lbunitsell);
            this.Controls.Add(this.tbitemname);
            this.Controls.Add(this.lbitemname);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditSellPrice";
            this.Text = "Pengaturan Harga";
            this.Title = "Harga Jual";
            this.Load += new System.EventHandler(this.AddEditSellPrice_Load);
            this.Controls.SetChildIndex(this.lbitemname, 0);
            this.Controls.SetChildIndex(this.tbitemname, 0);
            this.Controls.SetChildIndex(this.lbunitsell, 0);
            this.Controls.SetChildIndex(this.lbsellprice, 0);
            this.Controls.SetChildIndex(this.cbunitsell, 0);
            this.Controls.SetChildIndex(this.tbsellprice, 0);
            this.Controls.SetChildIndex(this.btsave, 0);
            this.Controls.SetChildIndex(this.lbbarcodeno, 0);
            this.Controls.SetChildIndex(this.tbbarcodeno, 0);
            this.Controls.SetChildIndex(this.btscan, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tbsellprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbitemname;
        private System.Windows.Forms.TextBox tbitemname;
        private System.Windows.Forms.Label lbunitsell;
        private System.Windows.Forms.Label lbsellprice;
        private System.Windows.Forms.ComboBox cbunitsell;
        private System.Windows.Forms.NumericUpDown tbsellprice;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Label lbbarcodeno;
        private System.Windows.Forms.TextBox tbbarcodeno;
        private System.Windows.Forms.Button btscan;
    }
}