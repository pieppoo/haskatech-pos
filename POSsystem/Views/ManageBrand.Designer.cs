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
            // gvbrand
            // 
            this.gvbrand.AllowUserToAddRows = false;
            this.gvbrand.AllowUserToDeleteRows = false;
            this.gvbrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvbrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.No,
            this.brandname,
            this.remaark});
            this.gvbrand.Location = new System.Drawing.Point(24, 76);
            this.gvbrand.Margin = new System.Windows.Forms.Padding(4);
            this.gvbrand.MultiSelect = false;
            this.gvbrand.Name = "gvbrand";
            this.gvbrand.ReadOnly = true;
            this.gvbrand.RowHeadersVisible = false;
            this.gvbrand.RowTemplate.Height = 30;
            this.gvbrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvbrand.Size = new System.Drawing.Size(612, 262);
            this.gvbrand.TabIndex = 12;
            // 
            // btdeletebrand
            // 
            this.btdeletebrand.BackColor = System.Drawing.Color.Teal;
            this.btdeletebrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeletebrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeletebrand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdeletebrand.Location = new System.Drawing.Point(454, 353);
            this.btdeletebrand.Margin = new System.Windows.Forms.Padding(4);
            this.btdeletebrand.Name = "btdeletebrand";
            this.btdeletebrand.Size = new System.Drawing.Size(181, 55);
            this.btdeletebrand.TabIndex = 15;
            this.btdeletebrand.Text = "Hapus Merek";
            this.btdeletebrand.UseVisualStyleBackColor = false;
            this.btdeletebrand.Click += new System.EventHandler(this.btdeletebrand_Click);
            // 
            // bteditbrand
            // 
            this.bteditbrand.BackColor = System.Drawing.Color.Teal;
            this.bteditbrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditbrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditbrand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bteditbrand.Location = new System.Drawing.Point(239, 353);
            this.bteditbrand.Margin = new System.Windows.Forms.Padding(4);
            this.bteditbrand.Name = "bteditbrand";
            this.bteditbrand.Size = new System.Drawing.Size(181, 55);
            this.bteditbrand.TabIndex = 14;
            this.bteditbrand.Text = "Edit Merek";
            this.bteditbrand.UseVisualStyleBackColor = false;
            this.bteditbrand.Click += new System.EventHandler(this.bteditbrand_Click);
            // 
            // btaddbrand
            // 
            this.btaddbrand.BackColor = System.Drawing.Color.Teal;
            this.btaddbrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaddbrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddbrand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btaddbrand.Location = new System.Drawing.Point(24, 353);
            this.btaddbrand.Margin = new System.Windows.Forms.Padding(4);
            this.btaddbrand.Name = "btaddbrand";
            this.btaddbrand.Size = new System.Drawing.Size(181, 55);
            this.btaddbrand.TabIndex = 13;
            this.btaddbrand.Text = "Tambah Merek";
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
            this.brandname.HeaderText = "Nama Merek";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 431);
            this.Controls.Add(this.btdeletebrand);
            this.Controls.Add(this.bteditbrand);
            this.Controls.Add(this.btaddbrand);
            this.Controls.Add(this.gvbrand);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageBrand";
            this.Text = "HaskaTech POS";
            this.Title = "Daftar Merek";
            this.Load += new System.EventHandler(this.ManageBrand_Load);
            this.Controls.SetChildIndex(this.gvbrand, 0);
            this.Controls.SetChildIndex(this.btaddbrand, 0);
            this.Controls.SetChildIndex(this.bteditbrand, 0);
            this.Controls.SetChildIndex(this.btdeletebrand, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvbrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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