﻿namespace form
{
    partial class FormAdmin
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
            this.components = new System.ComponentModel.Container();
            this.sliderbar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTongKho = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.slidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sliderbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // sliderbar
            // 
            this.sliderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sliderbar.Controls.Add(this.panel1);
            this.sliderbar.Controls.Add(this.panel3);
            this.sliderbar.Controls.Add(this.panel4);
            this.sliderbar.Controls.Add(this.panel5);
            this.sliderbar.Controls.Add(this.panel2);
            this.sliderbar.Controls.Add(this.panel7);
            this.sliderbar.Controls.Add(this.panel6);
            this.sliderbar.Controls.Add(this.panel8);
            this.sliderbar.Location = new System.Drawing.Point(0, 0);
            this.sliderbar.MaximumSize = new System.Drawing.Size(245, 712);
            this.sliderbar.MinimumSize = new System.Drawing.Size(75, 712);
            this.sliderbar.Name = "sliderbar";
            this.sliderbar.Size = new System.Drawing.Size(245, 712);
            this.sliderbar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 91);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // MenuButton
            // 
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Image = global::form.Properties.Resources.icons8_view_more_24__2_;
            this.MenuButton.Location = new System.Drawing.Point(12, 22);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(45, 43);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNhanVien);
            this.panel3.Location = new System.Drawing.Point(3, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 53);
            this.panel3.TabIndex = 2;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = global::form.Properties.Resources.icons8_collaborator_male_24;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(-28, -14);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(305, 77);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "               Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTongKho);
            this.panel4.Location = new System.Drawing.Point(3, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 53);
            this.panel4.TabIndex = 3;
            // 
            // btnTongKho
            // 
            this.btnTongKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongKho.ForeColor = System.Drawing.Color.White;
            this.btnTongKho.Image = global::form.Properties.Resources.icons8_in_inventory_24;
            this.btnTongKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongKho.Location = new System.Drawing.Point(-28, -14);
            this.btnTongKho.Name = "btnTongKho";
            this.btnTongKho.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnTongKho.Size = new System.Drawing.Size(305, 77);
            this.btnTongKho.TabIndex = 1;
            this.btnTongKho.Text = "               Tổng Kho";
            this.btnTongKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongKho.UseVisualStyleBackColor = true;
            this.btnTongKho.Click += new System.EventHandler(this.btnTongKho_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSanPham);
            this.panel5.Location = new System.Drawing.Point(3, 218);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 53);
            this.panel5.TabIndex = 4;
            // 
            // btnSanPham
            // 
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Image = global::form.Properties.Resources.icons8_shipping_product_24;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(-28, -14);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSanPham.Size = new System.Drawing.Size(305, 77);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "               Sản Phẩm";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThongKe);
            this.panel2.Location = new System.Drawing.Point(3, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 53);
            this.panel2.TabIndex = 5;
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = global::form.Properties.Resources.icons8_statistical_24;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(-28, -14);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(305, 77);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "               Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnDanhMuc);
            this.panel7.Location = new System.Drawing.Point(3, 336);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(242, 53);
            this.panel7.TabIndex = 6;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnDanhMuc.Image = global::form.Properties.Resources.icons8_diversity_24;
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(-28, -14);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDanhMuc.Size = new System.Drawing.Size(305, 77);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "               Danh mục";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDangXuat);
            this.panel6.Location = new System.Drawing.Point(3, 395);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(242, 53);
            this.panel6.TabIndex = 6;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = global::form.Properties.Resources.icons8_log_out_24;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(-28, -14);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(305, 77);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "               Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnThoat);
            this.panel8.Location = new System.Drawing.Point(3, 454);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(242, 53);
            this.panel8.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::form.Properties.Resources.icons8_macos_close_24__1_;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(-28, -14);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnThoat.Size = new System.Drawing.Size(305, 77);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "               Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // slidebarTimer
            // 
            this.slidebarTimer.Interval = 10;
            this.slidebarTimer.Tick += new System.EventHandler(this.slidebarTimer_Tick);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 712);
            this.Controls.Add(this.sliderbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.sliderbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sliderbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTongKho;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer slidebarTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnThoat;
    }
}