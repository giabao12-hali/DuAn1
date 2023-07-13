namespace form
{
    partial class formthanhtoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvThanhToan = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTienMat = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvThanhToan);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 393);
            this.panel1.TabIndex = 0;
            // 
            // dgvThanhToan
            // 
            this.dgvThanhToan.AllowUserToAddRows = false;
            this.dgvThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThanhToan.Location = new System.Drawing.Point(0, 0);
            this.dgvThanhToan.Name = "dgvThanhToan";
            this.dgvThanhToan.RowHeadersWidth = 51;
            this.dgvThanhToan.RowTemplate.Height = 24;
            this.dgvThanhToan.Size = new System.Drawing.Size(662, 393);
            this.dgvThanhToan.TabIndex = 0;
            this.dgvThanhToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhToan_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnThe);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.panel5.Location = new System.Drawing.Point(369, 411);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(124, 61);
            this.panel5.TabIndex = 6;
            // 
            // btnThe
            // 
            this.btnThe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnThe.Location = new System.Drawing.Point(-21, -12);
            this.btnThe.Name = "btnThe";
            this.btnThe.Size = new System.Drawing.Size(170, 87);
            this.btnThe.TabIndex = 2;
            this.btnThe.Text = "Thẻ";
            this.btnThe.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTienMat);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(550, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 61);
            this.panel2.TabIndex = 7;
            // 
            // btnTienMat
            // 
            this.btnTienMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnTienMat.Location = new System.Drawing.Point(-21, -12);
            this.btnTienMat.Name = "btnTienMat";
            this.btnTienMat.Size = new System.Drawing.Size(170, 87);
            this.btnTienMat.TabIndex = 2;
            this.btnTienMat.Text = "Tiền mặt";
            this.btnTienMat.UseVisualStyleBackColor = false;
            this.btnTienMat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTienMat_MouseClick);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(13, 412);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(99, 28);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBoQua);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.panel3.Location = new System.Drawing.Point(550, 675);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 61);
            this.panel3.TabIndex = 9;
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnBoQua.Location = new System.Drawing.Point(-21, -12);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(170, 87);
            this.btnBoQua.TabIndex = 2;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBoQua_MouseClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnIn);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.panel4.Location = new System.Drawing.Point(550, 492);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 61);
            this.panel4.TabIndex = 10;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnIn.Location = new System.Drawing.Point(-21, -12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(170, 87);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "VAT";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnExcel);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.panel6.Location = new System.Drawing.Point(550, 573);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(124, 61);
            this.panel6.TabIndex = 11;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnExcel.Location = new System.Drawing.Point(-21, -12);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(170, 87);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Xuất file";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // formthanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(686, 748);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formthanhtoan";
            this.Text = "formthanhtoan";
            this.Load += new System.EventHandler(this.formthanhtoan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvThanhToan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnThe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTienMat;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnExcel;
    }
}