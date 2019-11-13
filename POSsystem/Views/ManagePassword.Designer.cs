namespace POSsystem.Views
{
    partial class ManagePassword
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
            this.tbnewpswd = new System.Windows.Forms.TextBox();
            this.lbnewpswd = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.tbnewpswdconfirm = new System.Windows.Forms.TextBox();
            this.lbnewpswdconfirm = new System.Windows.Forms.Label();
            this.btnchange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbnewpswd
            // 
            this.tbnewpswd.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnewpswd.Location = new System.Drawing.Point(42, 160);
            this.tbnewpswd.Name = "tbnewpswd";
            this.tbnewpswd.PasswordChar = '*';
            this.tbnewpswd.Size = new System.Drawing.Size(236, 36);
            this.tbnewpswd.TabIndex = 12;
            this.tbnewpswd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbnewpswd_KeyDown);
            // 
            // lbnewpswd
            // 
            this.lbnewpswd.AutoSize = true;
            this.lbnewpswd.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnewpswd.Location = new System.Drawing.Point(37, 132);
            this.lbnewpswd.Name = "lbnewpswd";
            this.lbnewpswd.Size = new System.Drawing.Size(156, 25);
            this.lbnewpswd.TabIndex = 13;
            this.lbnewpswd.Text = "Kata Sandi Baru";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbname.Location = new System.Drawing.Point(37, 92);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(108, 25);
            this.lbname.TabIndex = 14;
            this.lbname.Text = "Nama user";
            // 
            // tbnewpswdconfirm
            // 
            this.tbnewpswdconfirm.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnewpswdconfirm.Location = new System.Drawing.Point(42, 236);
            this.tbnewpswdconfirm.Name = "tbnewpswdconfirm";
            this.tbnewpswdconfirm.PasswordChar = '*';
            this.tbnewpswdconfirm.Size = new System.Drawing.Size(236, 36);
            this.tbnewpswdconfirm.TabIndex = 15;
            this.tbnewpswdconfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbnewpswdconfirm_KeyDown);
            // 
            // lbnewpswdconfirm
            // 
            this.lbnewpswdconfirm.AutoSize = true;
            this.lbnewpswdconfirm.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnewpswdconfirm.Location = new System.Drawing.Point(37, 208);
            this.lbnewpswdconfirm.Name = "lbnewpswdconfirm";
            this.lbnewpswdconfirm.Size = new System.Drawing.Size(211, 25);
            this.lbnewpswdconfirm.TabIndex = 16;
            this.lbnewpswdconfirm.Text = "Konfirmasi Kata Sandi";
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.Color.Teal;
            this.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchange.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnchange.Location = new System.Drawing.Point(42, 290);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(236, 60);
            this.btnchange.TabIndex = 17;
            this.btnchange.Text = "Ganti";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // ManagePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 370);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.tbnewpswdconfirm);
            this.Controls.Add(this.lbnewpswdconfirm);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.tbnewpswd);
            this.Controls.Add(this.lbnewpswd);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManagePassword";
            this.Text = "HaskaTech POS";
            this.Title = "Ganti Kata Sandi";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.ManagePassword_Load);
            this.Controls.SetChildIndex(this.lbnewpswd, 0);
            this.Controls.SetChildIndex(this.tbnewpswd, 0);
            this.Controls.SetChildIndex(this.lbname, 0);
            this.Controls.SetChildIndex(this.lbnewpswdconfirm, 0);
            this.Controls.SetChildIndex(this.tbnewpswdconfirm, 0);
            this.Controls.SetChildIndex(this.btnchange, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbnewpswd;
        private System.Windows.Forms.Label lbnewpswd;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbnewpswdconfirm;
        private System.Windows.Forms.Label lbnewpswdconfirm;
        private System.Windows.Forms.Button btnchange;
    }
}