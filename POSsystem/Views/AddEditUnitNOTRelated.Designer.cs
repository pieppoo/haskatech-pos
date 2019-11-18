namespace POSsystem.Views
{
    partial class AddEditUnitNOTRelated
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditUnitNOTRelated));
            this.btnSave = new System.Windows.Forms.Button();
            this.lbqty = new System.Windows.Forms.Label();
            this.cbunitchild = new System.Windows.Forms.ComboBox();
            this.lbunitchild = new System.Windows.Forms.Label();
            this.cbunitparent = new System.Windows.Forms.ComboBox();
            this.lbunitparent = new System.Windows.Forms.Label();
            this.nbqty = new System.Windows.Forms.NumericUpDown();
            this.mandatory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbqty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(13, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(478, 51);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbqty
            // 
            this.lbqty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbqty.AutoSize = true;
            this.lbqty.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqty.Location = new System.Drawing.Point(199, 74);
            this.lbqty.Name = "lbqty";
            this.lbqty.Size = new System.Drawing.Size(67, 22);
            this.lbqty.TabIndex = 5;
            this.lbqty.Text = "Jumlah";
            // 
            // cbunitchild
            // 
            this.cbunitchild.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitchild.FormattingEnabled = true;
            this.cbunitchild.Location = new System.Drawing.Point(329, 99);
            this.cbunitchild.Name = "cbunitchild";
            this.cbunitchild.Size = new System.Drawing.Size(162, 30);
            this.cbunitchild.TabIndex = 2;
            // 
            // lbunitchild
            // 
            this.lbunitchild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbunitchild.AutoSize = true;
            this.lbunitchild.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitchild.Location = new System.Drawing.Point(325, 74);
            this.lbunitchild.Name = "lbunitchild";
            this.lbunitchild.Size = new System.Drawing.Size(144, 22);
            this.lbunitchild.TabIndex = 7;
            this.lbunitchild.Text = "Kemasan Eceran";
            // 
            // cbunitparent
            // 
            this.cbunitparent.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitparent.FormattingEnabled = true;
            this.cbunitparent.Location = new System.Drawing.Point(13, 99);
            this.cbunitparent.Name = "cbunitparent";
            this.cbunitparent.Size = new System.Drawing.Size(162, 30);
            this.cbunitparent.TabIndex = 0;
            // 
            // lbunitparent
            // 
            this.lbunitparent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbunitparent.AutoSize = true;
            this.lbunitparent.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitparent.Location = new System.Drawing.Point(9, 74);
            this.lbunitparent.Name = "lbunitparent";
            this.lbunitparent.Size = new System.Drawing.Size(134, 22);
            this.lbunitparent.TabIndex = 4;
            this.lbunitparent.Text = "Kemasan Besar";
            // 
            // nbqty
            // 
            this.nbqty.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbqty.Location = new System.Drawing.Point(203, 99);
            this.nbqty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbqty.Name = "nbqty";
            this.nbqty.Size = new System.Drawing.Size(94, 30);
            this.nbqty.TabIndex = 1;
            // 
            // mandatory
            // 
            this.mandatory.AutoSize = true;
            this.mandatory.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mandatory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mandatory.Location = new System.Drawing.Point(260, 69);
            this.mandatory.Name = "mandatory";
            this.mandatory.Size = new System.Drawing.Size(22, 28);
            this.mandatory.TabIndex = 6;
            this.mandatory.Text = "*";
            // 
            // AddEditUnitNOTRelated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 232);
            this.Controls.Add(this.mandatory);
            this.Controls.Add(this.nbqty);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbqty);
            this.Controls.Add(this.cbunitchild);
            this.Controls.Add(this.lbunitchild);
            this.Controls.Add(this.cbunitparent);
            this.Controls.Add(this.lbunitparent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditUnitNOTRelated";
            this.Text = "HaskaTech POS";
            this.Title = "Pengaturan Kemasan Produk";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.AddEditUnitNOTRelated_Load);
            this.Controls.SetChildIndex(this.lbunitparent, 0);
            this.Controls.SetChildIndex(this.cbunitparent, 0);
            this.Controls.SetChildIndex(this.lbunitchild, 0);
            this.Controls.SetChildIndex(this.cbunitchild, 0);
            this.Controls.SetChildIndex(this.lbqty, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.nbqty, 0);
            this.Controls.SetChildIndex(this.mandatory, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nbqty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbqty;
        private System.Windows.Forms.ComboBox cbunitchild;
        private System.Windows.Forms.Label lbunitchild;
        private System.Windows.Forms.ComboBox cbunitparent;
        private System.Windows.Forms.Label lbunitparent;
        private System.Windows.Forms.NumericUpDown nbqty;
        private System.Windows.Forms.Label mandatory;
    }
}