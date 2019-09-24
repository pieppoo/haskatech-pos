namespace POSsystem.Views
{
    partial class PayForm
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
            this.tboritotal = new System.Windows.Forms.TextBox();
            this.lboritotal = new System.Windows.Forms.Label();
            this.lbpay = new System.Windows.Forms.Label();
            this.nbpay = new System.Windows.Forms.NumericUpDown();
            this.nbdiscount = new System.Windows.Forms.NumericUpDown();
            this.lbdiscount = new System.Windows.Forms.Label();
            this.tbpay = new System.Windows.Forms.Button();
            this.tbbalance = new System.Windows.Forms.TextBox();
            this.lbbalance = new System.Windows.Forms.Label();
            this.tbtotaltopay = new System.Windows.Forms.TextBox();
            this.lbtotaltopay = new System.Windows.Forms.Label();
            this.rbcardflag = new System.Windows.Forms.RadioButton();
            this.tbreferenceno = new System.Windows.Forms.TextBox();
            this.lbreference = new System.Windows.Forms.Label();
            this.rbcash = new System.Windows.Forms.RadioButton();
            this.lbcardno = new System.Windows.Forms.Label();
            this.tbcardno = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nbpay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbdiscount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboritotal
            // 
            this.tboritotal.BackColor = System.Drawing.Color.Silver;
            this.tboritotal.Enabled = false;
            this.tboritotal.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboritotal.Location = new System.Drawing.Point(13, 186);
            this.tboritotal.Name = "tboritotal";
            this.tboritotal.ReadOnly = true;
            this.tboritotal.Size = new System.Drawing.Size(201, 39);
            this.tboritotal.TabIndex = 19;
            this.tboritotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lboritotal
            // 
            this.lboritotal.AutoSize = true;
            this.lboritotal.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboritotal.Location = new System.Drawing.Point(13, 158);
            this.lboritotal.Name = "lboritotal";
            this.lboritotal.Size = new System.Drawing.Size(151, 25);
            this.lboritotal.TabIndex = 18;
            this.lboritotal.Text = "Total Awal (Rp)";
            // 
            // lbpay
            // 
            this.lbpay.AutoSize = true;
            this.lbpay.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpay.Location = new System.Drawing.Point(253, 299);
            this.lbpay.Name = "lbpay";
            this.lbpay.Size = new System.Drawing.Size(111, 25);
            this.lbpay.TabIndex = 20;
            this.lbpay.Text = "Bayar (Rp)";
            // 
            // nbpay
            // 
            this.nbpay.Enabled = false;
            this.nbpay.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbpay.Location = new System.Drawing.Point(253, 326);
            this.nbpay.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nbpay.Name = "nbpay";
            this.nbpay.ReadOnly = true;
            this.nbpay.Size = new System.Drawing.Size(227, 47);
            this.nbpay.TabIndex = 3;
            this.nbpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbpay.ThousandsSeparator = true;
            this.nbpay.ValueChanged += new System.EventHandler(this.payamounFinaltotal_changed);
            this.nbpay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberbox_KeyPress);
            // 
            // nbdiscount
            // 
            this.nbdiscount.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbdiscount.Location = new System.Drawing.Point(13, 260);
            this.nbdiscount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nbdiscount.Name = "nbdiscount";
            this.nbdiscount.Size = new System.Drawing.Size(201, 39);
            this.nbdiscount.TabIndex = 2;
            this.nbdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nbdiscount.ThousandsSeparator = true;
            this.nbdiscount.ValueChanged += new System.EventHandler(this.nbgotdiscount);
            this.nbdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberbox_KeyPress);
            // 
            // lbdiscount
            // 
            this.lbdiscount.AutoSize = true;
            this.lbdiscount.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiscount.Location = new System.Drawing.Point(13, 232);
            this.lbdiscount.Name = "lbdiscount";
            this.lbdiscount.Size = new System.Drawing.Size(121, 25);
            this.lbdiscount.TabIndex = 23;
            this.lbdiscount.Text = "Diskon (Rp)";
            // 
            // tbpay
            // 
            this.tbpay.BackColor = System.Drawing.Color.Teal;
            this.tbpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbpay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbpay.Location = new System.Drawing.Point(13, 494);
            this.tbpay.Margin = new System.Windows.Forms.Padding(4);
            this.tbpay.Name = "tbpay";
            this.tbpay.Size = new System.Drawing.Size(467, 57);
            this.tbpay.TabIndex = 6;
            this.tbpay.Text = "Bayar";
            this.tbpay.UseVisualStyleBackColor = false;
            this.tbpay.Click += new System.EventHandler(this.tbpay_Click);
            // 
            // tbbalance
            // 
            this.tbbalance.BackColor = System.Drawing.Color.Silver;
            this.tbbalance.Enabled = false;
            this.tbbalance.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbalance.Location = new System.Drawing.Point(253, 427);
            this.tbbalance.Name = "tbbalance";
            this.tbbalance.ReadOnly = true;
            this.tbbalance.Size = new System.Drawing.Size(227, 47);
            this.tbbalance.TabIndex = 29;
            this.tbbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbbalance
            // 
            this.lbbalance.AutoSize = true;
            this.lbbalance.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbalance.Location = new System.Drawing.Point(253, 399);
            this.lbbalance.Name = "lbbalance";
            this.lbbalance.Size = new System.Drawing.Size(154, 25);
            this.lbbalance.TabIndex = 28;
            this.lbbalance.Text = "Kembalian (Rp)";
            // 
            // tbtotaltopay
            // 
            this.tbtotaltopay.BackColor = System.Drawing.SystemColors.Control;
            this.tbtotaltopay.Enabled = false;
            this.tbtotaltopay.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotaltopay.ForeColor = System.Drawing.Color.Firebrick;
            this.tbtotaltopay.Location = new System.Drawing.Point(253, 181);
            this.tbtotaltopay.Name = "tbtotaltopay";
            this.tbtotaltopay.ReadOnly = true;
            this.tbtotaltopay.Size = new System.Drawing.Size(227, 54);
            this.tbtotaltopay.TabIndex = 31;
            this.tbtotaltopay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbtotaltopay.TextChanged += new System.EventHandler(this.payamounFinaltotal_changed);
            // 
            // lbtotaltopay
            // 
            this.lbtotaltopay.AutoSize = true;
            this.lbtotaltopay.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotaltopay.Location = new System.Drawing.Point(253, 153);
            this.lbtotaltopay.Name = "lbtotaltopay";
            this.lbtotaltopay.Size = new System.Drawing.Size(174, 25);
            this.lbtotaltopay.TabIndex = 30;
            this.lbtotaltopay.Text = "Total Belanja (Rp)";
            // 
            // rbcardflag
            // 
            this.rbcardflag.AutoSize = true;
            this.rbcardflag.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcardflag.Location = new System.Drawing.Point(119, 14);
            this.rbcardflag.Name = "rbcardflag";
            this.rbcardflag.Size = new System.Drawing.Size(88, 32);
            this.rbcardflag.TabIndex = 1;
            this.rbcardflag.TabStop = true;
            this.rbcardflag.Text = "Kartu";
            this.rbcardflag.UseVisualStyleBackColor = true;
            this.rbcardflag.CheckedChanged += new System.EventHandler(this.Paymoderadiobutton_CheckedChanged);
            // 
            // tbreferenceno
            // 
            this.tbreferenceno.BackColor = System.Drawing.SystemColors.Control;
            this.tbreferenceno.Enabled = false;
            this.tbreferenceno.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbreferenceno.Location = new System.Drawing.Point(13, 443);
            this.tbreferenceno.Name = "tbreferenceno";
            this.tbreferenceno.ReadOnly = true;
            this.tbreferenceno.Size = new System.Drawing.Size(201, 31);
            this.tbreferenceno.TabIndex = 5;
            this.tbreferenceno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbreference
            // 
            this.lbreference.AutoSize = true;
            this.lbreference.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbreference.Location = new System.Drawing.Point(13, 415);
            this.lbreference.Name = "lbreference";
            this.lbreference.Size = new System.Drawing.Size(125, 23);
            this.lbreference.TabIndex = 34;
            this.lbreference.Text = "No. Referensi";
            // 
            // rbcash
            // 
            this.rbcash.AutoSize = true;
            this.rbcash.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcash.Location = new System.Drawing.Point(11, 14);
            this.rbcash.Name = "rbcash";
            this.rbcash.Size = new System.Drawing.Size(88, 32);
            this.rbcash.TabIndex = 0;
            this.rbcash.TabStop = true;
            this.rbcash.Text = "Tunai";
            this.rbcash.UseVisualStyleBackColor = true;
            this.rbcash.CheckedChanged += new System.EventHandler(this.Paymoderadiobutton_CheckedChanged);
            // 
            // lbcardno
            // 
            this.lbcardno.AutoSize = true;
            this.lbcardno.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcardno.Location = new System.Drawing.Point(13, 350);
            this.lbcardno.Name = "lbcardno";
            this.lbcardno.Size = new System.Drawing.Size(92, 23);
            this.lbcardno.TabIndex = 37;
            this.lbcardno.Text = "No. Kartu";
            // 
            // tbcardno
            // 
            this.tbcardno.BackColor = System.Drawing.SystemColors.Control;
            this.tbcardno.Enabled = false;
            this.tbcardno.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcardno.Location = new System.Drawing.Point(13, 378);
            this.tbcardno.MaxLength = 16;
            this.tbcardno.Name = "tbcardno";
            this.tbcardno.ReadOnly = true;
            this.tbcardno.Size = new System.Drawing.Size(201, 31);
            this.tbcardno.TabIndex = 4;
            this.tbcardno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbcash);
            this.panel1.Controls.Add(this.rbcardflag);
            this.panel1.Location = new System.Drawing.Point(13, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 59);
            this.panel1.TabIndex = 38;
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 580);
            this.Controls.Add(this.lbcardno);
            this.Controls.Add(this.tbcardno);
            this.Controls.Add(this.lbreference);
            this.Controls.Add(this.tbreferenceno);
            this.Controls.Add(this.tbtotaltopay);
            this.Controls.Add(this.lbtotaltopay);
            this.Controls.Add(this.tbbalance);
            this.Controls.Add(this.lbbalance);
            this.Controls.Add(this.tbpay);
            this.Controls.Add(this.nbdiscount);
            this.Controls.Add(this.lbdiscount);
            this.Controls.Add(this.nbpay);
            this.Controls.Add(this.lbpay);
            this.Controls.Add(this.tboritotal);
            this.Controls.Add(this.lboritotal);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PayForm";
            this.Text = "PayForm";
            this.Title = "Pembayaran";
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lboritotal, 0);
            this.Controls.SetChildIndex(this.tboritotal, 0);
            this.Controls.SetChildIndex(this.lbpay, 0);
            this.Controls.SetChildIndex(this.nbpay, 0);
            this.Controls.SetChildIndex(this.lbdiscount, 0);
            this.Controls.SetChildIndex(this.nbdiscount, 0);
            this.Controls.SetChildIndex(this.tbpay, 0);
            this.Controls.SetChildIndex(this.lbbalance, 0);
            this.Controls.SetChildIndex(this.tbbalance, 0);
            this.Controls.SetChildIndex(this.lbtotaltopay, 0);
            this.Controls.SetChildIndex(this.tbtotaltopay, 0);
            this.Controls.SetChildIndex(this.tbreferenceno, 0);
            this.Controls.SetChildIndex(this.lbreference, 0);
            this.Controls.SetChildIndex(this.tbcardno, 0);
            this.Controls.SetChildIndex(this.lbcardno, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nbpay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbdiscount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboritotal;
        private System.Windows.Forms.Label lboritotal;
        private System.Windows.Forms.Label lbpay;
        private System.Windows.Forms.NumericUpDown nbpay;
        private System.Windows.Forms.NumericUpDown nbdiscount;
        private System.Windows.Forms.Label lbdiscount;
        private System.Windows.Forms.Button tbpay;
        private System.Windows.Forms.TextBox tbbalance;
        private System.Windows.Forms.Label lbbalance;
        private System.Windows.Forms.TextBox tbtotaltopay;
        private System.Windows.Forms.Label lbtotaltopay;
        private System.Windows.Forms.RadioButton rbcardflag;
        private System.Windows.Forms.TextBox tbreferenceno;
        private System.Windows.Forms.Label lbreference;
        private System.Windows.Forms.RadioButton rbcash;
        private System.Windows.Forms.Label lbcardno;
        private System.Windows.Forms.TextBox tbcardno;
        private System.Windows.Forms.Panel panel1;
    }
}