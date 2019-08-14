namespace POSsystem
{
    partial class LoginForm
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
            this.lbPOS = new System.Windows.Forms.Label();
            this.pbposicon = new System.Windows.Forms.PictureBox();
            this.btmasuk = new System.Windows.Forms.Button();
            this.tbkatasandi = new System.Windows.Forms.TextBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.lbkatasandi = new System.Windows.Forms.Label();
            this.lbnama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbposicon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPOS
            // 
            this.lbPOS.AutoSize = true;
            this.lbPOS.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPOS.ForeColor = System.Drawing.Color.Teal;
            this.lbPOS.Location = new System.Drawing.Point(363, 22);
            this.lbPOS.Name = "lbPOS";
            this.lbPOS.Size = new System.Drawing.Size(142, 75);
            this.lbPOS.TabIndex = 13;
            this.lbPOS.Text = "POS";
            // 
            // pbposicon
            // 
            this.pbposicon.ErrorImage = null;
            this.pbposicon.Image = global::POSsystem.Properties.Resources.POS_icon;
            this.pbposicon.Location = new System.Drawing.Point(41, 41);
            this.pbposicon.Name = "pbposicon";
            this.pbposicon.Size = new System.Drawing.Size(259, 293);
            this.pbposicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbposicon.TabIndex = 12;
            this.pbposicon.TabStop = false;
            // 
            // btmasuk
            // 
            this.btmasuk.BackColor = System.Drawing.Color.Teal;
            this.btmasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmasuk.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmasuk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btmasuk.Location = new System.Drawing.Point(327, 258);
            this.btmasuk.Name = "btmasuk";
            this.btmasuk.Size = new System.Drawing.Size(236, 60);
            this.btmasuk.TabIndex = 11;
            this.btmasuk.Text = "Masuk";
            this.btmasuk.UseVisualStyleBackColor = false;
            this.btmasuk.Click += new System.EventHandler(this.btmasuk_Click);
            // 
            // tbkatasandi
            // 
            this.tbkatasandi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbkatasandi.Location = new System.Drawing.Point(327, 213);
            this.tbkatasandi.Name = "tbkatasandi";
            this.tbkatasandi.Size = new System.Drawing.Size(236, 26);
            this.tbkatasandi.TabIndex = 10;
            // 
            // tbnama
            // 
            this.tbnama.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnama.Location = new System.Drawing.Point(327, 140);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(236, 26);
            this.tbnama.TabIndex = 9;
            // 
            // lbkatasandi
            // 
            this.lbkatasandi.AutoSize = true;
            this.lbkatasandi.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkatasandi.Location = new System.Drawing.Point(322, 182);
            this.lbkatasandi.Name = "lbkatasandi";
            this.lbkatasandi.Size = new System.Drawing.Size(121, 28);
            this.lbkatasandi.TabIndex = 8;
            this.lbkatasandi.Text = "Kata Sandi";
            // 
            // lbnama
            // 
            this.lbnama.AutoSize = true;
            this.lbnama.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnama.Location = new System.Drawing.Point(322, 109);
            this.lbnama.Name = "lbnama";
            this.lbnama.Size = new System.Drawing.Size(72, 28);
            this.lbnama.TabIndex = 7;
            this.lbnama.Text = "Nama";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 375);
            this.Controls.Add(this.lbPOS);
            this.Controls.Add(this.pbposicon);
            this.Controls.Add(this.btmasuk);
            this.Controls.Add(this.tbkatasandi);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.lbkatasandi);
            this.Controls.Add(this.lbnama);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbposicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPOS;
        private System.Windows.Forms.PictureBox pbposicon;
        private System.Windows.Forms.Button btmasuk;
        private System.Windows.Forms.TextBox tbkatasandi;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Label lbkatasandi;
        private System.Windows.Forms.Label lbnama;
    }
}

