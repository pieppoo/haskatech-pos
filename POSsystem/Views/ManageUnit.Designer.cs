namespace POSsystem.Views
{
    partial class ManageUnit
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
            this.btdeleteunit = new System.Windows.Forms.Button();
            this.bteditunit = new System.Windows.Forms.Button();
            this.btaddunit = new System.Windows.Forms.Button();
            this.gvunititem = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvunititem)).BeginInit();
            this.SuspendLayout();
            // 
            // btdeleteunit
            // 
            this.btdeleteunit.BackColor = System.Drawing.Color.Teal;
            this.btdeleteunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdeleteunit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdeleteunit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btdeleteunit.Location = new System.Drawing.Point(168, 354);
            this.btdeleteunit.Margin = new System.Windows.Forms.Padding(4);
            this.btdeleteunit.Name = "btdeleteunit";
            this.btdeleteunit.Size = new System.Drawing.Size(106, 59);
            this.btdeleteunit.TabIndex = 14;
            this.btdeleteunit.Text = "Hapus Kemasan";
            this.btdeleteunit.UseVisualStyleBackColor = false;
            this.btdeleteunit.Click += new System.EventHandler(this.btdeleteunit_Click);
            // 
            // bteditunit
            // 
            this.bteditunit.BackColor = System.Drawing.Color.Teal;
            this.bteditunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditunit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditunit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bteditunit.Location = new System.Drawing.Point(309, 354);
            this.bteditunit.Margin = new System.Windows.Forms.Padding(4);
            this.bteditunit.Name = "bteditunit";
            this.bteditunit.Size = new System.Drawing.Size(106, 59);
            this.bteditunit.TabIndex = 13;
            this.bteditunit.Text = "Edit Kemasan";
            this.bteditunit.UseVisualStyleBackColor = false;
            this.bteditunit.Click += new System.EventHandler(this.bteditunit_Click);
            // 
            // btaddunit
            // 
            this.btaddunit.BackColor = System.Drawing.Color.Teal;
            this.btaddunit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btaddunit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddunit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btaddunit.Location = new System.Drawing.Point(27, 354);
            this.btaddunit.Margin = new System.Windows.Forms.Padding(4);
            this.btaddunit.Name = "btaddunit";
            this.btaddunit.Size = new System.Drawing.Size(106, 59);
            this.btaddunit.TabIndex = 12;
            this.btaddunit.Text = "Tambah Kemasan";
            this.btaddunit.UseVisualStyleBackColor = false;
            this.btaddunit.Click += new System.EventHandler(this.btaddunit_Click);
            // 
            // gvunititem
            // 
            this.gvunititem.AllowUserToAddRows = false;
            this.gvunititem.AllowUserToDeleteRows = false;
            this.gvunititem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvunititem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.code,
            this.name});
            this.gvunititem.Location = new System.Drawing.Point(27, 76);
            this.gvunititem.MultiSelect = false;
            this.gvunititem.Name = "gvunititem";
            this.gvunititem.ReadOnly = true;
            this.gvunititem.RowHeadersVisible = false;
            this.gvunititem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvunititem.Size = new System.Drawing.Size(388, 262);
            this.gvunititem.TabIndex = 15;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.code.HeaderText = "Kode Kemasan";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 118;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Nama Kemasan";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // ManageUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 440);
            this.Controls.Add(this.gvunititem);
            this.Controls.Add(this.btdeleteunit);
            this.Controls.Add(this.bteditunit);
            this.Controls.Add(this.btaddunit);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageUnit";
            this.Text = "HaskaTech POS";
            this.Title = "Daftar Kemasan";
            this.Load += new System.EventHandler(this.ManageUnit_Load);
            this.Controls.SetChildIndex(this.btaddunit, 0);
            this.Controls.SetChildIndex(this.bteditunit, 0);
            this.Controls.SetChildIndex(this.btdeleteunit, 0);
            this.Controls.SetChildIndex(this.gvunititem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvunititem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btdeleteunit;
        private System.Windows.Forms.Button bteditunit;
        private System.Windows.Forms.Button btaddunit;
        private System.Windows.Forms.DataGridView gvunititem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}