namespace form
{
    partial class FormThucDon
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
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDoAn = new System.Windows.Forms.Button();
            this.DrinkContainer = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnThucUong = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.slidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dgvChonMon = new System.Windows.Forms.DataGridView();
            this.sliderbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.HomeContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DrinkContainer.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonMon)).BeginInit();
            this.SuspendLayout();
            // 
            // sliderbar
            // 
            this.sliderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sliderbar.Controls.Add(this.panel1);
            this.sliderbar.Controls.Add(this.HomeContainer);
            this.sliderbar.Controls.Add(this.DrinkContainer);
            this.sliderbar.Controls.Add(this.panel3);
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
            // HomeContainer
            // 
            this.HomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.HomeContainer.Controls.Add(this.panel2);
            this.HomeContainer.Location = new System.Drawing.Point(3, 100);
            this.HomeContainer.Name = "HomeContainer";
            this.HomeContainer.Size = new System.Drawing.Size(242, 55);
            this.HomeContainer.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.btnDoAn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 54);
            this.panel2.TabIndex = 5;
            // 
            // btnDoAn
            // 
            this.btnDoAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoAn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoAn.ForeColor = System.Drawing.Color.White;
            this.btnDoAn.Image = global::form.Properties.Resources.shopping_cart__1_;
            this.btnDoAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoAn.Location = new System.Drawing.Point(-21, -9);
            this.btnDoAn.Name = "btnDoAn";
            this.btnDoAn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDoAn.Size = new System.Drawing.Size(296, 70);
            this.btnDoAn.TabIndex = 6;
            this.btnDoAn.Text = "                Đồ ăn";
            this.btnDoAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoAn.UseVisualStyleBackColor = true;
            this.btnDoAn.Click += new System.EventHandler(this.btnDoAn_Click);
            // 
            // DrinkContainer
            // 
            this.DrinkContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.DrinkContainer.Controls.Add(this.panel13);
            this.DrinkContainer.Location = new System.Drawing.Point(3, 161);
            this.DrinkContainer.Name = "DrinkContainer";
            this.DrinkContainer.Size = new System.Drawing.Size(242, 55);
            this.DrinkContainer.TabIndex = 11;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel13.Controls.Add(this.btnThucUong);
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(242, 54);
            this.panel13.TabIndex = 5;
            // 
            // btnThucUong
            // 
            this.btnThucUong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucUong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucUong.ForeColor = System.Drawing.Color.White;
            this.btnThucUong.Image = global::form.Properties.Resources.icons8_beach_cocktail_24;
            this.btnThucUong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucUong.Location = new System.Drawing.Point(-16, -9);
            this.btnThucUong.Name = "btnThucUong";
            this.btnThucUong.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnThucUong.Size = new System.Drawing.Size(296, 70);
            this.btnThucUong.TabIndex = 6;
            this.btnThucUong.Text = "              Thức uống";
            this.btnThucUong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThucUong.UseVisualStyleBackColor = true;
            this.btnThucUong.Click += new System.EventHandler(this.btnThucUong_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDangXuat);
            this.panel3.Location = new System.Drawing.Point(3, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 53);
            this.panel3.TabIndex = 2;
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
            // slidebarTimer
            // 
            this.slidebarTimer.Interval = 10;
            this.slidebarTimer.Tick += new System.EventHandler(this.slidebarTimer_Tick);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Controls.Add(this.panel20);
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Location = new System.Drawing.Point(241, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(885, 712);
            this.panel14.TabIndex = 2;
            // 
            // panel16
            // 
            this.panel16.AutoSize = true;
            this.panel16.Location = new System.Drawing.Point(10, 378);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(856, 331);
            this.panel16.TabIndex = 5;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.panel20.Controls.Add(this.button10);
            this.panel20.Location = new System.Drawing.Point(484, 322);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(150, 47);
            this.panel20.TabIndex = 4;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(-22, -5);
            this.button10.Name = "button10";
            this.button10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button10.Size = new System.Drawing.Size(196, 58);
            this.button10.TabIndex = 3;
            this.button10.Text = "Xóa món";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.panel17.Controls.Add(this.btnThanhToan);
            this.panel17.Location = new System.Drawing.Point(716, 322);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(150, 47);
            this.panel17.TabIndex = 2;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(-22, -5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThanhToan.Size = new System.Drawing.Size(196, 58);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dgvChonMon);
            this.panel15.Location = new System.Drawing.Point(10, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(856, 310);
            this.panel15.TabIndex = 0;
            // 
            // dgvChonMon
            // 
            this.dgvChonMon.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvChonMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChonMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChonMon.GridColor = System.Drawing.Color.White;
            this.dgvChonMon.Location = new System.Drawing.Point(0, 0);
            this.dgvChonMon.Name = "dgvChonMon";
            this.dgvChonMon.RowHeadersWidth = 51;
            this.dgvChonMon.RowTemplate.Height = 24;
            this.dgvChonMon.Size = new System.Drawing.Size(856, 310);
            this.dgvChonMon.TabIndex = 0;
            // 
            // FormThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 712);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.sliderbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThucDon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThucDon";
            this.Load += new System.EventHandler(this.FormThucDon_Load);
            this.sliderbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.HomeContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.DrinkContainer.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sliderbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer slidebarTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDoAn;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Panel DrinkContainer;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnThucUong;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView dgvChonMon;
        private System.Windows.Forms.Panel panel16;
    }
}