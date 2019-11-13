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
            this.cbqty = new System.Windows.Forms.ComboBox();
            this.lbqty = new System.Windows.Forms.Label();
            this.cbunitchild = new System.Windows.Forms.ComboBox();
            this.lbunitchild = new System.Windows.Forms.Label();
            this.cbunitparent = new System.Windows.Forms.ComboBox();
            this.lbunitparent = new System.Windows.Forms.Label();
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
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // cbqty
            // 
            this.cbqty.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbqty.FormattingEnabled = true;
            this.cbqty.Location = new System.Drawing.Point(212, 99);
            this.cbqty.Name = "cbqty";
            this.cbqty.Size = new System.Drawing.Size(80, 30);
            this.cbqty.TabIndex = 29;
            // 
            // lbqty
            // 
            this.lbqty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbqty.AutoSize = true;
            this.lbqty.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqty.Location = new System.Drawing.Point(207, 74);
            this.lbqty.Name = "lbqty";
            this.lbqty.Size = new System.Drawing.Size(67, 22);
            this.lbqty.TabIndex = 28;
            this.lbqty.Text = "Jumlah";
            // 
            // cbunitchild
            // 
            this.cbunitchild.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitchild.FormattingEnabled = true;
            this.cbunitchild.Location = new System.Drawing.Point(329, 99);
            this.cbunitchild.Name = "cbunitchild";
            this.cbunitchild.Size = new System.Drawing.Size(162, 30);
            this.cbunitchild.TabIndex = 27;
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
            this.lbunitchild.TabIndex = 26;
            this.lbunitchild.Text = "Kemasan Eceran";
            // 
            // cbunitparent
            // 
            this.cbunitparent.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitparent.FormattingEnabled = true;
            this.cbunitparent.Location = new System.Drawing.Point(13, 99);
            this.cbunitparent.Name = "cbunitparent";
            this.cbunitparent.Size = new System.Drawing.Size(162, 30);
            this.cbunitparent.TabIndex = 25;
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
            this.lbunitparent.TabIndex = 24;
            this.lbunitparent.Text = "Kemasan Besar";
            // 
            // AddEditUnitNOTRelated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 232);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbqty);
            this.Controls.Add(this.lbqty);
            this.Controls.Add(this.cbunitchild);
            this.Controls.Add(this.lbunitchild);
            this.Controls.Add(this.cbunitparent);
            this.Controls.Add(this.lbunitparent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddEditUnitNOTRelated";
            this.Text = "HaskaTech POS";
            this.Title = "Pengaturan Kemasan Produk";
            this.Load += new System.EventHandler(this.AddEditUnitNOTRelated_Load);
            this.Controls.SetChildIndex(this.lbunitparent, 0);
            this.Controls.SetChildIndex(this.cbunitparent, 0);
            this.Controls.SetChildIndex(this.lbunitchild, 0);
            this.Controls.SetChildIndex(this.cbunitchild, 0);
            this.Controls.SetChildIndex(this.lbqty, 0);
            this.Controls.SetChildIndex(this.cbqty, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbqty;
        private System.Windows.Forms.Label lbqty;
        private System.Windows.Forms.ComboBox cbunitchild;
        private System.Windows.Forms.Label lbunitchild;
        private System.Windows.Forms.ComboBox cbunitparent;
        private System.Windows.Forms.Label lbunitparent;
    }
}