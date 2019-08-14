namespace POSsystem
{
    partial class AddEditBrand
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
            this.lbbrandname = new System.Windows.Forms.Label();
            this.tbbrandname = new System.Windows.Forms.TextBox();
            this.tbremark = new System.Windows.Forms.TextBox();
            this.lbremark = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbbrandname
            // 
            this.lbbrandname.AutoSize = true;
            this.lbbrandname.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbrandname.Location = new System.Drawing.Point(43, 84);
            this.lbbrandname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbrandname.Name = "lbbrandname";
            this.lbbrandname.Size = new System.Drawing.Size(140, 28);
            this.lbbrandname.TabIndex = 12;
            this.lbbrandname.Text = "Nama Brand";
            // 
            // tbbrandname
            // 
            this.tbbrandname.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbrandname.Location = new System.Drawing.Point(43, 116);
            this.tbbrandname.Margin = new System.Windows.Forms.Padding(4);
            this.tbbrandname.Name = "tbbrandname";
            this.tbbrandname.Size = new System.Drawing.Size(320, 36);
            this.tbbrandname.TabIndex = 13;
            // 
            // tbremark
            // 
            this.tbremark.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbremark.Location = new System.Drawing.Point(43, 198);
            this.tbremark.Margin = new System.Windows.Forms.Padding(4);
            this.tbremark.Multiline = true;
            this.tbremark.Name = "tbremark";
            this.tbremark.Size = new System.Drawing.Size(320, 121);
            this.tbremark.TabIndex = 15;
            // 
            // lbremark
            // 
            this.lbremark.AutoSize = true;
            this.lbremark.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbremark.Location = new System.Drawing.Point(43, 166);
            this.lbremark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbremark.Name = "lbremark";
            this.lbremark.Size = new System.Drawing.Size(94, 28);
            this.lbremark.TabIndex = 14;
            this.lbremark.Text = "Remark";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(43, 356);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(320, 67);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // AddEditBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 449);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbremark);
            this.Controls.Add(this.lbremark);
            this.Controls.Add(this.tbbrandname);
            this.Controls.Add(this.lbbrandname);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditBrand";
            this.Text = "Pengaturan Brand";
            this.Title = "Pengaturan Brand";
            this.Load += new System.EventHandler(this.AddEditBrand_Load);
            this.Controls.SetChildIndex(this.lbbrandname, 0);
            this.Controls.SetChildIndex(this.tbbrandname, 0);
            this.Controls.SetChildIndex(this.lbremark, 0);
            this.Controls.SetChildIndex(this.tbremark, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbbrandname;
        private System.Windows.Forms.TextBox tbbrandname;
        private System.Windows.Forms.TextBox tbremark;
        private System.Windows.Forms.Label lbremark;
        private System.Windows.Forms.Button btnSave;
    }
}