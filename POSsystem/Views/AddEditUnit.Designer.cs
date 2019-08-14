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
            this.SuspendLayout();
            // 
            // lbunitcode
            // 
            this.lbunitcode.AutoSize = true;
            this.lbunitcode.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitcode.Location = new System.Drawing.Point(22, 92);
            this.lbunitcode.Name = "lbunitcode";
            this.lbunitcode.Size = new System.Drawing.Size(113, 28);
            this.lbunitcode.TabIndex = 11;
            this.lbunitcode.Text = "Unit Code";
            // 
            // tbunitcode
            // 
            this.tbunitcode.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbunitcode.Location = new System.Drawing.Point(27, 124);
            this.tbunitcode.Margin = new System.Windows.Forms.Padding(4);
            this.tbunitcode.MaxLength = 5;
            this.tbunitcode.Name = "tbunitcode";
            this.tbunitcode.Size = new System.Drawing.Size(320, 36);
            this.tbunitcode.TabIndex = 14;
            // 
            // lbunitname
            // 
            this.lbunitname.AutoSize = true;
            this.lbunitname.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitname.Location = new System.Drawing.Point(27, 187);
            this.lbunitname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbunitname.Name = "lbunitname";
            this.lbunitname.Size = new System.Drawing.Size(121, 28);
            this.lbunitname.TabIndex = 16;
            this.lbunitname.Text = "Unit Name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(27, 301);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(320, 67);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbunitname
            // 
            this.tbunitname.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbunitname.Location = new System.Drawing.Point(27, 219);
            this.tbunitname.Margin = new System.Windows.Forms.Padding(4);
            this.tbunitname.Name = "tbunitname";
            this.tbunitname.Size = new System.Drawing.Size(320, 36);
            this.tbunitname.TabIndex = 36;
            // 
            // AddEditUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 403);
            this.Controls.Add(this.tbunitname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbunitname);
            this.Controls.Add(this.tbunitcode);
            this.Controls.Add(this.lbunitcode);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEditUnit";
            this.Text = "Pengaturan Unit";
            this.Title = "Pengaturan Unit";
            this.Load += new System.EventHandler(this.AddEditUnit_Load);
            this.Controls.SetChildIndex(this.lbunitcode, 0);
            this.Controls.SetChildIndex(this.tbunitcode, 0);
            this.Controls.SetChildIndex(this.lbunitname, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.tbunitname, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbunitcode;
        private System.Windows.Forms.TextBox tbunitcode;
        private System.Windows.Forms.Label lbunitname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbunitname;
    }
}