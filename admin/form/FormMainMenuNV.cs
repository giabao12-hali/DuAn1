using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class FormMainMenuNV : Form
    {
        string maNV, taiKhoan, matKhau, role;
        SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Du_An_1;Integrated Security=True");
        bool sliderbarExpand;
        //bool homeCollapse;
        //bool drinkCollapse;
        public FormMainMenuNV()
        {
            InitializeComponent();
        }

        public FormMainMenuNV(string maNV, string taiKhoan, string matKhau, string role)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.role = role;
        }

        private void FormMainMenuNV_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void slidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sliderbarExpand)
            {
                sliderbar.Width -= 10;
                if(sliderbar.Width == sliderbar.MinimumSize.Width)
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

        //private void HomeTimer_Tick(object sender, EventArgs e)
        //{
        //    if (homeCollapse)
        //    {
        //        HomeContainer.Height += 10;
        //        if(HomeContainer.Height == HomeContainer.MaximumSize.Height)
        //        {
        //            homeCollapse = false;
        //            HomeTimer.Stop();
        //        }
        //    }
        //    else
        //    {
        //        HomeContainer.Height -= 10;
        //        if(HomeContainer.Height == HomeContainer.MinimumSize.Height)
        //        {
        //            homeCollapse = true;
        //            HomeTimer.Stop();
        //        }
        //    }
        //}

        //private void btnHome_Click(object sender, EventArgs e)
        //{
        //    HomeTimer.Start();
        //}

        //private void DrinkTimer_Tick(object sender, EventArgs e)
        //{
        //    if (drinkCollapse)
        //    {
        //        DrinkContainer.Height += 10;
        //        if (DrinkContainer.Height == DrinkContainer.MaximumSize.Height)
        //        {
        //            drinkCollapse = false;
        //            DrinkTimer.Stop();
        //        }
        //    }
        //    else
        //    {
        //        DrinkContainer.Height -= 10;
        //        if (DrinkContainer.Height == DrinkContainer.MinimumSize.Height)
        //        {
        //            drinkCollapse = true;
        //            DrinkTimer.Stop();
        //        }
        //    }
        //}

        //private void btnThucUong_Click(object sender, EventArgs e)
        //{
        //    DrinkTimer.Start();
        //}

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MainWindow f1 = new MainWindow();
            f1.Show();
            this.Hide();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if(role == "nhanvien")
            {
                btnQuayLai.Enabled = false;
            }
            //FormAdmin f1 = new FormAdmin();
            //f1.ShowDialog();
            //this.Hide();
        }

        private void panelBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            FormThucDon f1 = new FormThucDon();
            f1.ShowDialog();
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            FormThucDon f1 = new FormThucDon();
            f1.ShowDialog();
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            FormThucDon f1 = new FormThucDon();
            f1.ShowDialog();
        }

        //private void btnThucDon_Click(object sender, EventArgs e)
        //{
        //    FormThucDon f1 = new FormThucDon();
        //    f1.ShowDialog();
        //    this.Hide();
        //}
    }
}
