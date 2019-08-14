namespace POSsystem.Views
{
    partial class ManageSellingPrice
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
            this.gvsellprice = new System.Windows.Forms.DataGridView();
            this.btnnewprice = new System.Windows.Forms.Button();
            this.bteditprice = new System.Windows.Forms.Button();
            this.btndeleteprice = new System.Windows.Forms.Button();
            this.warehouseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvsellprice)).BeginInit();
            this.SuspendLayout();
            // 
            // gvsellprice
            // 
            this.gvsellprice.AllowUserToAddRows = false;
            this.gvsellprice.AllowUserToDeleteRows = false;
            this.gvsellprice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvsellprice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warehouseid,
            this.itemid,
            this.sellid,
            this.ItemName,
            this.sellprice,
            this.perUnit,
            this.barcodeno});
            this.gvsellprice.Location = new System.Drawing.Point(31, 125);
            this.gvsellprice.Margin = new System.Windows.Forms.Padding(4);
            this.gvsellprice.MultiSelect = false;
            this.gvsellprice.Name = "gvsellprice";
            this.gvsellprice.ReadOnly = true;
            this.gvsellprice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvsellprice.Size = new System.Drawing.Size(662, 299);
            this.gvsellprice.TabIndex = 15;
            // 
            // btnnewprice
            // 
            this.btnnewprice.BackColor = System.Drawing.Color.Teal;
            this.btnnewprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewprice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewprice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnnewprice.Location = new System.Drawing.Point(31, 464);
            this.btnnewprice.Margin = new System.Windows.Forms.Padding(4);
            this.btnnewprice.Name = "btnnewprice";
            this.btnnewprice.Size = new System.Drawing.Size(167, 62);
            this.btnnewprice.TabIndex = 16;
            this.btnnewprice.Text = "Harga Baru";
            this.btnnewprice.UseVisualStyleBackColor = false;
            this.btnnewprice.Click += new System.EventHandler(this.btnnewprice_Click);
            // 
            // bteditprice
            // 
            this.bteditprice.BackColor = System.Drawing.Color.Teal;
            this.bteditprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditprice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditprice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bteditprice.Location = new System.Drawing.Point(278, 464);
            this.bteditprice.Margin = new System.Windows.Forms.Padding(4);
            this.bteditprice.Name = "bteditprice";
            this.bteditprice.Size = new System.Drawing.Size(167, 62);
            this.bteditprice.TabIndex = 17;
            this.bteditprice.Text = "Edit Harga";
            this.bteditprice.UseVisualStyleBackColor = false;
            this.bteditprice.Click += new System.EventHandler(this.bteditprice_Click);
            // 
            // btndeleteprice
            // 
            this.btndeleteprice.BackColor = System.Drawing.Color.Teal;
            this.btndeleteprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteprice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteprice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndeleteprice.Location = new System.Drawing.Point(525, 464);
            this.btndeleteprice.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteprice.Name = "btndeleteprice";
            this.btndeleteprice.Size = new System.Drawing.Size(167, 62);
            this.btndeleteprice.TabIndex = 18;
            this.btndeleteprice.Text = "Hapus Harga";
            this.btndeleteprice.UseVisualStyleBackColor = false;
            this.btndeleteprice.Click += new System.EventHandler(this.btndeleteprice_Click);
            // 
            // warehouseid
            // 
            this.warehouseid.HeaderText = "warehouseid";
            this.warehouseid.Name = "warehouseid";
            this.warehouseid.ReadOnly = true;
            this.warehouseid.Visible = false;
            // 
            // itemid
            // 
            this.itemid.HeaderText = "itemid";
            this.itemid.Name = "itemid";
            this.itemid.ReadOnly = true;
            this.itemid.Visible = false;
            // 
            // sellid
            // 
            this.sellid.HeaderText = "sellid";
            this.sellid.Name = "sellid";
            this.sellid.ReadOnly = true;
            this.sellid.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ItemName.HeaderText = "Produk";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 78;
            // 
            // sellprice
            // 
            this.sellprice.HeaderText = "Harga Jual";
            this.sellprice.Name = "sellprice";
            this.sellprice.ReadOnly = true;
            // 
            // perUnit
            // 
            this.perUnit.HeaderText = "/ unit";
            this.perUnit.Name = "perUnit";
            this.perUnit.ReadOnly = true;
            // 
            // barcodeno
            // 
            this.barcodeno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barcodeno.HeaderText = "barcodeno";
            this.barcodeno.Name = "barcodeno";
            this.barcodeno.ReadOnly = true;
            // 
            // ManageSellingPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 558);
            this.Controls.Add(this.btndeleteprice);
            this.Controls.Add(this.bteditprice);
            this.Controls.Add(this.btnnewprice);
            this.Controls.Add(this.gvsellprice);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageSellingPrice";
            this.Text = "Daftar Harga Jual";
            this.Title = "Daftar Harga Jual";
            this.Load += new System.EventHandler(this.ManageSellingPrice_Load);
            this.Controls.SetChildIndex(this.gvsellprice, 0);
            this.Controls.SetChildIndex(this.btnnewprice, 0);
            this.Controls.SetChildIndex(this.bteditprice, 0);
            this.Controls.SetChildIndex(this.btndeleteprice, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvsellprice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gvsellprice;
        private System.Windows.Forms.Button btnnewprice;
        private System.Windows.Forms.Button bteditprice;
        private System.Windows.Forms.Button btndeleteprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn perUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeno;
    }
}