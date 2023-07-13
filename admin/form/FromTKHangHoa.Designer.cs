namespace form
{
    partial class FromTKHangHoa
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNgayXuat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.slidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sliderbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.sliderbar.Margin = new System.Windows.Forms.Padding(2);
            this.sliderbar.MaximumSize = new System.Drawing.Size(184, 578);
            this.sliderbar.MinimumSize = new System.Drawing.Size(56, 578);
            this.sliderbar.Name = "sliderbar";
            this.sliderbar.Size = new System.Drawing.Size(184, 578);
            this.sliderbar.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 74);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Image = global::form.Properties.Resources.icons8_view_more_24__2_;
            this.MenuButton.Location = new System.Drawing.Point(9, 18);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(34, 35);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThongKe);
            this.panel3.Location = new System.Drawing.Point(2, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 43);
            this.panel3.TabIndex = 2;
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = global::form.Properties.Resources.icons8_collaborator_male_24;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(-21, -11);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(229, 63);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "               Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHangHoa);
            this.panel4.Location = new System.Drawing.Point(2, 127);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 43);
            this.panel4.TabIndex = 3;
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangHoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnHangHoa.Image = global::form.Properties.Resources.icons8_in_inventory_24;
            this.btnHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHangHoa.Location = new System.Drawing.Point(-21, -11);
            this.btnHangHoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHangHoa.Size = new System.Drawing.Size(229, 63);
            this.btnHangHoa.TabIndex = 1;
            this.btnHangHoa.Text = "             Hàng hóa";
            this.btnHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHangHoa.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnNgayXuat);
            this.panel5.Location = new System.Drawing.Point(2, 174);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(182, 43);
            this.panel5.TabIndex = 4;
            // 
            // btnNgayXuat
            // 
            this.btnNgayXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgayXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgayXuat.ForeColor = System.Drawing.Color.White;
            this.btnNgayXuat.Image = global::form.Properties.Resources.icons8_shipping_product_24;
            this.btnNgayXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNgayXuat.Location = new System.Drawing.Point(-21, -11);
            this.btnNgayXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnNgayXuat.Name = "btnNgayXuat";
            this.btnNgayXuat.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNgayXuat.Size = new System.Drawing.Size(229, 63);
            this.btnNgayXuat.TabIndex = 1;
            this.btnNgayXuat.Text = "               ...";
            this.btnNgayXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNgayXuat.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuayLai);
            this.panel2.Location = new System.Drawing.Point(2, 221);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 43);
            this.panel2.TabIndex = 7;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Image = global::form.Properties.Resources.icons8_back_arrow_24;
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.Location = new System.Drawing.Point(-21, -11);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnQuayLai.Size = new System.Drawing.Size(229, 63);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "               Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDangXuat);
            this.panel6.Location = new System.Drawing.Point(2, 268);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(182, 43);
            this.panel6.TabIndex = 6;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = global::form.Properties.Resources.icons8_macos_close_24__1_;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(-21, -11);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(229, 63);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "               Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(189, -63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 559);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // slidebarTimer
            // 
            this.slidebarTimer.Interval = 10;
            this.slidebarTimer.Tick += new System.EventHandler(this.slidebarTimer_Tick);
            // 
            // FromTKHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sliderbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FromTKHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FromTKHangHoa_Load);
            this.sliderbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sliderbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNgayXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer slidebarTimer;
    }
}