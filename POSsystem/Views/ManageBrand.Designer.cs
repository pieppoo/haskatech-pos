namespace POSsystem
{
    partial class ManageBrand
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbbrandmanagement = new System.Windows.Forms.Label();
            this.gvbrand = new System.Windows.Forms.DataGridView();
            this.btdeletebrand = new System.Windows.Forms.Button();
            this.bteditbrand = new System.Windows.Forms.Button();
            this.btaddbrand = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remaark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvbrand)).BeginInit();
            this.SuspendLayout();
            // 
            // lbbrandmanagement
            // 
            this.lbbrandmanagement.AutoSize = true;
            this.lbbrandmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbrandmanagement.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbbrandmanagement.Location = new System.Drawing.Point(307, 37);
            this.lbbrandmanagement.Name = "lbbrandmanagement";
            this.lbbrandmanagement.Size = new System.Drawing.Size(146, 29);
            this.lbbrandmanagement.TabIndex = 9;
            this.lbbrandmanagement.Text = "Daftar Brand";
            // 
            // gvbrand
            // 
            this.gvbrand.AllowUserToAddRows = false;
            this.gvbrand.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvbrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvbrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvbrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.No,
            this.brandname,
            this.remaark});
            this.gvbrand.Location = new System.Drawing.Point(35, 115);
            this.gvbrand.MultiSelect = false;
            this.gvbrand.Name = "gvbrand";
            this.gvbrand.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvbrand.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvbrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvbrand.Size = new System.Drawing.Size(611, 256);
            this.gvbrand.TabIndex = 12;
            // 
            // btdeletebrand
            // 
            this.btdeletebrand.BackColor = System.Drawing.Color.Teal;
            this.btdeletebrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeletebrand.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeletebrand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdeletebrand.Location = new System.Drawing.Point(473, 392);
            this.btdeletebrand.Name = "btdeletebrand";
            this.btdeletebrand.Size = new System.Drawing.Size(173, 62);
            this.btdeletebrand.TabIndex = 15;
            this.btdeletebrand.Text = "Hapus Brand";
            this.btdeletebrand.UseVisualStyleBackColor = false;
            this.btdeletebrand.Click += new System.EventHandler(this.btdeletebrand_Click);
            // 
            // bteditbrand
            // 
            this.bteditbrand.BackColor = System.Drawing.Color.Teal;
            this.bteditbrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditbrand.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditbrand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bteditbrand.Location = new System.Drawing.Point(254, 392);
            this.bteditbrand.Name = "bteditbrand";
            this.bteditbrand.Size = new System.Drawing.Size(171, 62);
            this.bteditbrand.TabIndex = 14;
            this.bteditbrand.Text = "Edit Brand";
            this.bteditbrand.UseVisualStyleBackColor = false;
            this.bteditbrand.Click += new System.EventHandler(this.bteditbrand_Click);
            // 
            // btaddbrand
            // 
            this.btaddbrand.BackColor = System.Drawing.Color.Teal;
            this.btaddbrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaddbrand.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddbrand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btaddbrand.Location = new System.Drawing.Point(35, 392);
            this.btaddbrand.Name = "btaddbrand";
            this.btaddbrand.Size = new System.Drawing.Size(172, 62);
            this.btaddbrand.TabIndex = 13;
            this.btaddbrand.Text = "Tambah Brand";
            this.btaddbrand.UseVisualStyleBackColor = false;
            this.btaddbrand.Click += new System.EventHandler(this.btaddbrand_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // brandname
            // 
            this.brandname.HeaderText = "Brand Name";
            this.brandname.Name = "brandname";
            this.brandname.ReadOnly = true;
            // 
            // remaark
            // 
            this.remaark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remaark.HeaderText = "Keterangan";
            this.remaark.Name = "remaark";
            this.remaark.ReadOnly = true;
            // 
            // ManageBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 482);
            this.Controls.Add(this.btdeletebrand);
            this.Controls.Add(this.bteditbrand);
            this.Controls.Add(this.btaddbrand);
            this.Controls.Add(this.gvbrand);
            this.Controls.Add(this.lbbrandmanagement);
            this.Name = "ManageBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageBrand";
            this.Load += new System.EventHandler(this.ManageBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvbrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbbrandmanagement;
        private System.Windows.Forms.DataGridView gvbrand;
        private System.Windows.Forms.Button btdeletebrand;
        private System.Windows.Forms.Button bteditbrand;
        private System.Windows.Forms.Button btaddbrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandname;
        private System.Windows.Forms.DataGridViewTextBoxColumn remaark;
    }
}