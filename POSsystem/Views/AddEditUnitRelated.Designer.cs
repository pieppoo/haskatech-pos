namespace POSsystem.Views
{
    partial class AddEditUnitRelated
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditUnitRelated));
            this.lbunitparent = new System.Windows.Forms.Label();
            this.cbunitparent = new System.Windows.Forms.ComboBox();
            this.cbunitchild = new System.Windows.Forms.ComboBox();
            this.lbunitchild = new System.Windows.Forms.Label();
            this.lbqty = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.nbqtyparent = new System.Windows.Forms.NumericUpDown();
            this.tbchildcopy = new System.Windows.Forms.TextBox();
            this.lbunitchildcopy = new System.Windows.Forms.Label();
            this.nbqtychild = new System.Windows.Forms.NumericUpDown();
            this.lbqtychild = new System.Windows.Forms.Label();
            this.lb2ndchild = new System.Windows.Forms.Label();
            this.tbsecondchild = new System.Windows.Forms.TextBox();
            this.mandator1 = new System.Windows.Forms.Label();
            this.mandatory2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbqtyparent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbqtychild)).BeginInit();
            this.SuspendLayout();
            // 
            // lbunitparent
            // 
            this.lbunitparent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbunitparent.AutoSize = true;
            this.lbunitparent.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitparent.Location = new System.Drawing.Point(28, 72);
            this.lbunitparent.Name = "lbunitparent";
            this.lbunitparent.Size = new System.Drawing.Size(57, 22);
            this.lbunitparent.TabIndex = 7;
            this.lbunitparent.Text = "Unit x";
            // 
            // cbunitparent
            // 
            this.cbunitparent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunitparent.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitparent.FormattingEnabled = true;
            this.cbunitparent.Location = new System.Drawing.Point(32, 97);
            this.cbunitparent.Name = "cbunitparent";
            this.cbunitparent.Size = new System.Drawing.Size(162, 30);
            this.cbunitparent.TabIndex = 0;
            // 
            // cbunitchild
            // 
            this.cbunitchild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunitchild.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitchild.FormattingEnabled = true;
            this.cbunitchild.Location = new System.Drawing.Point(348, 97);
            this.cbunitchild.Name = "cbunitchild";
            this.cbunitchild.Size = new System.Drawing.Size(162, 30);
            this.cbunitchild.TabIndex = 2;
            this.cbunitchild.SelectionChangeCommitted += new System.EventHandler(this.cbunitchild_SelectionChangeCommitted);
            // 
            // lbunitchild
            // 
            this.lbunitchild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbunitchild.AutoSize = true;
            this.lbunitchild.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitchild.Location = new System.Drawing.Point(344, 72);
            this.lbunitchild.Name = "lbunitchild";
            this.lbunitchild.Size = new System.Drawing.Size(83, 22);
            this.lbunitchild.TabIndex = 14;
            this.lbunitchild.Text = "Unit  x+1";
            this.lbunitchild.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbqty
            // 
            this.lbqty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbqty.AutoSize = true;
            this.lbqty.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqty.Location = new System.Drawing.Point(226, 72);
            this.lbqty.Name = "lbqty";
            this.lbqty.Size = new System.Drawing.Size(67, 22);
            this.lbqty.TabIndex = 8;
            this.lbqty.Text = "Jumlah";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(32, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(478, 51);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nbqtyparent
            // 
            this.nbqtyparent.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbqtyparent.Location = new System.Drawing.Point(230, 97);
            this.nbqtyparent.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbqtyparent.Name = "nbqtyparent";
            this.nbqtyparent.Size = new System.Drawing.Size(82, 30);
            this.nbqtyparent.TabIndex = 1;
            // 
            // tbchildcopy
            // 
            this.tbchildcopy.Enabled = false;
            this.tbchildcopy.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbchildcopy.Location = new System.Drawing.Point(32, 179);
            this.tbchildcopy.Name = "tbchildcopy";
            this.tbchildcopy.ReadOnly = true;
            this.tbchildcopy.Size = new System.Drawing.Size(162, 30);
            this.tbchildcopy.TabIndex = 3;
            // 
            // lbunitchildcopy
            // 
            this.lbunitchildcopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbunitchildcopy.AutoSize = true;
            this.lbunitchildcopy.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitchildcopy.Location = new System.Drawing.Point(28, 154);
            this.lbunitchildcopy.Name = "lbunitchildcopy";
            this.lbunitchildcopy.Size = new System.Drawing.Size(83, 22);
            this.lbunitchildcopy.TabIndex = 10;
            this.lbunitchildcopy.Text = "Unit  x+1";
            this.lbunitchildcopy.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // nbqtychild
            // 
            this.nbqtychild.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbqtychild.Location = new System.Drawing.Point(230, 179);
            this.nbqtychild.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbqtychild.Name = "nbqtychild";
            this.nbqtychild.Size = new System.Drawing.Size(82, 30);
            this.nbqtychild.TabIndex = 4;
            // 
            // lbqtychild
            // 
            this.lbqtychild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbqtychild.AutoSize = true;
            this.lbqtychild.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqtychild.Location = new System.Drawing.Point(226, 155);
            this.lbqtychild.Name = "lbqtychild";
            this.lbqtychild.Size = new System.Drawing.Size(67, 22);
            this.lbqtychild.TabIndex = 11;
            this.lbqtychild.Text = "Jumlah";
            // 
            // lb2ndchild
            // 
            this.lb2ndchild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb2ndchild.AutoSize = true;
            this.lb2ndchild.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2ndchild.Location = new System.Drawing.Point(344, 155);
            this.lb2ndchild.Name = "lb2ndchild";
            this.lb2ndchild.Size = new System.Drawing.Size(83, 22);
            this.lb2ndchild.TabIndex = 13;
            this.lb2ndchild.Text = "Unit  x+2";
            this.lb2ndchild.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbsecondchild
            // 
            this.tbsecondchild.Enabled = false;
            this.tbsecondchild.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsecondchild.Location = new System.Drawing.Point(348, 180);
            this.tbsecondchild.Name = "tbsecondchild";
            this.tbsecondchild.ReadOnly = true;
            this.tbsecondchild.Size = new System.Drawing.Size(162, 30);
            this.tbsecondchild.TabIndex = 5;
            // 
            // mandator1
            // 
            this.mandator1.AutoSize = true;
            this.mandator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandator1.ForeColor = System.Drawing.Color.Red;
            this.mandator1.Location = new System.Drawing.Point(286, 70);
            this.mandator1.Name = "mandator1";
            this.mandator1.Size = new System.Drawing.Size(20, 25);
            this.mandator1.TabIndex = 9;
            this.mandator1.Text = "*";
            // 
            // mandatory2
            // 
            this.mandatory2.AutoSize = true;
            this.mandatory2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatory2.ForeColor = System.Drawing.Color.Red;
            this.mandatory2.Location = new System.Drawing.Point(286, 151);
            this.mandatory2.Name = "mandatory2";
            this.mandatory2.Size = new System.Drawing.Size(20, 25);
            this.mandatory2.TabIndex = 12;
            this.mandatory2.Text = "*";
            // 
            // AddEditUnitRelated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 316);
            this.Controls.Add(this.mandatory2);
            this.Controls.Add(this.mandator1);
            this.Controls.Add(this.tbsecondchild);
            this.Controls.Add(this.lb2ndchild);
            this.Controls.Add(this.nbqtychild);
            this.Controls.Add(this.lbqtychild);
            this.Controls.Add(this.lbunitchildcopy);
            this.Controls.Add(this.tbchildcopy);
            this.Controls.Add(this.lbunitchild);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nbqtyparent);
            this.Controls.Add(this.lbqty);
            this.Controls.Add(this.cbunitchild);
            this.Controls.Add(this.cbunitparent);
            this.Controls.Add(this.lbunitparent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditUnitRelated";
            this.Text = "HaskaTech POS";
            this.Title = "Pengaturan Kemasan Produk";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.AddEditUnitRelated_Load);
            this.Controls.SetChildIndex(this.lbunitparent, 0);
            this.Controls.SetChildIndex(this.cbunitparent, 0);
            this.Controls.SetChildIndex(this.cbunitchild, 0);
            this.Controls.SetChildIndex(this.lbqty, 0);
            this.Controls.SetChildIndex(this.nbqtyparent, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.lbunitchild, 0);
            this.Controls.SetChildIndex(this.tbchildcopy, 0);
            this.Controls.SetChildIndex(this.lbunitchildcopy, 0);
            this.Controls.SetChildIndex(this.lbqtychild, 0);
            this.Controls.SetChildIndex(this.nbqtychild, 0);
            this.Controls.SetChildIndex(this.lb2ndchild, 0);
            this.Controls.SetChildIndex(this.tbsecondchild, 0);
            this.Controls.SetChildIndex(this.mandator1, 0);
            this.Controls.SetChildIndex(this.mandatory2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nbqtyparent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbqtychild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbunitparent;
        private System.Windows.Forms.ComboBox cbunitparent;
        private System.Windows.Forms.ComboBox cbunitchild;
        private System.Windows.Forms.Label lbunitchild;
        private System.Windows.Forms.Label lbqty;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nbqtyparent;
        private System.Windows.Forms.TextBox tbchildcopy;
        private System.Windows.Forms.Label lbunitchildcopy;
        private System.Windows.Forms.NumericUpDown nbqtychild;
        private System.Windows.Forms.Label lbqtychild;
        private System.Windows.Forms.Label lb2ndchild;
        private System.Windows.Forms.TextBox tbsecondchild;
        private System.Windows.Forms.Label mandator1;
        private System.Windows.Forms.Label mandatory2;
    }
}