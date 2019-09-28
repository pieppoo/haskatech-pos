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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nbqty)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbmerek
            // 
            this.lbmerek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbmerek.AutoSize = true;
            this.lbmerek.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmerek.Location = new System.Drawing.Point(5, 1);
            this.lbmerek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmerek.Name = "lbmerek";
            this.lbmerek.Size = new System.Drawing.Size(69, 25);
            this.lbmerek.TabIndex = 15;
            this.lbmerek.Text = "Merek";
            // 
            // lbname
            // 
            this.lbname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(4, 5);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(135, 25);
            this.lbname.TabIndex = 17;
            this.lbname.Text = "Nama Produk";
            // 
            // tbname
            // 
            this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbname.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(4, 32);
            this.tbname.Margin = new System.Windows.Forms.Padding(4);
            this.tbname.MaxLength = 50;
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(708, 39);
            this.tbname.TabIndex = 1;
            // 
            // cbbrand
            // 
            this.cbbrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbrand.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbrand.FormattingEnabled = true;
            this.cbbrand.Location = new System.Drawing.Point(5, 30);
            this.cbbrand.Margin = new System.Windows.Forms.Padding(4);
            this.cbbrand.Name = "cbbrand";
            this.cbbrand.Size = new System.Drawing.Size(707, 40);
            this.cbbrand.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(24, 500);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(728, 76);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // cbunitpcs
            // 
            this.cbunitpcs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbunitpcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunitpcs.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitpcs.FormattingEnabled = true;
            this.cbunitpcs.Location = new System.Drawing.Point(5, 31);
            this.cbunitpcs.Name = "cbunitpcs";
            this.cbunitpcs.Size = new System.Drawing.Size(713, 40);
            this.cbunitpcs.TabIndex = 4;
            // 
            // lbunitpcs
            // 
            this.lbunitpcs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbunitpcs.AutoSize = true;
            this.lbunitpcs.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitpcs.Location = new System.Drawing.Point(5, 3);
            this.lbunitpcs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbunitpcs.Name = "lbunitpcs";
            this.lbunitpcs.Size = new System.Drawing.Size(160, 25);
            this.lbunitpcs.TabIndex = 41;
            this.lbunitpcs.Text = "Kemasan Eceran";
            // 
            // cbunitbulk
            // 
            this.cbunitbulk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbunitbulk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunitbulk.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitbulk.FormattingEnabled = true;
            this.cbunitbulk.Location = new System.Drawing.Point(5, 31);
            this.cbunitbulk.Name = "cbunitbulk";
            this.cbunitbulk.Size = new System.Drawing.Size(713, 40);
            this.cbunitbulk.TabIndex = 2;
            // 
            // lbbulkunit
            // 
            this.lbbulkunit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbbulkunit.AutoSize = true;
            this.lbbulkunit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbulkunit.Location = new System.Drawing.Point(5, 3);
            this.lbbulkunit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbulkunit.Name = "lbbulkunit";
            this.lbbulkunit.Size = new System.Drawing.Size(164, 25);
            this.lbbulkunit.TabIndex = 39;
            this.lbbulkunit.Text = "Kemasan Borong";
            // 
            // name_mandatory
            // 
            this.name_mandatory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_mandatory.AutoSize = true;
            this.name_mandatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_mandatory.ForeColor = System.Drawing.Color.Red;
            this.name_mandatory.Location = new System.Drawing.Point(135, 6);
            this.name_mandatory.Name = "name_mandatory";
            this.name_mandatory.Size = new System.Drawing.Size(18, 24);
            this.name_mandatory.TabIndex = 43;
            this.name_mandatory.Text = "*";
            // 
            // nbqty
            // 
            this.nbqty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nbqty.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbqty.Location = new System.Drawing.Point(5, 23);
            this.nbqty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nbqty.Name = "nbqty";
            this.nbqty.Size = new System.Drawing.Size(713, 39);
            this.nbqty.TabIndex = 3;
            // 
            // lbqty
            // 
            this.lbqty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbqty.AutoSize = true;
            this.lbqty.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqty.Location = new System.Drawing.Point(5, -5);
            this.lbqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbqty.Name = "lbqty";
            this.lbqty.Size = new System.Drawing.Size(33, 25);
            this.lbqty.TabIndex = 45;
            this.lbqty.Text = "isi";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 400);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbrand);
            this.panel1.Controls.Add(this.lbmerek);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 74);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbname);
            this.panel2.Controls.Add(this.lbname);
            this.panel2.Controls.Add(this.name_mandatory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 74);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbunitbulk);
            this.panel3.Controls.Add(this.lbbulkunit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 74);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nbqty);
            this.panel4.Controls.Add(this.lbqty);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(722, 74);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbunitpcs);
            this.panel5.Controls.Add(this.lbunitpcs);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 323);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(722, 74);
            this.panel5.TabIndex = 1;
            // 
            // AddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSave);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditProduct";
            this.Text = "HaskaTech POS";
            this.Title = "Pengaturan Produk";
            this.Load += new System.EventHandler(this.AddEditProduct_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nbqty)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}