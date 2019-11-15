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
            this.lbprodcat = new System.Windows.Forms.Label();
            this.name_mandatory = new System.Windows.Forms.Label();
            this.cbprodcat = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbmerek
            // 
            this.lbmerek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbmerek.AutoSize = true;
            this.lbmerek.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmerek.Location = new System.Drawing.Point(13, 5);
            this.lbmerek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmerek.Name = "lbmerek";
            this.lbmerek.Size = new System.Drawing.Size(69, 25);
            this.lbmerek.TabIndex = 1;
            this.lbmerek.Text = "Merek";
            // 
            // lbname
            // 
            this.lbname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(14, 4);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(135, 25);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Nama Produk";
            // 
            // tbname
            // 
            this.tbname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbname.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(19, 27);
            this.tbname.Margin = new System.Windows.Forms.Padding(4);
            this.tbname.MaxLength = 50;
            this.tbname.Multiline = true;
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(421, 88);
            this.tbname.TabIndex = 0;
            // 
            // cbbrand
            // 
            this.cbbrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbrand.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbrand.FormattingEnabled = true;
            this.cbbrand.Location = new System.Drawing.Point(18, 34);
            this.cbbrand.Margin = new System.Windows.Forms.Padding(4);
            this.cbbrand.Name = "cbbrand";
            this.cbbrand.Size = new System.Drawing.Size(191, 36);
            this.cbbrand.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(24, 294);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(464, 59);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // lbprodcat
            // 
            this.lbprodcat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbprodcat.AutoSize = true;
            this.lbprodcat.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprodcat.Location = new System.Drawing.Point(14, 5);
            this.lbprodcat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbprodcat.Name = "lbprodcat";
            this.lbprodcat.Size = new System.Drawing.Size(88, 25);
            this.lbprodcat.TabIndex = 1;
            this.lbprodcat.Text = "Kategori";
            // 
            // name_mandatory
            // 
            this.name_mandatory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_mandatory.AutoSize = true;
            this.name_mandatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_mandatory.ForeColor = System.Drawing.Color.Red;
            this.name_mandatory.Location = new System.Drawing.Point(142, 4);
            this.name_mandatory.Name = "name_mandatory";
            this.name_mandatory.Size = new System.Drawing.Size(18, 24);
            this.name_mandatory.TabIndex = 2;
            this.name_mandatory.Text = "*";
            // 
            // cbprodcat
            // 
            this.cbprodcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbprodcat.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbprodcat.FormattingEnabled = true;
            this.cbprodcat.Location = new System.Drawing.Point(19, 34);
            this.cbprodcat.Margin = new System.Windows.Forms.Padding(4);
            this.cbprodcat.Name = "cbprodcat";
            this.cbprodcat.Size = new System.Drawing.Size(191, 36);
            this.cbprodcat.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 217);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbprodcat);
            this.panel1.Controls.Add(this.lbprodcat);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 79);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbrand);
            this.panel2.Controls.Add(this.lbmerek);
            this.panel2.Location = new System.Drawing.Point(235, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 79);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.tbname);
            this.panel5.Controls.Add(this.name_mandatory);
            this.panel5.Controls.Add(this.lbname);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 123);
            this.panel5.TabIndex = 2;
            // 
            // AddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 377);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSave);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditProduct";
            this.Text = "HaskaTech POS";
            this.Title = "Pengaturan Produk";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.AddEditProduct_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label lbprodcat;
        private System.Windows.Forms.Label name_mandatory;
        private System.Windows.Forms.ComboBox cbprodcat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
    }
}