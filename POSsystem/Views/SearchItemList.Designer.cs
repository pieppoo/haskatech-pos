namespace POSsystem.Views
{
    partial class SearchItemList
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
            this.gvresultitem = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvresultitem)).BeginInit();
            this.SuspendLayout();
            // 
            // gvresultitem
            // 
            this.gvresultitem.AllowUserToAddRows = false;
            this.gvresultitem.AllowUserToDeleteRows = false;
            this.gvresultitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvresultitem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.itemname,
            this.unitsale,
            this.saleprice,
            this.barcodeno});
            this.gvresultitem.Location = new System.Drawing.Point(28, 75);
            this.gvresultitem.MultiSelect = false;
            this.gvresultitem.Name = "gvresultitem";
            this.gvresultitem.ReadOnly = true;
            this.gvresultitem.RowHeadersVisible = false;
            this.gvresultitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvresultitem.Size = new System.Drawing.Size(573, 309);
            this.gvresultitem.TabIndex = 11;
            this.gvresultitem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvresultitem_CellDoubleClick);
            this.gvresultitem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvresultitem_KeyDown);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // itemname
            // 
            this.itemname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemname.HeaderText = "Nama Barang";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            // 
            // unitsale
            // 
            this.unitsale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.unitsale.HeaderText = "Kemasan";
            this.unitsale.Name = "unitsale";
            this.unitsale.ReadOnly = true;
            this.unitsale.Width = 92;
            // 
            // saleprice
            // 
            this.saleprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.saleprice.DefaultCellStyle = dataGridViewCellStyle1;
            this.saleprice.HeaderText = "Harga Jual (Rp)";
            this.saleprice.Name = "saleprice";
            this.saleprice.ReadOnly = true;
            this.saleprice.Width = 97;
            // 
            // barcodeno
            // 
            this.barcodeno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.barcodeno.HeaderText = "No. Barcode";
            this.barcodeno.Name = "barcodeno";
            this.barcodeno.ReadOnly = true;
            this.barcodeno.Width = 103;
            // 
            // SearchItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 409);
            this.Controls.Add(this.gvresultitem);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SearchItemList";
            this.Text = "HaskaTech POS";
            this.Title = "Pilih Barang";
            this.Load += new System.EventHandler(this.SearchItemList_Load);
            this.Controls.SetChildIndex(this.gvresultitem, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvresultitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvresultitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsale;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeno;
    }
}