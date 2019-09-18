namespace POSsystem.Views
{
    partial class AddEditProduct
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
            this.lbmerek = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.cbbrand = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbunitpcs = new System.Windows.Forms.ComboBox();
            this.lbunitpcs = new System.Windows.Forms.Label();
            this.cbunitbulk = new System.Windows.Forms.ComboBox();
            this.lbbulkunit = new System.Windows.Forms.Label();
            this.name_mandatory = new System.Windows.Forms.Label();
            this.nbqty = new System.Windows.Forms.NumericUpDown();
            this.lbqty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbqty)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmerek
            // 
            this.lbmerek.AutoSize = true;
            this.lbmerek.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmerek.Location = new System.Drawing.Point(19, 82);
            this.lbmerek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmerek.Name = "lbmerek";
            this.lbmerek.Size = new System.Drawing.Size(69, 25);
            this.lbmerek.TabIndex = 15;
            this.lbmerek.Text = "Merek";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(19, 172);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(135, 25);
            this.lbname.TabIndex = 17;
            this.lbname.Text = "Nama Produk";
            // 
            // tbname
            // 
            this.tbname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbname.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(24, 201);
            this.tbname.Margin = new System.Windows.Forms.Padding(4);
            this.tbname.Multiline = true;
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(472, 43);
            this.tbname.TabIndex = 1;
            // 
            // cbbrand
            // 
            this.cbbrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbrand.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbrand.FormattingEnabled = true;
            this.cbbrand.Location = new System.Drawing.Point(24, 111);
            this.cbbrand.Margin = new System.Windows.Forms.Padding(4);
            this.cbbrand.Name = "cbbrand";
            this.cbbrand.Size = new System.Drawing.Size(472, 40);
            this.cbbrand.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(24, 364);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(472, 57);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // cbunitpcs
            // 
            this.cbunitpcs.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitpcs.FormattingEnabled = true;
            this.cbunitpcs.Location = new System.Drawing.Point(337, 290);
            this.cbunitpcs.Name = "cbunitpcs";
            this.cbunitpcs.Size = new System.Drawing.Size(159, 40);
            this.cbunitpcs.TabIndex = 3;
            // 
            // lbunitpcs
            // 
            this.lbunitpcs.AutoSize = true;
            this.lbunitpcs.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitpcs.Location = new System.Drawing.Point(332, 262);
            this.lbunitpcs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbunitpcs.Name = "lbunitpcs";
            this.lbunitpcs.Size = new System.Drawing.Size(160, 25);
            this.lbunitpcs.TabIndex = 41;
            this.lbunitpcs.Text = "Kemasan Eceran";
            // 
            // cbunitbulk
            // 
            this.cbunitbulk.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitbulk.FormattingEnabled = true;
            this.cbunitbulk.Location = new System.Drawing.Point(24, 290);
            this.cbunitbulk.Name = "cbunitbulk";
            this.cbunitbulk.Size = new System.Drawing.Size(159, 40);
            this.cbunitbulk.TabIndex = 2;
            // 
            // lbbulkunit
            // 
            this.lbbulkunit.AutoSize = true;
            this.lbbulkunit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbulkunit.Location = new System.Drawing.Point(19, 262);
            this.lbbulkunit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbulkunit.Name = "lbbulkunit";
            this.lbbulkunit.Size = new System.Drawing.Size(164, 25);
            this.lbbulkunit.TabIndex = 39;
            this.lbbulkunit.Text = "Kemasan Borong";
            // 
            // name_mandatory
            // 
            this.name_mandatory.AutoSize = true;
            this.name_mandatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_mandatory.ForeColor = System.Drawing.Color.Red;
            this.name_mandatory.Location = new System.Drawing.Point(147, 173);
            this.name_mandatory.Name = "name_mandatory";
            this.name_mandatory.Size = new System.Drawing.Size(18, 24);
            this.name_mandatory.TabIndex = 43;
            this.name_mandatory.Text = "*";
            // 
            // nbqty
            // 
            this.nbqty.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbqty.Location = new System.Drawing.Point(212, 290);
            this.nbqty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nbqty.Name = "nbqty";
            this.nbqty.Size = new System.Drawing.Size(96, 39);
            this.nbqty.TabIndex = 44;
            // 
            // lbqty
            // 
            this.lbqty.AutoSize = true;
            this.lbqty.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqty.Location = new System.Drawing.Point(207, 262);
            this.lbqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbqty.Name = "lbqty";
            this.lbqty.Size = new System.Drawing.Size(33, 25);
            this.lbqty.TabIndex = 45;
            this.lbqty.Text = "isi";
            // 
            // AddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 455);
            this.Controls.Add(this.lbqty);
            this.Controls.Add(this.nbqty);
            this.Controls.Add(this.name_mandatory);
            this.Controls.Add(this.cbunitpcs);
            this.Controls.Add(this.lbunitpcs);
            this.Controls.Add(this.cbunitbulk);
            this.Controls.Add(this.lbbulkunit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbbrand);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lbmerek);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditProduct";
            this.Text = "HaskaTech POS";
            this.Title = "Pengaturan Produk";
            this.Load += new System.EventHandler(this.AddEditProduct_Load);
            this.Controls.SetChildIndex(this.lbmerek, 0);
            this.Controls.SetChildIndex(this.lbname, 0);
            this.Controls.SetChildIndex(this.tbname, 0);
            this.Controls.SetChildIndex(this.cbbrand, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.lbbulkunit, 0);
            this.Controls.SetChildIndex(this.cbunitbulk, 0);
            this.Controls.SetChildIndex(this.lbunitpcs, 0);
            this.Controls.SetChildIndex(this.cbunitpcs, 0);
            this.Controls.SetChildIndex(this.name_mandatory, 0);
            this.Controls.SetChildIndex(this.nbqty, 0);
            this.Controls.SetChildIndex(this.lbqty, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nbqty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbmerek;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.ComboBox cbbrand;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbunitpcs;
        private System.Windows.Forms.Label lbunitpcs;
        private System.Windows.Forms.ComboBox cbunitbulk;
        private System.Windows.Forms.Label lbbulkunit;
        private System.Windows.Forms.Label name_mandatory;
        private System.Windows.Forms.NumericUpDown nbqty;
        private System.Windows.Forms.Label lbqty;
    }
}