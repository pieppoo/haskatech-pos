namespace POSsystem.Views
{
    partial class AddEditUnitRelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditUnitRelation));
            this.lbunitrelate = new System.Windows.Forms.Label();
            this.rbyes = new System.Windows.Forms.RadioButton();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.lbpcs = new System.Windows.Forms.Label();
            this.cbunitpcs = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbitemname = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbunitrelate
            // 
            this.lbunitrelate.AutoSize = true;
            this.lbunitrelate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbunitrelate.Location = new System.Drawing.Point(2, 18);
            this.lbunitrelate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbunitrelate.Name = "lbunitrelate";
            this.lbunitrelate.Size = new System.Drawing.Size(127, 22);
            this.lbunitrelate.TabIndex = 3;
            this.lbunitrelate.Text = "Unit Berkaitan";
            // 
            // rbyes
            // 
            this.rbyes.AutoSize = true;
            this.rbyes.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbyes.Location = new System.Drawing.Point(163, 18);
            this.rbyes.Margin = new System.Windows.Forms.Padding(2);
            this.rbyes.Name = "rbyes";
            this.rbyes.Size = new System.Drawing.Size(47, 26);
            this.rbyes.TabIndex = 0;
            this.rbyes.TabStop = true;
            this.rbyes.Text = "Ya";
            this.rbyes.UseVisualStyleBackColor = true;
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbno.Location = new System.Drawing.Point(231, 16);
            this.rbno.Margin = new System.Windows.Forms.Padding(2);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(74, 26);
            this.rbno.TabIndex = 1;
            this.rbno.TabStop = true;
            this.rbno.Text = "Tidak";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // lbpcs
            // 
            this.lbpcs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpcs.AutoSize = true;
            this.lbpcs.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpcs.Location = new System.Drawing.Point(2, 55);
            this.lbpcs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpcs.Name = "lbpcs";
            this.lbpcs.Size = new System.Drawing.Size(144, 22);
            this.lbpcs.TabIndex = 4;
            this.lbpcs.Text = "Kemasan Eceran";
            // 
            // cbunitpcs
            // 
            this.cbunitpcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbunitpcs.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbunitpcs.FormattingEnabled = true;
            this.cbunitpcs.Location = new System.Drawing.Point(163, 52);
            this.cbunitpcs.Margin = new System.Windows.Forms.Padding(2);
            this.cbunitpcs.Name = "cbunitpcs";
            this.cbunitpcs.Size = new System.Drawing.Size(142, 30);
            this.cbunitpcs.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbno);
            this.groupBox1.Controls.Add(this.cbunitpcs);
            this.groupBox1.Controls.Add(this.lbpcs);
            this.groupBox1.Controls.Add(this.lbunitrelate);
            this.groupBox1.Controls.Add(this.rbyes);
            this.groupBox1.Location = new System.Drawing.Point(16, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(326, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(16, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(326, 51);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbitemname
            // 
            this.lbitemname.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbitemname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbitemname.Location = new System.Drawing.Point(16, 9);
            this.lbitemname.Name = "lbitemname";
            this.lbitemname.Size = new System.Drawing.Size(326, 53);
            this.lbitemname.TabIndex = 2;
            this.lbitemname.Text = "Nama Produk";
            this.lbitemname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEditUnitRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 253);
            this.Controls.Add(this.lbitemname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEditUnitRelation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HaskaTech POS";
            this.Load += new System.EventHandler(this.AddEditUnitRelation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbunitrelate;
        private System.Windows.Forms.RadioButton rbyes;
        private System.Windows.Forms.RadioButton rbno;
        private System.Windows.Forms.Label lbpcs;
        private System.Windows.Forms.ComboBox cbunitpcs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbitemname;
    }
}