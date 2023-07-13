using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace form
{
    public partial class FormAdmin : Form
    {
        string maNV, taiKhoan, matKhau, role;
        SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Du_An_1;Integrated Security=True");
        bool sliderbarExpand;
        //bool homeCollapse;
        //bool drinkCollapse;
        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(string maNV, string taiKhoan, string matKhau, string role)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.role = role;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void slidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sliderbarExpand)
            {
                sliderbar.Width -= 10;
                if (sliderbar.Width == sliderbar.MinimumSize.Width)
                {
                    sliderbarExpand = false;
                    slidebarTimer.Stop();
                }
            }
            else
            {
                sliderbar.Width += 10;
                if (sliderbar.Width == sliderbar.MaximumSize.Width)
                {
                    sliderbarExpand = true;
                    slidebarTimer.Stop();
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            slidebarTimer.Start();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MainWindow f1 = new MainWindow();
            f1.Show();
            this.Hide();
            
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FormMainMenuNV f1 = new FormMainMenuNV();
            f1.ShowDialog();
            this.Hide();
        }

        private void btnTongKho_Click(object sender, EventArgs e)
        {
            FormTongKho f1 = new FormTongKho();
            f1.ShowDialog();
            this.Hide();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FormSanPham f1 = new FormSanPham();
            f1.ShowDialog();
            this.Hide();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe f1 = new FormThongKe();
            f1.ShowDialog();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            FormDanhMuc f1 = new FormDanhMuc();
            f1.ShowDialog();
            this.Hide();
        }
        
    }
}
