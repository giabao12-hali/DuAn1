using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        bool homeCollapse;
        bool drinkCollapse;
        public FormThucDon()
        {
            InitializeComponent();
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

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (homeCollapse)
            {
                HomeContainer.Height += 10;
                if(HomeContainer.Height == HomeContainer.MaximumSize.Height)
                {
                    homeCollapse = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                HomeContainer.Height -= 10;
                if(HomeContainer.Height == HomeContainer.MinimumSize.Height)
                {
                    homeCollapse = true;
                    HomeTimer.Stop();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void DrinkTimer_Tick(object sender, EventArgs e)
        {
            if (drinkCollapse)
            {
                DrinkContainer.Height += 10;
                if (DrinkContainer.Height == DrinkContainer.MaximumSize.Height)
                {
                    drinkCollapse = false;
                    DrinkTimer.Stop();
                }
            }
            else
            {
                DrinkContainer.Height -= 10;
                if (DrinkContainer.Height == DrinkContainer.MinimumSize.Height)
                {
                    drinkCollapse = true;
                    DrinkTimer.Stop();
                }
            }
        }

        private void btnThucUong_Click(object sender, EventArgs e)
        {
            DrinkTimer.Start();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MainWindow f1 = new MainWindow();
            f1.Show();
            this.Hide();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormMainMenuNV f2 = new FormMainMenuNV();
            f2.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
