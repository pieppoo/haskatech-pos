namespace POSsystem.Views
{
    partial class AddEditUnit
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
            this.lbunitcode = new System.Windows.Forms.Label();
            this.tbunitcode = new System.Windows.Forms.TextBox();
            this.lbunitname = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbunitname = new System.Windows.Forms.TextBox();
            this.name_mandatory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbunitcode
            // 
            this.lbunitcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbunitcode.AutoSize = true;
            this.lbunitcode.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitcode.Location = new System.Drawing.Point(22, 92);
            this.lbunitcode.Name = "lbunitcode";
            this.lbunitcode.Size = new System.Drawing.Size(144, 25);
            this.lbunitcode.TabIndex = 11;
            this.lbunitcode.Text = "Kode Kemasan";
            // 
            // tbunitcode
            // 
            this.tbunitcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbunitcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbunitcode.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbunitcode.Location = new System.Drawing.Point(27, 124);
            this.tbunitcode.Margin = new System.Windows.Forms.Padding(4);
            this.tbunitcode.MaxLength = 5;
            this.tbunitcode.Name = "tbunitcode";
            this.tbunitcode.Size = new System.Drawing.Size(320, 39);
            this.tbunitcode.TabIndex = 0;
            this.tbunitcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbunitcode_KeyDown);
            // 
            // lbunitname
            // 
            this.lbunitname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbunitname.AutoSize = true;
            this.lbunitname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitname.Location = new System.Drawing.Point(27, 187);
            this.lbunitname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbunitname.Name = "lbunitname";
            this.lbunitname.Size = new System.Drawing.Size(149, 25);
            this.lbunitname.TabIndex = 16;
            this.lbunitname.Text = "Nama Kemasan";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(27, 301);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(320, 67);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbunitname
            // 
            this.tbunitname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbunitname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbunitname.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbunitname.Location = new System.Drawing.Point(27, 219);
            this.tbunitname.Margin = new System.Windows.Forms.Padding(4);
            this.tbunitname.MaxLength = 50;
            this.tbunitname.Name = "tbunitname";
            this.tbunitname.Size = new System.Drawing.Size(320, 39);
            this.tbunitname.TabIndex = 1;
            this.tbunitname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbunitname_KeyDown);
            // 
            // name_mandatory
            // 
            this.name_mandatory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_mandatory.AutoSize = true;
            this.name_mandatory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_mandatory.ForeColor = System.Drawing.Color.Red;
            this.name_mandatory.Location = new System.Drawing.Point(158, 96);
            this.name_mandatory.Name = "name_mandatory";
            this.name_mandatory.Size = new System.Drawing.Size(18, 24);
            this.name_mandatory.TabIndex = 45;
            this.name_mandatory.Text = "*";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(168, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "*";
            // 
            // AddEditUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_mandatory);
            this.Controls.Add(this.tbunitname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbunitname);
            this.Controls.Add(this.tbunitcode);
            this.Controls.Add(this.lbunitcode);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditUnit";
            this.Text = "HaskaTech POS";
            this.Title = "Pengaturan Unit";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.AddEditUnit_Load);
            this.Controls.SetChildIndex(this.lbunitcode, 0);
            this.Controls.SetChildIndex(this.tbunitcode, 0);
            this.Controls.SetChildIndex(this.lbunitname, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.tbunitname, 0);
            this.Controls.SetChildIndex(this.name_mandatory, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbunitcode;
        private System.Windows.Forms.TextBox tbunitcode;
        private System.Windows.Forms.Label lbunitname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbunitname;
        private System.Windows.Forms.Label name_mandatory;
        private System.Windows.Forms.Label label1;
    }
}