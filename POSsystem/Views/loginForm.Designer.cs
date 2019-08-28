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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbPOS = new System.Windows.Forms.Label();
            this.btmasuk = new System.Windows.Forms.Button();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.lbkatasandi = new System.Windows.Forms.Label();
            this.lbnama = new System.Windows.Forms.Label();
            this.llblSettings = new System.Windows.Forms.LinkLabel();
            this.pbposicon = new System.Windows.Forms.PictureBox();
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
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(327, 213);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(236, 26);
            this.tbpassword.TabIndex = 10;
            this.tbpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginEnter_KeyDown);
            // 
            // tbusername
            // 
            this.tbusername.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(327, 140);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(236, 26);
            this.tbusername.TabIndex = 9;
            this.tbusername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginEnter_KeyDown);
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
            // llblSettings
            // 
            this.llblSettings.AutoSize = true;
            this.llblSettings.LinkColor = System.Drawing.Color.SteelBlue;
            this.llblSettings.Location = new System.Drawing.Point(502, 343);
            this.llblSettings.Name = "llblSettings";
            this.llblSettings.Size = new System.Drawing.Size(61, 13);
            this.llblSettings.TabIndex = 14;
            this.llblSettings.TabStop = true;
            this.llblSettings.Text = "SETTINGS";
            this.llblSettings.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.llblSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSettings_LinkClicked);
            // 
            // pbposicon
            // 
            this.pbposicon.ErrorImage = null;
            this.pbposicon.Image = global::POSsystem.Properties.Resources._49_512;
            this.pbposicon.Location = new System.Drawing.Point(41, 41);
            this.pbposicon.Name = "pbposicon";
            this.pbposicon.Size = new System.Drawing.Size(259, 293);
            this.pbposicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbposicon.TabIndex = 12;
            this.pbposicon.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 375);
            this.Controls.Add(this.llblSettings);
            this.Controls.Add(this.lbPOS);
            this.Controls.Add(this.pbposicon);
            this.Controls.Add(this.btmasuk);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.lbkatasandi);
            this.Controls.Add(this.lbnama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HaskaTech POS";
            ((System.ComponentModel.ISupportInitialize)(this.pbposicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPOS;
        private System.Windows.Forms.PictureBox pbposicon;
        private System.Windows.Forms.Button btmasuk;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label lbkatasandi;
        private System.Windows.Forms.Label lbnama;
        private System.Windows.Forms.LinkLabel llblSettings;
    }
}

