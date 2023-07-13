namespace form
{
    partial class formThanhToanThe
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMomo = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBoQua);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.panel3.Location = new System.Drawing.Point(550, 476);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 61);
            this.panel3.TabIndex = 9;
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBoQua.Location = new System.Drawing.Point(-21, -12);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(170, 87);
            this.btnBoQua.TabIndex = 2;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBoQua_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMomo);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(216, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 126);
            this.panel1.TabIndex = 10;
            // 
            // btnMomo
            // 
            this.btnMomo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnMomo.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMomo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMomo.Location = new System.Drawing.Point(-21, -12);
            this.btnMomo.Name = "btnMomo";
            this.btnMomo.Size = new System.Drawing.Size(299, 154);
            this.btnMomo.TabIndex = 2;
            this.btnMomo.Text = "MOMO";
            this.btnMomo.UseVisualStyleBackColor = false;
            this.btnMomo.Click += new System.EventHandler(this.btnMomo_Click);
            // 
            // formThanhToanThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(686, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formThanhToanThe";
            this.ShowIcon = false;
            this.Text = "Thanh Toán Thẻ";
            this.Load += new System.EventHandler(this.formthanhtoan_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMomo;
    }
}