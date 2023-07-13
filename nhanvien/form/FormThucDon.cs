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
    public partial class FormThucDon: Form
    {
        bool sliderbarExpand;
        SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Du_An_1;Integrated Security=True");
        SqlDataAdapter sda;
        DataSet ds;

        //bool homeCollapse;
        //bool drinkCollapse;
        public FormThucDon()
        {
            InitializeComponent();
           
        }

        private void showChildFormPanel(object Form)
        {
            if(this.panel16.Controls.Count > 0)
            {
                this.panel16.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle= FormBorderStyle.None;
            this.panel16.Controls.Add(form);
            form.Show();
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


        private void FormThucDon_Load(object sender, EventArgs e)
        {
            conn.Open();

        }

        void HienThi()
        {
            SqlCommand cmd = new SqlCommand("SELECT tenMon as 'Tên Món', soLuong as 'Số Lượng', giaThanh as 'Giá Thành' FROM HoaDon", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvChonMon.DataSource = dt;

        }

        void LayDL()
        {
            string sql = "SELECT tenMon as 'Tên Món', soLuong as 'Số Lượng', giaThanh as 'Giá Thành' FROM HoaDon";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }

        //private void HomeTimer_Tick(object sender, EventArgs e)
        //{
        //    if (homeCollapse)
        //    {
        //        HomeContainer.Height += 10;
        //        if (HomeContainer.Height == HomeContainer.MaximumSize.Height)
        //        {
        //            homeCollapse = false;
        //            HomeTimer.Stop();
        //        }
        //    }
        //    else
        //    {
        //        HomeContainer.Height -= 10;
        //        if (HomeContainer.Height == HomeContainer.MinimumSize.Height)
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

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            HienThi();
            showChildFormPanel(new formcondemo());
        }

        private void btnThucUong_Click(object sender, EventArgs e)
        {
            HienThi();
            showChildFormPanel(new formconthucuong());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            formthanhtoan f1 = new formthanhtoan();
            f1.ShowDialog();
        }
    }
}
