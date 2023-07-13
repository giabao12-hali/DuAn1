namespace form
{
    partial class FormMainMenuNV
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.slidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelBan = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnBan6 = new System.Windows.Forms.Button();
            this.btnBan5 = new System.Windows.Forms.Button();
            this.btnBan4 = new System.Windows.Forms.Button();
            this.btnBan3 = new System.Windows.Forms.Button();
            this.btnBan2 = new System.Windows.Forms.Button();
            this.btnBan1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.sliderbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelBan.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sliderbar
            // 
            this.sliderbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sliderbar.Controls.Add(this.panel1);
            this.sliderbar.Controls.Add(this.panel3);
            this.sliderbar.Controls.Add(this.panel2);
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
            this.panel3.Controls.Add(this.btnDangXuat);
            this.panel3.Location = new System.Drawing.Point(3, 100);
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
            // panelBan
            // 
            this.panelBan.Controls.Add(this.button7);
            this.panelBan.Controls.Add(this.button8);
            this.panelBan.Controls.Add(this.button9);
            this.panelBan.Controls.Add(this.btnBan6);
            this.panelBan.Controls.Add(this.btnBan5);
            this.panelBan.Controls.Add(this.btnBan4);
            this.panelBan.Controls.Add(this.btnBan3);
            this.panelBan.Controls.Add(this.btnBan2);
            this.panelBan.Controls.Add(this.btnBan1);
            this.panelBan.Location = new System.Drawing.Point(251, 3);
            this.panelBan.Name = "panelBan";
            this.panelBan.Size = new System.Drawing.Size(868, 477);
            this.panelBan.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(661, 325);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(169, 73);
            this.button7.TabIndex = 8;
            this.button7.Text = "Bàn 9";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(339, 325);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(169, 73);
            this.button8.TabIndex = 7;
            this.button8.Text = "Bàn 8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(26, 325);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(169, 73);
            this.button9.TabIndex = 6;
            this.button9.Text = "Bàn 7";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btnBan6
            // 
            this.btnBan6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnBan6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBan6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBan6.Location = new System.Drawing.Point(661, 176);
            this.btnBan6.Name = "btnBan6";
            this.btnBan6.Size = new System.Drawing.Size(169, 73);
            this.btnBan6.TabIndex = 5;
            this.btnBan6.Text = "Bàn 6";
            this.btnBan6.UseVisualStyleBackColor = false;
            // 
            // btnBan5
            // 
            this.btnBan5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnBan5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBan5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBan5.Location = new System.Drawing.Point(339, 176);
            this.btnBan5.Name = "btnBan5";
            this.btnBan5.Size = new System.Drawing.Size(169, 73);
            this.btnBan5.TabIndex = 4;
            this.btnBan5.Text = "Bàn 5";
            this.btnBan5.UseVisualStyleBackColor = false;
            // 
            // btnBan4
            // 
            this.btnBan4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnBan4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBan4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBan4.Location = new System.Drawing.Point(26, 176);
            this.btnBan4.Name = "btnBan4";
            this.btnBan4.Size = new System.Drawing.Size(169, 73);
            this.btnBan4.TabIndex = 3;
            this.btnBan4.Text = "Bàn 4";
            this.btnBan4.UseVisualStyleBackColor = false;
            // 
            // btnBan3
            // 
            this.btnBan3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnBan3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBan3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan3.Location = new System.Drawing.Point(661, 29);
            this.btnBan3.Name = "btnBan3";
            this.btnBan3.Size = new System.Drawing.Size(169, 73);
            this.btnBan3.TabIndex = 2;
            this.btnBan3.Text = "Bàn 3";
            this.btnBan3.UseVisualStyleBackColor = false;
            this.btnBan3.Click += new System.EventHandler(this.btnBan3_Click);
            // 
            // btnBan2
            // 
            this.btnBan2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnBan2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBan2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan2.Location = new System.Drawing.Point(339, 29);
            this.btnBan2.Name = "btnBan2";
            this.btnBan2.Size = new System.Drawing.Size(169, 73);
            this.btnBan2.TabIndex = 1;
            this.btnBan2.Text = "Bàn 2";
            this.btnBan2.UseVisualStyleBackColor = false;
            this.btnBan2.Click += new System.EventHandler(this.btnBan2_Click);
            // 
            // btnBan1
            // 
            this.btnBan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.btnBan1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBan1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan1.Location = new System.Drawing.Point(26, 29);
            this.btnBan1.Name = "btnBan1";
            this.btnBan1.Size = new System.Drawing.Size(169, 73);
            this.btnBan1.TabIndex = 0;
            this.btnBan1.Text = "Bàn 1";
            this.btnBan1.UseVisualStyleBackColor = true;
            this.btnBan1.Click += new System.EventHandler(this.btnBan1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHoaDon);
            this.panel2.Location = new System.Drawing.Point(3, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 53);
            this.panel2.TabIndex = 3;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Image = global::form.Properties.Resources.icons8_macos_close_24__1_;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(-28, -14);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(305, 77);
            this.btnHoaDon.TabIndex = 1;
            this.btnHoaDon.Text = "               Hóa Đơn CTT";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // FormMainMenuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 712);
            this.Controls.Add(this.panelBan);
            this.Controls.Add(this.sliderbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMenuNV";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormMainMenuNV_Load);
            this.sliderbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelBan.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sliderbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer slidebarTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panelBan;
        private System.Windows.Forms.Button btnBan3;
        private System.Windows.Forms.Button btnBan2;
        private System.Windows.Forms.Button btnBan1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnBan6;
        private System.Windows.Forms.Button btnBan5;
        private System.Windows.Forms.Button btnBan4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHoaDon;
    }
}