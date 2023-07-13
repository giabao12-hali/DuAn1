namespace form
{
    partial class FormSanPham
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.slidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.btnThit = new System.Windows.Forms.Button();
            this.btnNgayNhap = new System.Windows.Forms.Button();
            this.btnNgayXuat = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.sliderbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
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
            this.sliderbar.Controls.Add(this.panel6);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThit);
            this.panel3.Location = new System.Drawing.Point(3, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 53);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNgayNhap);
            this.panel4.Location = new System.Drawing.Point(3, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 53);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnNgayXuat);
            this.panel5.Location = new System.Drawing.Point(3, 218);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 53);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDangXuat);
            this.panel6.Location = new System.Drawing.Point(3, 336);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(242, 53);
            this.panel6.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Location = new System.Drawing.Point(3, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 53);
            this.panel2.TabIndex = 7;
            // 
            // slidebarTimer
            // 
            this.slidebarTimer.Interval = 10;
            this.slidebarTimer.Tick += new System.EventHandler(this.slidebarTimer_Tick);
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
            // btnThit
            // 
            this.btnThit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThit.ForeColor = System.Drawing.Color.White;
            this.btnThit.Image = global::form.Properties.Resources.icons8_collaborator_male_24;
            this.btnThit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThit.Location = new System.Drawing.Point(-28, -14);
            this.btnThit.Name = "btnThit";
            this.btnThit.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnThit.Size = new System.Drawing.Size(305, 77);
            this.btnThit.TabIndex = 1;
            this.btnThit.Text = "               Thịt";
            this.btnThit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThit.UseVisualStyleBackColor = true;
            // 
            // btnNgayNhap
            // 
            this.btnNgayNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgayNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgayNhap.ForeColor = System.Drawing.Color.White;
            this.btnNgayNhap.Image = global::form.Properties.Resources.icons8_in_inventory_24;
            this.btnNgayNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNgayNhap.Location = new System.Drawing.Point(-28, -14);
            this.btnNgayNhap.Name = "btnNgayNhap";
            this.btnNgayNhap.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNgayNhap.Size = new System.Drawing.Size(305, 77);
            this.btnNgayNhap.TabIndex = 1;
            this.btnNgayNhap.Text = "               ...";
            this.btnNgayNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNgayNhap.UseVisualStyleBackColor = true;
            // 
            // btnNgayXuat
            // 
            this.btnNgayXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgayXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgayXuat.ForeColor = System.Drawing.Color.White;
            this.btnNgayXuat.Image = global::form.Properties.Resources.icons8_shipping_product_24;
            this.btnNgayXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNgayXuat.Location = new System.Drawing.Point(-28, -14);
            this.btnNgayXuat.Name = "btnNgayXuat";
            this.btnNgayXuat.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNgayXuat.Size = new System.Drawing.Size(305, 77);
            this.btnNgayXuat.TabIndex = 1;
            this.btnNgayXuat.Text = "               ...";
            this.btnNgayXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNgayXuat.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = global::form.Properties.Resources.icons8_macos_close_24__1_;
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
            // btnQuayLai
            // 
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Image = global::form.Properties.Resources.icons8_back_arrow_24;
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.Location = new System.Drawing.Point(-28, -14);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnQuayLai.Size = new System.Drawing.Size(305, 77);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "               Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 712);
            this.Controls.Add(this.sliderbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSanPham";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSanPham";
            this.sliderbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sliderbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNgayNhap;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNgayXuat;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer slidebarTimer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuayLai;
    }
}