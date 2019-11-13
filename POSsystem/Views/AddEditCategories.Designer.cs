namespace POSsystem.Views
{
    partial class AddEditCategories
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
            this.name_mandatory = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbremark = new System.Windows.Forms.TextBox();
            this.lbremark = new System.Windows.Forms.Label();
            this.tbcatname = new System.Windows.Forms.TextBox();
            this.lbcatname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_mandatory
            // 
            this.name_mandatory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_mandatory.AutoSize = true;
            this.name_mandatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_mandatory.ForeColor = System.Drawing.Color.Red;
            this.name_mandatory.Location = new System.Drawing.Point(179, 81);
            this.name_mandatory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_mandatory.Name = "name_mandatory";
            this.name_mandatory.Size = new System.Drawing.Size(18, 24);
            this.name_mandatory.TabIndex = 50;
            this.name_mandatory.Text = "*";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(31, 361);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(323, 65);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // tbremark
            // 
            this.tbremark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbremark.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbremark.Location = new System.Drawing.Point(33, 234);
            this.tbremark.Margin = new System.Windows.Forms.Padding(5);
            this.tbremark.MaxLength = 500;
            this.tbremark.Multiline = true;
            this.tbremark.Name = "tbremark";
            this.tbremark.Size = new System.Drawing.Size(321, 94);
            this.tbremark.TabIndex = 46;
            this.tbremark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbremark_KeyDown);
            // 
            // lbremark
            // 
            this.lbremark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbremark.AutoSize = true;
            this.lbremark.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbremark.Location = new System.Drawing.Point(26, 196);
            this.lbremark.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbremark.Name = "lbremark";
            this.lbremark.Size = new System.Drawing.Size(115, 25);
            this.lbremark.TabIndex = 49;
            this.lbremark.Text = "Keterangan";
            // 
            // tbcatname
            // 
            this.tbcatname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbcatname.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcatname.Location = new System.Drawing.Point(33, 119);
            this.tbcatname.Margin = new System.Windows.Forms.Padding(5);
            this.tbcatname.MaxLength = 50;
            this.tbcatname.Name = "tbcatname";
            this.tbcatname.Size = new System.Drawing.Size(321, 39);
            this.tbcatname.TabIndex = 45;
            this.tbcatname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbcatname_KeyDown);
            // 
            // lbcatname
            // 
            this.lbcatname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcatname.AutoSize = true;
            this.lbcatname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcatname.Location = new System.Drawing.Point(26, 81);
            this.lbcatname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbcatname.Name = "lbcatname";
            this.lbcatname.Size = new System.Drawing.Size(144, 25);
            this.lbcatname.TabIndex = 48;
            this.lbcatname.Text = "Nama Kategori";
            // 
            // AddEditCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 454);
            this.Controls.Add(this.name_mandatory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbremark);
            this.Controls.Add(this.lbremark);
            this.Controls.Add(this.tbcatname);
            this.Controls.Add(this.lbcatname);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditCategories";
            this.Text = "HaskaTech POS";
            this.Title = "Pengaturan Kategori";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.AddEditCategories_Load);
            this.Controls.SetChildIndex(this.lbcatname, 0);
            this.Controls.SetChildIndex(this.tbcatname, 0);
            this.Controls.SetChildIndex(this.lbremark, 0);
            this.Controls.SetChildIndex(this.tbremark, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.name_mandatory, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_mandatory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbremark;
        private System.Windows.Forms.Label lbremark;
        private System.Windows.Forms.TextBox tbcatname;
        private System.Windows.Forms.Label lbcatname;
    }
}